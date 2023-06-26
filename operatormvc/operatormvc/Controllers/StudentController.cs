using Microsoft.AspNetCore.Mvc;
using operatormvc.Models;

namespace operatormvc.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Student p)
        {
            int num1 = p.n1;
           int num2 = p.n2;
            int num3 = p.n3;
            int num4 = p.n4;
            int num5 = p.n5;
            int res1=num1+ num2+num3+num4+num5;
            string grade;
           float per = (res1/500f)*100 ;
            if(per>=75)
            {
                grade = "pass";
            }
            else if(per>=60)
            {
                grade = "fail";

            }
            else
            {
                 grade="c";
            }
            ViewBag.result = res1;
            ViewBag.per= per;
            ViewBag.grade = grade;  
            return View();
        }
    }
}
