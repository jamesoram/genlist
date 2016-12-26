using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GenList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ProductName = "GenList";
            ViewBag.Headline = "Get Started.";
            ViewBag.Message = "You are closer to launching.";
            ViewBag.Copy = "Genlist is the easiest way to start collecting email addresses of people who are interested in your product launch.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
