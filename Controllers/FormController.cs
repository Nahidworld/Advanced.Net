using Form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Form.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        //[HttpGet]
        public ActionResult Index()
        {
            return View(new Student());
        }

        [HttpPost]
        public ActionResult Index(Student s) 
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}