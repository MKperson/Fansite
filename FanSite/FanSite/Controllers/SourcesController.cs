using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FanSite.Controllers
{
    public class SourcesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "The Sources home page.";
            return View();
        }
        public IActionResult Books()
        {
            ViewData["Message"] = "The Books page.";
            return View();
        }
        public IActionResult Links()
        {
            ViewData["Message"] = "The Links page.";
            return View();
        }
    }
}