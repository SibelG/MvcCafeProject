using Restaurant_Project.Models.Entity;
using Restaurant_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_Project.Controllers
{
    public class AboutController : Controller
    {
        // GET: Hakkimizda
        GenericRepo<Tbl_About> repo=new GenericRepo<Tbl_About>();
       

        [HttpGet]
        public ActionResult About(int id)
        {
            Tbl_About t = repo.Find(x => x.AboutId == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult About(Tbl_About p)
        {
            Tbl_About t = repo.Find(x => x.AboutId == p.AboutId);
            t.Title = p.Title;
            t.Description = p.Description;
            repo.TUpdate(t);
            return RedirectToAction("Index","Default");
        }
    }
}
