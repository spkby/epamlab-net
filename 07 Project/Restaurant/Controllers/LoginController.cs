using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using Restaurant.DBContent;
using Restaurant.Models;

namespace Restaurant.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Account currAccount)
        {
            DBRestaurant db = new DBRestaurant();

            Account account = db.Accounts.FirstOrDefault(u => u.Login.Equals(currAccount.Login) && u.Password.Equals(currAccount.Password));

            if (account != null && !account.Login.Equals(""))
            {
                FormsAuthentication.SetAuthCookie(currAccount.Login, currAccount.RememberMe);
            }
            else
            {
                ModelState.AddModelError("Error", "Wrong Login or Password");
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }
    }
}