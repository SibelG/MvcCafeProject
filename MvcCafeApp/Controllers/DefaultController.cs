using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Restaurant_Project.Models.Entity;

namespace Restaurant_Project.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DataContext db = new DataContext();
        public ActionResult Index()
        {
            var values= db.Logins.ToList();
            return View(values);
        }
        public PartialViewResult About()
        {
            var about=db.Abouts.ToList();
            return PartialView(about);
        }
        public PartialViewResult WhySelect()
        {
            var whySelect=db.Why_Selects.ToList();
            return PartialView(whySelect);
        }
        public PartialViewResult Menu()
        {
            var menu=db.Menu_Foods.ToList();
            return PartialView(menu);
        }
        public PartialViewResult Advices()
        {
            var advice=db.Our_Advices.ToList();
            return PartialView(advice);
        }
        public PartialViewResult Images()
        {
            var resim = db.Images.ToList();
            return PartialView(resim);
        }
        [HttpGet]
        public PartialViewResult Booking()
        {
    
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Booking(Tbl_Booking t)
        {
            db.Bookings.Add(t);
            db.SaveChanges();
            return PartialView();
        }
       
    }
}