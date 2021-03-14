using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NewsWebApp.Models;
using NewsWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsWebApp.Controllers
{
    public class Admin : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public Admin(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        [HttpGet]   
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoleAsync(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };

                IdentityResult result = await roleManager.CreateAsync(identityRole);
                if(result.Succeeded)
                {
                    return RedirectToAction("roles","admin");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Roles()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }
    }
}
