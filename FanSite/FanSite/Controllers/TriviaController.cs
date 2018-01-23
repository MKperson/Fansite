using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FanSite.Controllers
{
    public class TriviaController : Controller
    {
        public IActionResult Index()
        {
            return View("TriviaQuiz");
        }
        //TODO Multipule Choice
        //Form With Questions and Radio buttons
        //5-10 questions
        //display right or wrong for each answer
        //total right
    }
}