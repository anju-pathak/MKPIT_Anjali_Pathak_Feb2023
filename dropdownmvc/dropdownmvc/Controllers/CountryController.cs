using dropdownmvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace dropdownmvc.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Country c)
        {
            var Selectedvalue= c.selectcountry;
            ViewBag.countryy = Selectedvalue.ToString();
            return View();
        }
    }
}
