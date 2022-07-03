using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<product> products = new List<product>();
            for (int i = 0; i < 10; i++)
            {
                products.Add(new product()
                {
                    Id = "p-"+i,
                    Name = "Product " + (i + 1),
                    Quantity=i
                });
            }
            return View(products);
        }

        public ActionResult Info()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(product p)
        {
            if(ModelState.IsValid)
            {
                TempData["Name"] = p.Name;
                TempData["Id"] = p.Id;
                TempData["Quantity"] = p.Quantity;
                TempData["msg"] = "Product created successfully";
                return Redirect("/Product/Info");
            }
            else
            {
                return View(p);
            }
        }
    }
}