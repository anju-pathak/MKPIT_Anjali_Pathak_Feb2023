using Microsoft.AspNetCore.Mvc;

namespace mvc1.Controllers
{
    public class StudentController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
