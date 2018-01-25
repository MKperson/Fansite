using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FanSite.Models;

namespace FanSite.Controllers
{
    public class TriviaController : Controller
    {
        /*public IActionResult Index()
        {
            TriviaLogic logic = new TriviaLogic();
            return View("TriviaQuiz",logic);
        }*/
        //[HttpPost]
        public IActionResult Index(string Q1,string Q2,string Q3,string Q4,string Q5)
        {
            TriviaLogic logic = new TriviaLogic(Q1, Q2, Q3, Q4, Q5);
            return View("TriviaQuiz",logic);
        }
        //TODO Multipule Choice
        //Form With Questions and Radio buttons DONE
        //5-10 questions DONE
        //display right or wrong for each answer
        //total right
    }
}