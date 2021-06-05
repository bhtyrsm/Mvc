using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_EntityFrameWork.Controllers
{
    public class AdressController : Controller
    {
        // GET: Adress
        public ActionResult NewAdress()
        {
            return View();
        }
    }
}