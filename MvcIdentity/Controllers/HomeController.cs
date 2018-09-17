using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcIdentity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public string NoAuthorise() // hit in url then direct open this method
        {
            return "This action method is not defined authorize";
        }

        [Authorize(Roles = "Admin")]
        public string RoleAuthorise()// hit in url then can't open this method without admin login
        {
            return "This action method is open when admin login";
        }

        [Authorize(Roles = "User")]
        public string UserMethod()// hit in url then can't open this method without user login
        {
            return "This action method is open when user authorize";
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}