using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using rudemvc.Models;
using System.Security.Cryptography.X509Certificates;

namespace rudemvc.Controllers
{
    public class DeleteController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Crud = "EMP details";
            Class c = new Class();
            ModelState.Clear();
            return View(c.GetItemList());
            //return View();
        }

        [HttpGet]
        public ActionResult Create()
        { return View(); }
        [HttpPost]
        public ActionResult Create(Crud list)
        {
            if (ModelState.IsValid)
            {
                Class c = new Class();
                if (c.InsertList(list))
                {
                    ViewBag.Message = "succesfully";
                    ModelState.Clear();
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {

            Class c = new Class();
            return View(c.GetItemList().Find(Crud=>Crud.Id==id));

        }
        [HttpPost]
        public IActionResult Edit(int id, Crud list)
        {
            try
            {
                Class c = new Class();
                c.updatelist(list);
                return RedirectToAction ("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {

            Class c = new Class();
            return View(c.GetItemList().Find(m=>m.Id==id));

        }
        [HttpPost]
        public ActionResult Delete(int id,Crud imt)
        {
            try {
                Class c = new Class();
                if (c.DeleteList(imt))
                {

                    ViewBag.AlertMsg = "Item Deleted Successfully";
                }
                return RedirectToAction("Index");
            }
            catch { return View(); }
        }
        public ActionResult Details(int id)
        {
            Class c = new Class();
            return View(c.GetItemList().Find(m => m.Id == id));
        }
    }
}

