using Microsoft.AspNetCore.Mvc;
using operatormvc.Models;

namespace operatormvc.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Emp o)
        {
            string n1 = o.name;
            int n2 = o.sal;
            string n3 = o.des;
            int res;
            string des="";
            if (des == "mangaer")
            {
                res = 10000;
            }
            else if (des == "clerk")
            {
                res = 5000;
            }
            else if (des == "peon")
            {
                res = 1000;
            }
            else
            {
                res = 00;
            }

            @ViewBag.result = res;
            return View();
        }
    }
}
