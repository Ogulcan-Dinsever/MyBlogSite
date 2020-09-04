using MyBlogSite.BusinessLayer;
using MyBlogSite.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlogSite.UI.Controllers
{
    public class HomeController : Controller
    {
        UserManager userManager = new UserManager();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(User user, string re_pass)
        {
            if (user != null)
            {
                if (user.Password == re_pass)
                {
                    userManager.AddUser(user);
                    return RedirectToAction("SignIn");
                }
            }
            return View();
        }

        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(User loginUser)
        {
            User user = userManager.GetUserByMail(loginUser.eMail);

            if (user != null && user.Password == loginUser.Password)
            {
                Session["Login"] = user;
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult SignOut()
        {
            Session.Clear();
            return RedirectToAction("Index");
        }

        public ActionResult Profile()
        {
            return View();
        }

        public ActionResult AddEntry()
        {
            return View();
        }

    }
}