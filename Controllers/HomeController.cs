using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieReviews.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Learn about us and how we came to be.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Please contact us whenever needed.";

            return View();
        }
    }
}