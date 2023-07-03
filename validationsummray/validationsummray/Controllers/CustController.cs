using Microsoft.AspNetCore.Mvc;
using validationsummray.Models;

namespace validationsummray.Controllers
{
    public class CustController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Cust c)
        {
            ViewBag.orderno = c.orderno;
            ViewBag.custname = c.custname;
            ViewBag.productname = c.productname;
            ViewBag.qty = c.qty;
            ViewBag.prdprice = c.prdprice;
            int res =c.qty *c.prdprice;
            ViewBag.res = res;
            return View();
        }
    }
}
