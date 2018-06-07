using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Restaurant.DBContent;
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

        private List<Dish> getList(int? id)
        {
            DBRestaraunt db = new DBRestaraunt();

            return (id == null ? db.Dishes.ToList() : db.Dishes.Where(d => d.Course == id).ToList());
        }

        public ActionResult GetItems(int? id)
        {
            return Json(getList(id), JsonRequestBehavior.AllowGet);
        }
    }
}