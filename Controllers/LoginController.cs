using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AgenziaCheSpedisce.Models;

namespace AgenziaCheSpedisce.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User User)
        {
            var hasValidCredentials = false;

            hasValidCredentials = true;

            if (hasValidCredentials)
            {
                FormsAuthentication.SetAuthCookie(User.UserId.ToString(), true);
                return RedirectToAction("", "");
            }
            return RedirectToAction("Index");
        }
    }
}