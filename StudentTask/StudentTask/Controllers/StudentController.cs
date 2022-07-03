using StudentTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentTask.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student S)
        {
            if (ModelState.IsValid)
            {
                TempData["msg"] = "Registration Successful";
                return RedirectToAction("Create");
            }
            else
            {
                return View(S);
            }
        }

    }
}