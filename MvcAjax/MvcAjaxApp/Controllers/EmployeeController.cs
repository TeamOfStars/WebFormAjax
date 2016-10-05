using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcAjaxApp.Models;

namespace MvcAjaxApp.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult ReturnList()
        { 
            NORTHWNDContext db=new NORTHWNDContext();

            //var emplist = db.Employees.ToList();
            var emplist2 = (from t in db.Employees select new { t.FirstName, t.LastName }).ToList();


            return Json(emplist2, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult ReturnEmploye(int Id)
        {
            NORTHWNDContext db = new NORTHWNDContext();
            var emplist2 = (from t in db.Employees  where t.EmployeeID==Id select new { t.FirstName, t.LastName,t.Title }).FirstOrDefault();
            

            return Json(emplist2, JsonRequestBehavior.AllowGet);
        }

    }
}
