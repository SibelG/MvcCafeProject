using Restaurant_Project.Models.Entity;
using Restaurant_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_Project.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        MenuRepo repo= new MenuRepo();
        public ActionResult Index()
        {
            var value=repo.List();
            return View(value);
        }
        [HttpGet]
        public ActionResult MenuAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MenuAdd(Tbl_Menu_Foods p) 
        {
            repo.Tadd(p);
            return RedirectToAction("Index");
        }
        public ActionResult MenuDelete(int id)
        {
            var menuDelete=repo.Find(x=>x.MenuId==id);
            repo.TDelete(menuDelete);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult MenuEdit(int id)
        {
            var menuguncelle = repo.Find(x => x.MenuId == id);
            return View();
        }
        [HttpPost]
        public ActionResult MenuEdit(Tbl_Menu_Foods p) 
        { 
            var t=repo.Find(x=>x.MenuId==p.MenuId);
            t.Title = p.Title;
            t.Description=p.Description;
            t.Price = p.Price;
            t.ImageUrl=p.ImageUrl;

            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
      

        public ActionResult IndexFilter(string filtre)
        {
            DataContext db = new DataContext();
            List<Tbl_Menu_Foods> menuItems;

           
            if (filtre == "Desert")
            {
                menuItems = db.Menu_Foods.Where(x => x.Category.CategoryName == "Desert").ToList();
            }
            else if (filtre == "Drink")
            {
                menuItems = db.Menu_Foods.Where(x => x.Category.CategoryName == "Drink").ToList();
            }
            else if (filtre == "ContentMain")
            {
                menuItems = db.Menu_Foods.Where(x => x.Category.CategoryName == "ContentMain").ToList();
            }
            else if (filtre == "Salad")
            {
                menuItems = db.Menu_Foods.Where(x => x.Category.CategoryName == "Salad").ToList();
            }
            else
            {
                menuItems = db.Menu_Foods.ToList(); // Tüm kayıtları getir

            }

            return View("IndexFilter", menuItems);
        }


    }
}

