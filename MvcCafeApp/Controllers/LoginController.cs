using Restaurant_Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Restaurant_Project.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Tbl_Admin p)
        {
            DataContext db = new DataContext();
            var bilgi = db.Admins.FirstOrDefault(x => x.UserName == p.UserName && x.Password == p.Password);
            if (bilgi != null)
            {
                FormsAuthentication.SetAuthCookie(bilgi.UserName, false);
                Session["UserName"] = bilgi.UserName.ToString();
                return RedirectToAction("LoginEdit/1", "Giris");
            }
            else
            {
                ViewBag.ErrorMessage = "Incorrect username or password";

                return RedirectToAction("Index", "Login");
            }

        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}
