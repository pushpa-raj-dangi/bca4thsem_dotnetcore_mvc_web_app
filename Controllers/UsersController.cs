using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace NewsWebApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly IdentityDbContext _db;

        public UsersController(IdentityDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var users = _db.Users.ToList();
            ViewData["users"] = users;
            return View(users);
        }
    }
}