using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.FileIO;
using signupassigmvc.Models;

namespace signupassigmvc.Controllers
{
    public class DetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Details d)
        {
            ViewBag.name = d.name;
            ViewBag.male=d.male;    
            ViewBag.female=d.female;
            ViewBag.course=d.course;
            string res;
            var selectedvalue = d.getcity;
            ViewBag.city = selectedvalue.ToString();
            if (d.male == true)
            {
                d.res = "male";
            }
            if (d.female == true)
            {
                d.res = "female";
            }

            ViewBag.res=d.res;
            return View();
        }
    }
}
