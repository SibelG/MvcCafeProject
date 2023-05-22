using Restaurant_Project.Models.Entity;
using Restaurant_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_Project.Controllers
{
    public class BookingController : Controller
    {
        // GET: Rezervasyon
        BookingRepo repo= new BookingRepo();
        public ActionResult Index()
        {
            var rezervasyon = repo.List();
            return View(rezervasyon);
        }
        public ActionResult BookingDelete(int id) 
        {
            Tbl_Booking rezervationDelete=repo.Find(x=>x.BookingId==id);
            repo.TDelete(rezervationDelete);
            return RedirectToAction("Index");
        }
    }
}