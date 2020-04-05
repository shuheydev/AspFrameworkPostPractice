using AspFrameworkPostPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace AspFrameworkPostPractice.Controllers
{
    public class ProductsController : Controller
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        [HttpPost]
        public ActionResult GetProduct(string[] names,FormCollection formData)
        {
            return Json(names);
        }
    }
}
