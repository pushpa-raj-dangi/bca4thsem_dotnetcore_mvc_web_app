using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewsWebApp.Data;
using NewsWebApp.Helpers;
using NewsWebApp.Models;
using NewsWebApp.ViewModels;


namespace NewsWebApp.Controllers
{
    [Authorize]
    public class TagsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TagsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()

        {
            var tags = _context.Tags.ToList();
            var viewModel = new TagViewModel
            {
                Tags = tags,
            };

            return View(viewModel);
        }


        [HttpPost]
        public IActionResult Create(Tag tag)
        {
            if (!ModelState.IsValid)
                return View();
            tag.Slug = SlugHelper.GenerateSlug(tag.Name);
            _context.Add(tag);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var tag = _context.Tags.SingleOrDefault(t => t.Id == id);
            if (tag == null)
                return NotFound();
            return View("Edit",tag);
        }



    }
}