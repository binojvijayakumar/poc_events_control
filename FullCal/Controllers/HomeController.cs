using FullCal.Data_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FullCal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dynamic()
        {
            return View();
        }

        public JsonResult GetEvents()
        {
            appdataEntities entity = new appdataEntities();
            return Json(entity.Events, JsonRequestBehavior.AllowGet);

        }
    }
}