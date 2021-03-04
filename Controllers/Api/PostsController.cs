using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsWebApp.Data;
using NewsWebApp.Models;

namespace NewsWebApp.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase

    {
        private readonly ApplicationDbContext _context;

        public PostsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult All()
        {
            var listCategory = _context.Categories.ToList();
            var posts = _context.Posts.Include(ps => ps.PostCategories).ThenInclude(pc => pc.Category).Include(p=>p.PostTags).ThenInclude(c=>c.Tag).ToList();

            return  Ok(posts);
        }

        [HttpGet("api/[controller]/{id}")]
        public IActionResult GetSingle(int id)
        {
            var posts = _context.Posts.SingleOrDefault(ps=>ps.Id==id);
            return Ok(posts);
        }

    }


}