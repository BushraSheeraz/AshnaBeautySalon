using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeautySalon.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "Your services page.";

            return View();
        }

        public ActionResult Work()
        {
            ViewBag.Message = "Your work page.";

            return View();
        }

        public ActionResult Signup()
        {
            ViewBag.Message = "user signup page";

            return View();
        }


        public ActionResult Login()
        {
            ViewBag.Message = "user login page";

            return View();
        }

    }
}