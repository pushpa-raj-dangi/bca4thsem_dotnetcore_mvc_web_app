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
        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid)
                return View();
            category.Slug = SlugHelper.GenerateSlug(category.Name);
            _context.Add(category);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Edit(Category cat)
        {
            var rand = new Random();
            var slug = SlugHelper.GenerateSlug(cat.Name);
            while (_context.Tags.Any(t => t.Slug == slug))
            {
                slug += rand.Next(1000, 9999);
            }
            cat.Slug = slug;
            if (!ModelState.IsValid)
                return View();
            _context.Update(cat);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Edit(int id)
        {
            var categories = _context.Categories.SingleOrDefault(c => c.Id == id);

            if (categories == null)
                return NotFound();

            return View("Edit", categories);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var category = _context.Categories.Find(id);
            if (category == null)
                return RedirectToAction(nameof(Index));
            return View(category);
        }

        public IActionResult DeleteConfirm(int id)
        {
            var category = _context.Categories.Find(id);
            if (category == null)
                return RedirectToAction(nameof(Index));
            _context.Remove(category);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}