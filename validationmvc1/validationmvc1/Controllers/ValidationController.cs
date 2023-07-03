using Microsoft.AspNetCore.Mvc;
using validationmvc1.Models;

namespace validationmvc1.Controllers
{
    public class ValidationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Validation v)
        {
            if(string.IsNullOrEmpty(v.name))
            {
                ModelState.AddModelError("Name","please enter valide name");
            }
            if(v.age== 0 || v.age==120)
            {
                ModelState.AddModelError("Age", "enter valid AGE");
            }
            if(ModelState.IsValid)
            {
                ViewBag.name = v.name;
                ViewBag.age = v.age;
               
                return View("Index");
              
            }
            else
            {
                ViewBag.name = "no data";
                ViewBag.age = "no data";

                return View("Index");


            }

        }
    }
}
