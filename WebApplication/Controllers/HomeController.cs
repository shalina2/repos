using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    
    public class HomeController:Controller
    {
        [HttpGet]

        public IActionResult index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int firstNumber, int secondNumber)
        {
            return RedirectToAction("Results", new {firstNumber,secondNumber });
        }
        [HttpGet]
        public IActionResult Results(int first)
    }
}
