using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Horchateria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Horchateria.Controllers
{
    public class ProductController : Controller
    {
        IConfiguration ConfigRoot;
        DAL dal;
        public ProductController(IConfiguration config)
        {
            ConfigRoot = config;
            dal = new DAL(ConfigRoot.GetConnectionString("horchateriaDB"));
        }

        public IActionResult Index()
        {

            ViewData["Products"] = dal.GetProductCategories();
            return View("ProductIndex");
        }

        public IActionResult Cat(string cat)
        {
            ViewData["Title"] = cat;
            ViewData["Products"] = dal.GetProductsInCategory(cat);

            return View();
        }

        public IActionResult Detail(int id)
        {
            Product prod = dal.GetProductByID(id);

            if (prod == null)
            {
                return View("NoSuchItem");
            }
            else
            {
                ViewData["Title"] = prod.Name;
                ViewData["Product"] = prod;
                return View();
            }
        }
    }
}
