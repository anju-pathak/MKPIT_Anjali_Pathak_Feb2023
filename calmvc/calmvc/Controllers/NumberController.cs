using calmvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace calmvc.Controllers
{
    public class NumberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Number n)
        {
            int n1 = n.num;
            string res;

                if (n1 % 2 == 0)
                {
                    res = "even";

                }
                else
                {
                    res = "odd";
                }
                return View();
            ViewBag.result=res;
            }
        }
    }

