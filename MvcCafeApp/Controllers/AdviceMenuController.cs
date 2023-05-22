using Restaurant_Project.Models.Entity;
using Restaurant_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_Project.Controllers
{
    public class AdviceMenuController : Controller
    {
        // GET: OnerilenMenu
        
        Our_AdviceRepo repo = new Our_AdviceRepo();
        public ActionResult Index()
        {
            var advices = repo.List();
            return View(advices);
        }
        [HttpGet]
        public ActionResult AdviceEdit(int id)
        {
            var adviceEdit = repo.Find(x => x.AdviceId == id);
            return View();
        }
        [HttpPost]
        public ActionResult AdviceEdit(Tbl_Our_Advice p)
        {
            var t = repo.Find(x => x.AdviceId == p.AdviceId);
            t.Title = p.Title;
            t.Description1 = p.Description1;
            t.Description2 = p.Description2;
            t.Image_Address = p.Image_Address;

            repo.TUpdate(t);
            return RedirectToAction("Index");
        }


    }
}