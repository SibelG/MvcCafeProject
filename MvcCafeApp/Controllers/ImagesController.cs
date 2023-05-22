using Restaurant_Project.Models.Entity;
using Restaurant_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_Project.Controllers
{
    public class ImagesController : Controller
    {
        // GET: Resim
        ImagesRepo repo = new ImagesRepo();
        public ActionResult Index()
        {
            var deger = repo.List();
            return View(deger);
        }
        [HttpGet]
        public ActionResult ImageAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ImageAdd(Tbl_Images p)
        {
            repo.Tadd(p);
            return RedirectToAction("Index");
        }
        public ActionResult ImageDelete(int id)
        {
            var imageDelete = repo.Find(x => x.ImageId == id);
            repo.TDelete(imageDelete);
            return RedirectToAction("Index");
        }
      

    }
}