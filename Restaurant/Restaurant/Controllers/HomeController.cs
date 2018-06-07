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
            return View();
        }

        public ActionResult GetItems(int? id)
        { 
            List<Dish> dishes = new List<Dish>();

            switch (id)
            {
                case 0:
                    dishes.Add(new Dish("0fish", "shark", 100));
                    dishes.Add(new Dish("0meat", "beaf", 200));
                    break;
                case 1:
                    dishes.Add(new Dish("1fish", "shark", 100));
                    dishes.Add(new Dish("1meat", "beaf", 200));
                    break;
                default:
                    dishes.Add(new Dish("fish", "shark", 100));
                    dishes.Add(new Dish("meat", "beaf", 200));
                    break;
            }
                    return Json(dishes, JsonRequestBehavior.AllowGet);
        }
    }
}