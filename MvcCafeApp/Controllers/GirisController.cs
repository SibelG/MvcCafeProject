using Restaurant_Project.Models.Entity;
using Restaurant_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_Project.Controllers
{
    public class GirisController : Controller
    {
        // GET: Giris
        LoginRepo repo = new LoginRepo();

        [HttpGet]
        public ActionResult LoginEdit(int id)
        {
            Tbl_Login t = repo.Find(x => x.LoginId == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult LoginEdit(Tbl_Login p)
        {
            Tbl_Login t = repo.Find(x => x.LoginId == p.LoginId);
            t.Title = p.Title;
            t.Sub_Information = p.Sub_Information;
            repo.TUpdate(t);
            return View(t);
        }
    }
}