using OpenQbit.InventorySystem.Presentation.Web.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace OpenQbit.InventorySystem.Presentation.Web.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public void LoginToSystem(string userName, string password)
        {
           /* WebClient client = new WebClient();

            bool b = await client.LoginCustomer(userName, password);

            Console.Write("userName");*/

            RedirectToAction("Login", "Login");
        }

    }
}