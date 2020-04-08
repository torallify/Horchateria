using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Horchateria.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Horchateria.Controllers
{
    public class RegisterController : Controller
    {
        // GET: /<controller>/

        [HttpGet]
        public IActionResult Index(int? id)
        {
            ViewData["id"] = id;
            return View("RegisterIndex");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(UserData userInput)
        {
            if (ModelState.IsValid)
            {
                return View(userInput);
            }
            else
            {
                ViewData["errorMsg"] = "Your form had errors. Please correct and re-submit";
                return View("RegisterIndex", userInput);
            }
        }
    }
}
