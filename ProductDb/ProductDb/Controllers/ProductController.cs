using ProductDb.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductDb.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var db = new DotNetEntities();
            var products = db.Products.ToList();
            return View(products);
        }
        [HttpPost]
        public ActionResult Index(Product pr)
        {
            var db = new DotNetEntities();
            if(Request["good"]!=null)
            {
                var products = (from p in db.Products where p.Condition == "good" select p).ToList();
                return View(products);
            }
            else if (Request["medium"] != null)
            {
                var products = (from p in db.Products where p.Condition == "medium" select p).ToList();
                return View(products);
            }
            else if (Request["bad"] != null)
            {
                var products = (from p in db.Products where p.Condition == "bad" select p).ToList();
                return View(products);
            }
            var prdcts = db.Products.ToList();
            return View(prdcts);
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
            if (ModelState.IsValid)
            {
                var db = new DotNetEntities();
                var product = (from p in db.Products where p.Id == pr.Id select p).SingleOrDefault();
                product.Name = pr.Name;
                product.Price = pr.Price;
                product.Qty = pr.Qty;
                product.Condition = pr.Condition;
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
        [HttpPost]
        public ActionResult Create(Product pr)
        {
            if (ModelState.IsValid)
            {
                var db = new DotNetEntities();
                db.Products.Add(pr);
                db.SaveChanges();
                TempData["msg"] = "Product successfully added!";
                return RedirectToAction("Index");
            }
            else
            {
                return View(pr);
            }
        }
    }
}