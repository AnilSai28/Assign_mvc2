using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_day1.Controllers
{
    public class HomeController : Controller
    {
      public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(string Loginid, string Password)
        {
            if (Loginid == "user1" && Password == "pass@123")
            {
                Session["loginid"] = Loginid;
                return RedirectToAction("index", "home"); //get
            }
            else
            {
                ViewBag.msg = "invalid id or password";
                return View();
            }
        }
        public ActionResult index()
        {
            return View();
        }
        public ActionResult NewUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewUser
            (string emailid,string password,string name,string city)
        {
            return View("view_customercreated");
        }
        public ActionResult logout()
        {
            Session.Clear();
            return RedirectToAction("login", "home");
        }

    }
}