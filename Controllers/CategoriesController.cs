using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsWebApp.Data;
using NewsWebApp.Helpers;
using NewsWebApp.Models;
using NewsWebApp.ViewModels;

namespace NewsWebApp.Controllers
{
    [Authorize]
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var viewModel = new CategoryViewModel
            {
                Categories = _context.Categories.ToList()

            };
            return View(viewModel);
        }


        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (category.Id == 0)
            {
                _context.Categories.Add(category);
            }
            else
            {
                var categoryIndb = _context.Categories.Single(c => c.Id == category.Id);
                categoryIndb.Name = category.Name;
                categoryIndb.Slug = SlugHelper.GenerateSlug(category.Name);


            };

            if (!ModelState.IsValid)
                return View();
            var slug = SlugHelper.GenerateSlug(category.Name);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


       


        public IActionResult Edit(int id)
       {


            var categories = _context.Categories.SingleOrDefault(c => c.Id == id);

           if (categories == null)
               return NotFound();

           return View("Edit",categories);
        }
    }
}