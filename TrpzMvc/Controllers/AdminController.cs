using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrpzMvc.Models;



//TODO: should change db page.backgr.path like '../img/bg.jpg'
namespace TrpzMvc.Controllers
{
    public class AdminController : Controller
    {
        PageContext db = new PageContext();
        public ActionResult Pages()
        {
            var pages = db.Pages.Include("BackgroundImage");
            return View(pages);
        }


       [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                ViewBag.Images = db.Images.ToList();
                var page = db.Pages.Include("BackgroundImage").FirstOrDefault(p => p.Id == id); 
                if (page != null)
                    return View(page);
            }
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult Edit(Page page)
        {
            page.BackgroundImageId = db.Images.FirstOrDefault(p => p.Path == page.BackgroundImage.Path).Id;
            page.BackgroundImage = null;

            

            db.Entry(page).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Pages");
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            db.Dispose();
        }
    }
}
