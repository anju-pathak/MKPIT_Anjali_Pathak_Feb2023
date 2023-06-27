using Microsoft.AspNetCore.Mvc;
using radiomvc.Models;

namespace radiomvc.Controllers
{
    public class BankController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Bank b)
        {
            ViewBag. name = b.name;
            ViewBag.amount=b.amount;
            ViewBag.acctype=b.acctype;
            ViewBag.amount = 5000;
            
            if (b.acctype=="deposite")
            {
                b.res = ViewBag.amount + 1000;
            }
            else if (b.acctype== "withdrwal")
            {
                b.res = ViewBag.amount - 5000;

            }
            ViewBag.res=b.res;
           
            return View();
        }
    }
}
