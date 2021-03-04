using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsWebApp.Data;
using NewsWebApp.Helpers;
using NewsWebApp.Models;
using NewsWebApp.ViewModels;

namespace NewsWebApp.Controllers
{
    [Authorize]
    public class PostsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment hostingEnvironment;
        public PostsController(ApplicationDbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            //var posts = _context.Posts.Include(cat=>cat.Categories).ToList();
            //var postVm = new PostViewModel
            //{
            //    Posts = _context.Posts.Include(post => post.PostCategories).ThenInclude(pt=>pt.Category).ToList(),

            //};
            var post = _context.Posts.Include(p => p.PostCategories).ThenInclude(c => c.Category).Include(tag=>tag.PostTags).ThenInclude(pt=>pt.Tag)
               
               .OrderByDescending(p => p.Id);
            return View(post);
        }

        public  IActionResult Create()
        {
            var viewModel = new PostCreateViewModel
            {
                Tags = _context.Tags.ToList(),
                Categories = _context.Categories.ToList(),
                Posts = _context.Posts.Include(p => p.Categories).Include(c => c.Tags).ToList(),
            };
            ViewData["categories"] = _context.Categories.ToList();
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Create(PostCreateViewModel newspost, int[] SelectedCategoryIds, int[] SelectedTagIds)
        {
            string unique = null;

            if (newspost.Picture.FileName != null)
            {
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "uploads");
                unique = Guid.NewGuid().ToString() + "_" + newspost.Picture.FileName;
                string filePath = Path.Combine(uploadsFolder, unique);
                newspost.Picture.CopyTo(new FileStream(filePath, FileMode.Create));


            }

            var rand = new Random();
            var slug = SlugHelper.GenerateSlug(newspost.Name);
            while ( _context.Posts.Any(t => t.Slug == slug))
            {
                slug += rand.Next(1000, 9999);
            }
            newspost.Slug = slug;


            foreach (var selectedCatId in SelectedCategoryIds)
            {
                newspost.PostCategories.Add(new PostCategory { CategoryId = selectedCatId });
            }

            foreach (var selectedTagId in SelectedTagIds)
            {
                newspost.PostTags.Add(new PostTag { TagId = selectedTagId });
            }


            if (!ModelState.IsValid)
                return View();
            
            var postModel = new Post
            {
                Content = newspost.Content,
                Name = newspost.Name,
                Categories = newspost.Categories,
                Tags = newspost.Tags,
                PostCategories = newspost.PostCategories,
                PostStatus = newspost.PostStatus,
                Picture = unique,
                PostTags = newspost.PostTags,
                Slug = newspost.Slug
            };
           _context.Add(postModel);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var post = _context.Posts.Include(p => p.PostCategories).ThenInclude(c => c.Category).Include(tag => tag.PostTags).ThenInclude(pt => pt.Tag).FirstOrDefault(p=>p.Id==id);
            var p = post.PostCategories.Select(p => p.CategoryId);
            ViewData["relatedPost"] = _context.Posts.Where(p => p.PostCategories.Any(pc => pc.CategoryId == p.Id)).ToList();
          
            return View(post);
        }


       
        public IActionResult PostByCat(int id)
        {
            var post = _context.Posts.Where(p => p.PostCategories.Any(pc => pc.CategoryId == id)).ToList();
            ViewData["category"] = _context.Categories.SingleOrDefault(p=>p.Id==id).Name;
            return View(post);
        }

      
        public IActionResult PostByTag(int id)
        {

            var post = _context.Posts.Where(p => p.PostTags.Any(pc => pc.TagId == id)).ToList();
            ViewData["tag"] = _context.Tags.SingleOrDefault(p => p.Id == id).Name;

            return View(post);
        }

        public IActionResult Edit(int id)
        {
            var post = _context.Posts.Include(p => p.PostCategories).ThenInclude(c => c.Category).Include(tag => tag.PostTags).ThenInclude(pt => pt.Tag).FirstOrDefault(p => p.Id == id);
            var p = post.PostCategories.Select(p => p.CategoryId);
            ViewData["relatedPost"] = _context.Posts.Where(p => p.PostCategories.Any(pc => pc.CategoryId == p.Id)).ToList();

            return View(post);
        }

    }
}
