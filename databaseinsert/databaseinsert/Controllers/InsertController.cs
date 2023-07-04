using databaseinsert.Models;
using Microsoft.AspNetCore.Mvc;

namespace databaseinsert.Controllers
{
    public class InsertController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
      
        [HttpPost]
        public IActionResult Index(Insert ilist)
        {
            if (ModelState.IsValid)
            {
                ItemDBHandler db = new ItemDBHandler();
                if (db.InsertItem(ilist))
                {
                    ViewBag.message = "item saved successfully";
                    ModelState.Clear();
                }

            }
            return View();
        }
    }
}
}
