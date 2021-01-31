using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_SimpleForm.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// GET:Home
        /// Returns Home Page view
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Post: Home
        /// </summary>
        /// <param name="text1"></param>
        /// <param name="check1"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(string text1,bool check1)
        {
            /*also you can get values like this 
             
             string text1=Request.Form["text1"];
             bool check1=Request.Form.GetValues("check1")[0]
             
             */
            return View();
        }
    }
}