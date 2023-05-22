using Restaurant_Project.Models.Entity;
using Restaurant_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_Project.Controllers
{
    public class WhySelectController : Controller
    {
        // GET: NedenBiz

        WhySelectRepo repo = new WhySelectRepo();
        public ActionResult Index()
        {
            var neden = repo.List();
            return View(neden);
        }
        [HttpGet]
        public ActionResult WhySelectEdit(int id)
        {
            var whyEdit = repo.Find(x => x.WhySelectId == id);
            return View(whyEdit);
        }
        [HttpPost]
        public ActionResult WhySelectEdit(Tbl_Why_Select p)
        {
            var t = repo.Find(x => x.WhySelectId == p.WhySelectId);
            t.Title = p.Title;
            t.Description = p.Description;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}