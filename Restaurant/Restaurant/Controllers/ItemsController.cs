using Restaurant.DBContent;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant.Controllers
{
    public class ItemsController : Controller
    {
        private List<Dish> getList(int? id)
        {
            DBRestaurant db = new DBRestaurant();

            return (id == null ? db.Dishes.ToList() : db.Dishes.Where(d => d.Course == id).ToList());
        }

        public ActionResult Get(int? id)
        {
            return Json(getList(id), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return RedirectToAction("Index","Home");
        }

    }
}