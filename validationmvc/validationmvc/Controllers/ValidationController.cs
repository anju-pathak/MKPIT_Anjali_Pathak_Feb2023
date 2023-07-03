using Microsoft.AspNetCore.Mvc;
using validationmsg2.mvc.Models;

namespace validationmsg2.mvc.Controllers
{
    public class ValidationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(validation v)
        {
            if(ModelState.IsValid) 
            {
                ViewBag.name = v.name;
                ViewBag.age = v.age;
                ViewBag.email = v.email;
               
                ViewBag.phone = v.phone;
                return View("Index");

            }
            else
            {
                ViewBag.name = "no data";
                ViewBag.age = "no data";
                ViewBag.email = "no data";
              
                ViewBag.phone = "no data";

                return View("Index");
            }

           
        }
    }
}
