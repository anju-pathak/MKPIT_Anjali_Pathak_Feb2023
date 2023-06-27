using checkboxmvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace checkboxmvc.Controllers
{
    public class SumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Sum s)
        {
            ViewBag.n1 = s.n1;
            ViewBag.n2 = s.n2;
            //ViewBag.num3 = s.add;
            //ViewBag.num4 = s.sub;
            //ViewBag.num5 = s.mul;
            //ViewBag.num6 = s.res1;
            //ViewBag.num7 = s.res2;
            //ViewBag.num8 = s.res3;
            //int res;
            if (s.add==true)
            {
                s.res1 = s.n1 + s.n2;
                ViewBag.res1 = s.res1;
            }
           if (s.sub == true)
            {
                s.res2 = s.n1 - s.n2;
                ViewBag.res2 = s.res2;
            }
             if (s.mul == true)
            {
                s.res3 = s.n1 * s.n2;
                ViewBag.res3 = s.res3;
            }
            return View();
        }
    }
}
