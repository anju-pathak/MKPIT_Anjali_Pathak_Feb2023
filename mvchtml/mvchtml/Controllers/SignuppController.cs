using Microsoft.AspNetCore.Mvc;
using mvchtml.Models;

namespace mvchtml.Controllers
{
    public class SignuppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(SignupModelcs s)
        {
            ViewBag.name = s.name;
            ViewBag.password = s.password;
            return View();
        }
    }
}
