using dropdownmvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace dropdownmvc.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Account ac)
        {
            ViewBag.accountno = ac.accountno;
            ViewBag.amount = ac.amount;
            int res;
            var type = ac.getamount;
            string t1=type.ToString();
            int bal = 1000;
            if(t1=="deposite")
            {
                bal = ac.amount + 1000;
            }
            if (t1 == "withdrawl")
            {
                bal = ac.amount - 1000;
            }
            ViewBag.amountno=ac.accountno   
                ; ViewBag.amount = ac.amount;
             ViewBag.bal = bal;
            return View();
        }
    }
}
