using dropdownmvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace dropdownmvc.Controllers
{
    public class TeaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Tea t)
        {
            var selectedValue = t.gettea;

            ViewBag.teatype = selectedValue.ToString();
            return View();
        }
    }
}
