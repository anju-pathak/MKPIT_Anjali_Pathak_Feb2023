using checkboxmvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace checkboxmvc.Controllers
{
    public class TeaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Tea t)
        {
            ViewBag.Tea = t.tea;
            ViewBag.coffe=t.coffe;
            ViewBag.chai=t.chai;
            if(t.tea==true)
            {
                ViewBag.tea = "you selected tea";
            }
            if (t.coffe == true)
            {
                ViewBag.coffe = "you selected coffe";
            }
            if (t.chai == true)
            {
                ViewBag.chai = "you selected chai";
            }
            return View();
        }
    }
}
