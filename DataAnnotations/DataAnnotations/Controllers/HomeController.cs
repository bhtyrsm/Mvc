﻿using DataAnnotations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataAnnotations.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new Person());
        }

        [HttpPost]
        public ActionResult Index(Person model)
        {
            //if all model properties are legal
            if (ModelState.IsValid)
            {

            }

            //return new error validation
            if (model.Name == "bahtiyar")
            {
                ModelState.AddModelError("Name", "this name already recorded in db");
            }
            return View(model);
        }
    }
}