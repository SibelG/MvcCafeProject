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
        
        OurAdviceRepo repo = new OurAdviceRepo();
        public ActionResult Index()
        {
            var advices = repo.List();
            return View(advices);
        }
        [HttpGet]
        public ActionResult AdviceEdit(int id)
        {
            var adviceEdit = repo.Find(x => x.AdviceId == id);
            return View(adviceEdit);
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

        // GET: Tbl_Our_Advice/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tbl_Our_Advice/Create		AdviceId	0	int

        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AdviceId,Title,Description1,Description2,Image_Address")] Tbl_Our_Advice tbl_Our_Advice)
        {
            if (ModelState.IsValid)
            {
                repo.Tadd(tbl_Our_Advice);
                return RedirectToAction("Index");
            }

            return View(tbl_Our_Advice);
        }

    }
}