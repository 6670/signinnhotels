using SignInnHotel.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignInnHotel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [WhitespaceFilter]
        public ActionResult Index()
        {
            return View();
        }
        [WhitespaceFilter]
        public ActionResult AboutUs()
        {
            return View();
        }
        [WhitespaceFilter]
        public ActionResult ContactUs()
        {
            return View();
        }
        [WhitespaceFilter]
        public ActionResult RoomeDetails()
        {
            return View();
        }
        [WhitespaceFilter]
        public ActionResult Gallery()
        {
            return View();
        }
    }
}