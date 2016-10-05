using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcPizzaYap.Models;

namespace MvcPizzaYap.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        static SiparisEntities db;
        static HomeController()
        {
            db = new SiparisEntities();
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UyeKayit()
        {
            Uye uye = new Uye();
            return View(uye);
        }
        [HttpPost]
        public JsonResult UyeKayit(Uye uye)
        {

            db.Uye.Add(uye);
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        public ActionResult UyeGiris()
        {
            return View();
        }

    }
}
