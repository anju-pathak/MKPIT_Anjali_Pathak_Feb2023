using Microsoft.AspNetCore.Mvc;
using radiomvc.Models;

namespace radiomvc.Controllers
{
    public class RegController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Reg r)
        {
            ViewBag.name = r.name;
            ViewBag.password=r.password;
            ViewBag.email=r.email;
            ViewBag.gender=r.gender;
            if(r.sub1==true)
            {
               r.res = "dotnet";
            }
            if (r.sub2==true)
            {
               r.res1= "java";
            }
            ViewBag.res = r.res;
            ViewBag.res1 = r.res1;
            return View();
        }
    }
}
