using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FanSite.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FanSite.Controllers
{
    public class AuthController : Controller
    {

        private UserManager<User> userManager;
        public AuthController(UserManager<User> um)
        {
            userManager = um;
        }


        public IActionResult Index()
        {
            return View();
        }

        public ViewResult ShowAccounts() => View(userManager.Users);


        // Action methods that modify the database

        public ViewResult CreateAccount() => View();

        [HttpPost]
        public async Task<IActionResult> CreateAccount(AccountViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    UserName = model.UserName,
                    Email = model.Email
                };

                IdentityResult result
                    = await userManager.CreateAsync(user, model.Password); //this is where all the work is 
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }
    }
}