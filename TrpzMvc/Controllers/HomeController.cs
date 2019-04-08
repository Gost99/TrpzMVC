using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrpzMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.PageIndex = 0;
            return View();
        }

        public ActionResult Info()
        {
            ViewBag.PageIndex = 1;
            return View();
        }

        public ActionResult Contacts()
        {
            ViewBag.PageIndex = 2;
            return View();
        }
    }
}