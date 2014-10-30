using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.Entity;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }
       [HttpPost]
[ValidateAntiForgeryToken]
        public ActionResult Login(WebApplication6.Models.user u)
{
    // this action is for handle post (login)
    if (ModelState.IsValid) // this is check validity
    {
        using (Model1 dc = new Model1())
        {
            var v = dc.users.Where(a => a.Username.Equals(u.Username) && a.Password.Equals(u.Password)).FirstOrDefault();
            if (v != null)
            {
                Session["LogedUserID"] = v.Id.ToString();
                Session["LogedUserFullname"] = v.FirstName.ToString();
                return RedirectToAction("AfterLogin");
            }
        }
    }
    return View(u);
}
       public ActionResult AfterLogin()
       {
           if (Session["LogedUserID"] != null)
           {
               return View();
           }
           else
           {
               return RedirectToAction("Index");
           }
       }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description pages.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}