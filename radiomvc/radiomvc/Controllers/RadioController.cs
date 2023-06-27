using Microsoft.AspNetCore.Mvc;
using radiomvc.Models;

namespace radiomvc.Controllers
{
    public class RadioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Radio r)
        {
            ViewBag.n1=r.n1;
            ViewBag.n2=r.n2;

            if(r.caltype=="add")
            {
                r.res=r.n1 + r.n2;

            }
            else if(r.caltype=="sub")
            {
                r.res = r.n1 - r.n2;
            }
            else if (r.caltype == "mul")
            {
                r.res = r.n1 * r.n2;
            }
            ViewBag.res=r.res;
            return View();
        }
    }
}
