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
        public IActionResult Index(Emp e)
        {
            string n1 = e.name;
            int n2 = e.sal;
            string n3 = e.des;
            int res;
            //string des="";
            if (e.des == "managar")
            {
                res = e.sal+10000;
            }
            else if (e.des == "clerk")
            {
                res = 5000;
            }
            else if (e.des == "peon")
            {
                res = 1000;
            }
            else
            {
                res = 001;
            }

            @ViewBag.result = res;
            return View();
        }
    }
}
