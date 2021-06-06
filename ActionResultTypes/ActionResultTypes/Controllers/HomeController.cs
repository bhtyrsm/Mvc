using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResultTypes.Controllers
{
    public class HomeController : Controller
    {
        //default action result
        public ActionResult Index()
        {
            //default: return page
            return View();
        }

        //RedirectResult
        public RedirectResult Index2()
        {
            //return string url
            //like RedirectToAction("Index")
            return Redirect("/Home/Index");
            //return Redirect("https:....");
        }
    }
}