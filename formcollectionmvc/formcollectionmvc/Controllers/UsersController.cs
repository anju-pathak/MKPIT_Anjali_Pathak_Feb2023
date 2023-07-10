using formcollectionmvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace formcollectionmvc.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult submit(FormCollection fc)
        {
            ViewBag.Id = fc["Id"];
            ViewBag.Name = fc["Name"];
            return View("Index");
        }
    }
}