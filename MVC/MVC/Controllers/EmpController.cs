using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
