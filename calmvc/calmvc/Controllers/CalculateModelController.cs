using calmvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace calmvc.Controllers
{
    public class CalculateModelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CalculateModel cm)
        {
            int n1 = cm.num1;
            int n2 = cm.num2;
            int res = n1 + n2;
            ViewBag.result = res;
            return View();

        }
    }
}
