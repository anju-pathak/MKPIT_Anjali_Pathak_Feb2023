using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
