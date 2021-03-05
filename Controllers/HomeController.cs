using System;
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
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var viewModel = new PostViewModel
            {
                Posts = _context.Posts.Include(p => p.Categories).Include(c => c.Tags).ToList()
            };

            var homeViewModel = new HomeViewModel
            {
                PoliticsNews = _context.Posts.Where(p => p.PostCategories.Any(pc => pc.CategoryId == 5)).ToList().Take(3),

                LatestUpdate = _context.Posts.Include(p => p.PostCategories).ThenInclude(c => c.Category).Include(tag => tag.PostTags).ThenInclude(pt => pt.Tag).Take(3).OrderByDescending(p=>p.Id),
                Categories = _context.Categories.ToList()

        };

            if (!User.Identity.IsAuthenticated)
                return View();
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
    }
}
