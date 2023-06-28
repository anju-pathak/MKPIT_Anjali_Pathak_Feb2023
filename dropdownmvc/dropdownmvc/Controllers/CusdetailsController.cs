using dropdownmvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace dropdownmvc.Controllers
{
    public class CusdetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Customer c)
        {
            ViewBag.orderno = c.orderno;
            ViewBag.customernam = c.customername;
            ViewBag.price = c.price;
            ViewBag.qty = c.qty;
            int total = c.price * c.qty;
            var SelectedValue = c.getprd;
            ViewBag.prd = SelectedValue.ToString();   

            return View();
        }
    }
}
