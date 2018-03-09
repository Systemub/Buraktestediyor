using Buraktestediyor.Models.ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace Buraktestediyor.Controllers
{
    

    public class testController : Controller
    {
        ogrenciEntities db = new ogrenciEntities();

        public ActionResult test()
        {
            var model = db.ogrenci.ToList();
                     
            return View(model);
        }

        [HttpGet]
        public ActionResult ekle() {

            return View(); 
        }

        [HttpPost]
        public ActionResult ekle(ogrenci ogrenci) {

            var degisken = db.ogrenci.Find(ogrenci);
            db.ogrenci.Add(ogrenci);
            db.SaveChanges();
            return RedirectToAction("Index", "ogrenci");
        }
    }
}