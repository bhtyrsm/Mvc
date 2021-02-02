using Mvc_Model_ModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Mode_ModelBinding.Controllers
{
    public class HomeController : Controller
    {


        #region SEND MODEL FROM CONTROLLER  TO VIEW

        /// <summary>
        /// //Simple Example  : Send Model from controller to View
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {

            Person person = new Person()
            {
                Name = "Bahtiyar",
                Surname = "Sime",
                Age = 27
            };
            return View(person);
        }

        /// <summary>
        /// Simple example : Send model list from controller to view
        /// </summary>
        /// <returns></returns>
        public ActionResult PersonList()
        {
            List<Person> persons = new List<Person>();
            Person person1 = new Person()
            {
                Name = "Bahtiyar",
                Surname = "Sime",
                Age = 27
            };
            Person person2 = new Person()
            {
                Name = "Bahtiyar",
                Surname = "Sime",
                Age = 27
            };
            Person person3 = new Person()
            {
                Name = "Bahtiyar",
                Surname = "Sime",
                Age = 27
            };

            persons.Add(person1);
            persons.Add(person2);
            persons.Add(person3);
            return View(persons);
        }


        /// <summary>
        /// Simple example : Send model list from controller to view in second way
        /// </summary>
        /// <returns></returns>
        public ActionResult PersonList2()
        {
            List<Person> persons = new List<Person>();
            Person person1 = new Person()
            {
                Name = "Bahtiyar",
                Surname = "Sime",
                Age = 27
            };
            Person person2 = new Person()
            {
                Name = "Bahtiyar",
                Surname = "Sime",
                Age = 27
            };
            Person person3 = new Person()
            {
                Name = "Bahtiyar",
                Surname = "Sime",
                Age = 27
            };

            persons.Add(person1);
            persons.Add(person2);
            persons.Add(person3);
            ViewData["PersonList"] = persons;
            return View();
        }

        #endregion MODEL TO VİEWS


        #region POST MODEL FROM VIEW TO CONTROLLER (Model Bindings)

        [HttpPost]
        public ActionResult Index(Person person)
        {
            return View(person);
        }

        #endregion POST MODEL FROM VIEW TO CONTROLLER (Model Bindings)
    }
}