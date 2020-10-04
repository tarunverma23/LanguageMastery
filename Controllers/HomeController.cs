using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LanguageMastery.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Manage_Course()
        {
            ViewBag.Message = "This is Manage Course page";

            return View();
        }

        [Authorize]
        public ActionResult Rate_Course()
        {
            ViewBag.Message = "This is Rate Course page";

            return View();
        }
    }
}