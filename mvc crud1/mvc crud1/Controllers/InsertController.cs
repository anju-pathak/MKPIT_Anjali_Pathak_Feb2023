using mvc_crud1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_crud1.Controllers
{
    public class InsertController : Controller
    {
        // GET: Insert
        public ActionResult Index()
        {
            ViewBag.ItemList = "Computer Shop Item List Page";
            ItemDBHandler IHandler = new ItemDBHandler();
            ModelState.Clear();
            return View(IHandler.GetItemList());
         
        }
        [HttpGet]

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Insert ilist)
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
        [HttpGet]
        public ActionResult Edit(int id)
        {
            ItemDBHandler item = new ItemDBHandler();
            return View(item.GetItemList().Find(m => m.ID == id));
        }
        [HttpPost]

        public ActionResult Edit(int id, Insert ilist)
        {

            try
            {
                ItemDBHandler item = new ItemDBHandler();
                item.UpadteItem(ilist);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            ItemDBHandler item = new ItemDBHandler();
            return View(item.GetItemList().Find(m => m.ID == id));
        }
        [HttpPost]
        public ActionResult Delete(Insert itm, int id)
        {
            try
            {
                ItemDBHandler item = new ItemDBHandler();
                item.DeleteItem(itm);
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }
        public ActionResult Details(int id)
        {
            ItemDBHandler item = new ItemDBHandler();
            return View(item.GetItemList().Find(m =>m.ID == id));
        }


    }
}

   