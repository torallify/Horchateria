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
        SqlConnection connection;
        public ProductController(IConfiguration config)
        {
            ConfigRoot = config;
            connection = new SqlConnection(ConfigRoot.GetConnectionString("horchateriaDB"));
        }

        public IActionResult Index()
        {
            string queryString = "SELECT * FROM Products ORDER BY Category";
            IEnumerable<Product> Products = connection.Query<Product>(queryString);

            ViewData["Products"] = Products;
            return View("ProductIndex");
        }
    }
}
