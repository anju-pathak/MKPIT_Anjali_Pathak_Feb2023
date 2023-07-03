using Microsoft.AspNetCore.Mvc;
using validationsummray.Models;

namespace validationsummray.Controllers
{
    public class GreaterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Greater g)
        {
            ViewBag.Num1 = g.num1;
            ViewBag.Num2 = g.num2;
            string res;
            if (g.num1 > g.num2)
            {
                res =  "number1 is greater than number2 ="+g.num1+">"+g.num2;
            }
            else
            {

                res= "number2 is greater than number1 ="+g.num2+">"+g.num1;

            }
           ViewBag.num2 = res;
            return View();
        }
    }
}
