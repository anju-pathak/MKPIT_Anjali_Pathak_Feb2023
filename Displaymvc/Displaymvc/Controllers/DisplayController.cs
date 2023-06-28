using Displaymvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Displaymvc.Controllers
{
    public class DisplayController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(IFormCollection fm,Display d)
        {
            if(ModelState.IsValid)
            {
                d.name = fm["name"];
            }
            return View(d);
        }
    }
}
