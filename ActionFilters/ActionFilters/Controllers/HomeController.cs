using ActionFilters.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionFilters.Controllers
{
    public class HomeController : Controller
    {
        [ActFilters]
        public ActionResult Index()
        {
            return View();
        }


        [ActFilters]
        public ActionResult Index2()
        {
            return View();
        }


        [ActFilters]
        public ActionResult Index3()
        {
            return View();
        }

    }
}