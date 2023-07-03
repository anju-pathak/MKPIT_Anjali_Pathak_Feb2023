using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using validationsummray.Models;

namespace validationsummray.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Class c)
        {
            ViewBag.name = c.name;
            ViewBag.phone=c.phone;
            ViewBag.age=c.age;
            ViewBag.HireDate = c.HireDate;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}