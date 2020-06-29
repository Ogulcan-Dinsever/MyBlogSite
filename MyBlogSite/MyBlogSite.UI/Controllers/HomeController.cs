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
        public ActionResult SignUp(User user)
        {
            return View();
        }

        public ActionResult SignIn()
        {
            return View();
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