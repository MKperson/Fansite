using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FanSite.Models;

namespace FanSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "The Home page.";
            return View();
        }

        public IActionResult History()
        {
            ViewData["Message"] = "Your History page.";

            return View();
        }

        public IActionResult Stories()
        {
            ViewData["Message"] = "Your Story page.";

            return View();
        }
        [HttpPost]
        public IActionResult PostStory(string title,DateTime date,string story)
        {
            ViewData["Title"] = title;
            ViewData["Date"] = date.ToShortDateString();
            ViewData["Story"] = story;
            return View("Stories");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
