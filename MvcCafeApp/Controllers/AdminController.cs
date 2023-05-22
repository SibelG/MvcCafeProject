using Restaurant_Project.Models.Entity;
using Restaurant_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_Project.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        GenericRepo<Tbl_Admin> repo = new GenericRepo<Tbl_Admin>();
        public ActionResult Index()
        {
            var liste = repo.List();
            return View(liste);
        }
        [HttpGet]
        public ActionResult AdminAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminAdd(Tbl_Admin p)
        {
            repo.Tadd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AdminGet(int id)
        {
            Tbl_Admin t = repo.Find(x => x.AdminId == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult AdminGet(Tbl_Admin p)
        {
            Tbl_Admin t = repo.Find(x => x.AdminId == p.AdminId);
            t.Password = p.Password;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}