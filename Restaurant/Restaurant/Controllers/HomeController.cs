using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Restaurant.Models;

namespace Restaurant.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Menu()
        {
            ViewBag.Message = "MEnu";

            return View();
        }

        public ActionResult GetItems()
        { 
            List<Dish> dishes = new List<Dish>();
            
            dishes.Add(new Dish("fish","shark",100));
            dishes.Add(new Dish("meat","beaf",200));
            
            return Json(dishes, JsonRequestBehavior.AllowGet);
        }
    }
}