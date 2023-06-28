using checkboxmvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace checkboxmvc.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Company c)
        {
            ViewBag.Name=c.Name;
            ViewBag.sal = c.sal;
            
            if(c.hr==true)
            {
                c.res = c.sal * 0.25;
                ViewBag.res = c.res;
            }
            if(c.da==true)
            {
                c.res1 = c.sal * 0.45;
                ViewBag.res1 = c.res1;
            }
            if(c.hr==true)
            {
                c.res2 = c.sal * 0.15;
                ViewBag.res2= c.res2;
            }
            ViewBag.res3 = c.res + c.res1 + c.res2;
            return View();
        }
    }
}
