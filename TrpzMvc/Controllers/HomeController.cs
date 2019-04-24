using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrpzMvc.Models;

namespace TrpzMvc.Controllers
{
    public class HomeController : Controller
    {
        PageContext db = new PageContext();
        public ActionResult Index()
        {
            var page = db.Pages.Include("BackgroundImage").FirstOrDefault(p => p.Id == 1);
            //ViewBag.PageIndex = 0;
            ViewBag.Title = page.Title;
            ViewBag.Text = page.Text;
            ViewBag.ImagePath = page.BackgroundImage.Path;
            return View();
        }

        public ActionResult Info()
        {
            var page = db.Pages.Include("BackgroundImage").FirstOrDefault(p => p.Id == 2);
            ViewBag.Title = page.Title;
            ViewBag.Text = page.Text;
            //ViewBag.PageIndex = 1;
            ViewBag.ImagePath = page.BackgroundImage.Path;
            return View();
        }

        public ActionResult Contacts()
        {
            var page = db.Pages.Include("BackgroundImage").FirstOrDefault(p => p.Id == 3);
            ViewBag.Title = page.Title;
            ViewBag.Text = page.Text;
            ViewBag.ImagePath = page.BackgroundImage.Path;
            //ViewBag.PageIndex = 2;
            return View();
        }
    }
}