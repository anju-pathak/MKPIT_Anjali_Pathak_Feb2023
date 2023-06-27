using Microsoft.AspNetCore.Mvc;
using operatormvc.Models;
using System.Reflection.Metadata;

namespace operatormvc.Controllers
{
    public class OperatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Operator o)
        {
            int num1 = o.n1;
            int num2 = o.n2;
            char n3;
            int res;
            if (o.n3== '+')
            {
                res = num1 + num2;
            }
            else if (o.n3 == '-')
            {
                res = num1 - num2;
            }
            else if(o.n3=='*')
            {
                res = num1 * num2;
            }
            else if (o.n3 == '%')
            {
                res = num1 / num2;
            }
            else
            {
                res = 5;
            }
            
            @ViewBag.result = o.res;
            return View();
        }
    }
}

