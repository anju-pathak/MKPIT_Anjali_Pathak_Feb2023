using checkboxmvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Schema;

namespace checkboxmvc.Controllers
{
    public class AttandanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Attandance a)
        {
            ViewBag.name=a.name;
            ViewBag.date=a.date;
            ViewBag.anjali = a.anjali;
           ViewBag.monali=a.monali;
            ViewBag.tanu=a.tanu;
            
            if (a.anjali == true)
            {
                a.res = "Present";
                ViewBag.res = a.res;
            }
            if (a.monali == true)
            {
                a.res = "Present";
                ViewBag.res = a.res;
            }
            if (a.tanu == true)
            {
                a.res = "Present";
                ViewBag.res = a.res;
            }
            if (a.karishma == true)
            {
                a.res = "Present";
                ViewBag.res = a.res;
            }
            if (a.yasmin == true)
            {
                a.res = "Present";
                ViewBag.res = a.res;
            }
            return View();
        }
    }
}
