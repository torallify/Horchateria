﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Horchateria.Models;

namespace Horchateria.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register(int? id)
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult AddUser(string fname, string lname, string email, string phonenumber, string password)
        {
            ViewData["fname"] = fname;
            ViewData["lname"] = lname;
            ViewData["fullname"] = fname + " " + lname;
            ViewData["email"] = email;
            ViewData["phonenumber"] = phonenumber;
            ViewData["password"] = password;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}