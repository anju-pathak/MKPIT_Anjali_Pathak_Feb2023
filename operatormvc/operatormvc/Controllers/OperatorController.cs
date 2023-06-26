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
            int n1 = o.n1;
            int n2 = o.n2;
            int n3 = o.n3;
            int res;
            if (o.n3== '+')
            {
                res = n1 + n2;
            }
            else if (o.n3 == '-')
            {
                res = n1 - n2;
            }
            else if(o.n3=='*')
            {
                res = n1 * n2;
            }
            else if (o.n3 == '%')
            {
                res = n1 / n2;
            }
            else
            {
                res = 1;
            }
            
            @ViewBag.result = o.res;
            return View();
        }
    }
}

