﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NewsWebApp.Data;
using NewsWebApp.Models;
using NewsWebApp.ViewModels;
namespace NewsWebApp.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        [ResponseCache(Duration = 5, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Index()
        {
            var viewModel = new PostViewModel
            {
                Posts = _context.Posts.Include(p => p.Categories).Include(c => c.Tags).ToList()
            };


            var homeViewModel = new HomeViewModel
            {
                PoliticsNews = GetPostsByCategory(7,4),
                EntertainmentNews = GetPostsByCategory(2),
                FeatureNews = GetPostsByCategory(14, 3),
                InternationalNews = GetPostsByCategory(4),
                BusinessNews = GetPostsByCategory(8, 4),
                SportsNews = GetPostsByCategory(1),
                TechnologyNews = GetPostsByCategory(1, 5),
                LatestUpdate = _context.Posts.Include(u => u.AppUser).Include(p => p.PostCategories).ThenInclude(c => c.Category).Include(tag => tag.PostTags).ThenInclude(pt => pt.Tag).Take(5).OrderByDescending(p => p.Id).Where(p=>p.PostStatus ==PostStatus.Publish),
                Categories = _context.Categories.ToList(),
                //PostsByAuthor = _context.Posts.Include(post => post.AppUser).ToList()
        };

            //if (!User.Identity.IsAuthenticated)
            //    return View();
            return View("Notlogin", homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       
        public IEnumerable<Post> GetPostsByCategory(int? id, int limit=3)
        {
            return _context.Posts.Where(p => p.PostCategories.Any(pc => pc.CategoryId == id)).Take(limit).Where(p=>p.PostStatus == PostStatus.Publish).ToList();
        }
    }
}
