﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnagramApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnagramApp.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public AnagramChecker AnagramChecker;

        public HomeController(AnagramChecker anagramChecker)
        {
            AnagramChecker = anagramChecker;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("check")]
        public IActionResult Check()
        {

            return RedirectToAction("result");
        }

        [HttpGet("result")]
        public IActionResult Result()
        {
            return View();
        }
    }
}
