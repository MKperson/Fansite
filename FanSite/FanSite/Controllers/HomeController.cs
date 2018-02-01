using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FanSite.Models;
using FanSite.Repositories;

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

        public ViewResult Stories(string title, DateTime date,string story)
        {
            StoryModel post = new StoryModel { Title = title, Date = date, Story = story };

            return View(post);
        }
        [HttpPost]
        public IActionResult PostStory()
        {
            //ViewData["Title"] = title;
            //ViewData["Date"] = date.ToShortDateString();
            //ViewData["Story"] = story;
            return View();
        }
        public ViewResult AllStorys()
        {
            return View();
        }
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
