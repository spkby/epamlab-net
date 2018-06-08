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
    }
}