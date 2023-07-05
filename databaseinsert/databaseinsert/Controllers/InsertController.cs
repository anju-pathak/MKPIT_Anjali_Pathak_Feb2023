using databaseinsert.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace databaseinsert.Controllers
{
    public class InsertController : Controller
    {
        public ActionResult Index1()
        {
            ViewBag.ItemList = "Computer Shop Item List Page";
            ItemDBHandler IHandler = new ItemDBHandler();
            ModelState.Clear();
            return View(IHandler.GetItemList());
        }
    
        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Insert ilist)
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
        public IActionResult Edit(int id)
        {
            ItemDBHandler item=new ItemDBHandler();
            return View(item.GetItemList().Find(m=>m.ID==id));
        }
        [HttpPost]
      
        public IActionResult Edit(int id,Insert ilist)
        {

            try
            {
                ItemDBHandler item = new ItemDBHandler();
                item.UpadteItem(ilist);
                return RedirectToAction("Index1");
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
            return View(item.GetItemList().Find(m=>m.ID==id)); 
        }
        [HttpPost]
        public ActionResult Delete(Insert itm,int id)
        {
            try
            {
                ItemDBHandler item = new ItemDBHandler();
               item.DeleteItem(itm);
                return RedirectToAction("Index1");

            }
            catch 
            {
                return View();
            }
        }
        public ActionResult Details(int id)
        {
            ItemDBHandler item = new ItemDBHandler();
            return View(item.GetItemList().Find(m => m.ID == id));
        }
        
            
        }
    }


        
    

