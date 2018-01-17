﻿using Microsoft.AspNetCore.Mvc;
using SimbaProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public HomeController(LibraryRepository libraryRepository)
        {
            LibraryRepository = libraryRepository;
        }

        public LibraryRepository LibraryRepository { get; set; }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
