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
using Microsoft.AspNetCore.Http;
using NewsWebApp.Models;
using NewsWebApp.ViewModels;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            var post = _context.Posts.Include(p => p.PostCategories).ThenInclude(c => c.Category).Include(tag => tag.PostTags).ThenInclude(pt => pt.Tag).OrderByDescending(pid => pid.CreatedDate);

            return View(post);
        }

        [HttpGet]
        public IActionResult Create()
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

            var rand = new Random();
            var slug = SlugHelper.GenerateSlug(newspost.Name);
            while (_context.Posts.Any(t => t.Slug == slug))
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



            string unique = fileUpload(newspost.Picture);



            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userName = User.FindFirstValue(ClaimTypes.Name);
            var user = _context.Users.Single(u => u.Id == userId);

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
                Slug = newspost.Slug,
                AppUser = user




            };
            _context.Add(postModel);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var post = _context.Posts.Find(id);
            var viewModel = new PostCreateViewModel
            {
                Categories = _context.Categories.ToList(),
                Tags = _context.Tags.ToList(),
                Id = post.Id,
                Name = post.Name,
                Slug = post.Slug,
                Content = post.Content,
                PostStatus = post.PostStatus,
                Post = _context.Posts
                .Include(p => p.PostCategories).Include(pc => pc.PostTags)
                .FirstOrDefault(p => p.Id == id),
                SelectedCategory = post.PostCategories.Select(pc => pc.CategoryId).ToList(),
                SelectedTag = post.PostTags.Select(pt => pt.TagId).ToList(),


            };

            ViewBag.Categories = new SelectList(_context.Categories, "Id", "Name");
            ViewBag.Tags = new SelectList(_context.Tags, "Id", "Name");



            if (viewModel.Post == null)
                return View("NotFound");
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(PostCreateViewModel newspost)
        {
            string filename = fileUpload(newspost.Picture);


            var rand = new Random();
            var slug = SlugHelper.GenerateSlug(newspost.Name);
            while (_context.Posts.Any(t => t.Slug == slug))
            {
                slug += rand.Next(1000, 9999);
            }
            newspost.Slug = slug;


            if (!ModelState.IsValid)
                return View();

            var postInDb = _context.Posts.Include(p => p.PostCategories).Include(p => p.PostTags)
                    .Where(p => p.Id == newspost.Id).FirstOrDefault();


            postInDb.Content = newspost.Content;
            postInDb.Name = newspost.Name;
            postInDb.PostCategories = new List<PostCategory>();
            foreach (var CategoryId in newspost.SelectedCategory)
            {
                postInDb.PostCategories.Add(new PostCategory { CategoryId = CategoryId });
            }
            postInDb.PostTags = new List<PostTag>();
            foreach (var TagId in newspost.SelectedTag)
            {
                postInDb.PostTags.Add(new PostTag { TagId = TagId });
            }

            postInDb.PostStatus = newspost.PostStatus;
            if (filename != null)
                postInDb.Picture = filename;
            postInDb.Slug = newspost.Slug;
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult Details(int id)
        {
            var post = _context.Posts.Include(news => news.PostCategories).ThenInclude(c => c.Category).Include(tag => tag.PostTags).ThenInclude(pt => pt.Tag).Include(u=>u.AppUser).FirstOrDefault(pt => pt.Id == id);
            if (post == null)
                return View("NotFound");
            var p = post.PostCategories.Select(pn => pn.CategoryId);
            ViewData["relatedPost"] = _context.Posts.Where(n => n.PostCategories.Any(pc => pc.CategoryId == n.Id)).ToList();
            ViewData["latest"] = _context.Posts.Include(l => l.PostCategories).ThenInclude(c => c.Category).Include(tag => tag.PostTags).ThenInclude(pt => pt.Tag).Include(u=>u.AppUser).ToList().OrderByDescending(n => n.CreatedDate);
            return View(post);
        }



        public IActionResult PostByCat(int? id)
        {
            var post = _context.Posts.Where(p => p.PostCategories.Any(pc => pc.CategoryId == id)).OrderByDescending(p => p.CreatedDate).ToList();

            if (post.Count == 0)
            {
                Response.StatusCode = 404;
                return View("NotFound", id);
            }
            ViewData["category"] = _context.Categories.SingleOrDefault(p => p.Id == id).Name;
            return View(post);
        }


        public IActionResult PostByTag(int id)
        {

            var post = _context.Posts.Where(p => p.PostTags.Any(pc => pc.TagId == id)).OrderByDescending(p => p.CreatedDate).ToList();

            if (post.Count == 0)
                return View("NotFound", id);
            ViewData["tag"] = _context.Tags.FirstOrDefault(p => p.Id == id).Name;
            return View(post);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var post = _context.Posts.Include(pst => pst.PostCategories).ThenInclude(c => c.Category).Include(tag => tag.PostTags).ThenInclude(pt => pt.Tag).FirstOrDefault(pst => pst.Id == id);

            if (post == null)
                return View("NotFound");
            var p = post.PostCategories.Select(pcat => pcat.CategoryId);
            return View(post);
        }

        public IActionResult DeleteConfirm(int id)
        {
            var post = _context.Posts.Find(id);
            if (post == null)
                return RedirectToAction(nameof(Index));
            _context.Remove(post);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        string fileUpload(IFormFile file)
        {
            string unique = null;
            try
            {
                if (file.FileName != null)

                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "uploads");
                    unique = Guid.NewGuid().ToString() + "_" + file.FileName;
                    string filePath = Path.Combine(uploadsFolder, unique);
                    file.CopyTo(new FileStream(filePath, FileMode.Create));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return unique;
        }

    }
}
