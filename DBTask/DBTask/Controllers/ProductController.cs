using DBTask.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBTask.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var db = new DotNetEntities();
            var products = db.Products.ToList();
            return View(products);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var db = new DotNetEntities();
            var product = (from p in db.Products where p.Id == id select p).SingleOrDefault();
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(Product pr)
        {
            if(ModelState.IsValid)
            {
                var db = new DotNetEntities();
                var product = (from p in db.Products where p.Id == pr.Id select p).SingleOrDefault();
                product.Name = pr.Name;
                product.Price = pr.Price;
                product.Qty = pr.Qty;
                product.Description = pr.Description;
                db.SaveChanges();
                TempData["msg"] = "Product successfully edited!";
                return RedirectToAction("Index");
            }
            else
            {
                return View(pr);
            }
        }
        public ActionResult Delete(int id)
        {
            var db = new DotNetEntities();
            var product = (from p in db.Products where p.Id == id select p).SingleOrDefault();
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
    }
}