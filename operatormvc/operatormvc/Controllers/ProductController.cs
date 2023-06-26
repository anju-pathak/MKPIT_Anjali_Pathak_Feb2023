using Microsoft.AspNetCore.Mvc;
using operatormvc.Models;
using System.Xml;

namespace operatormvc.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Product p)
        {
            ViewBag.name = p.name;
            int pr = p.price;
            int qt=p.qty;
            int res = pr * qt;
            ViewBag.result = res;
            return View();
        }
    }
}
