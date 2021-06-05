using Mvc_EntityFrameWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_EntityFrameWork.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult NewPerson()
        {
            return View();
        }


        [HttpPost]
        public ActionResult NewPerson(Person person)
        {
            using (MyDataBaseEntities db = new MyDataBaseEntities())
            {
                db.Person.Add(person);
                int result =db.SaveChanges();

                ViewBag.Result = result > 0 ? "Succesfull" : "Error occured on save person";
                ViewBag.Status= result > 0 ? true : false;
            }
                return View();
        }
    }
}