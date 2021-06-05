
using Mvc_EntityFrameWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_EntityFrameWork.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            MyDataBaseEntities ct = new MyDataBaseEntities();
            HomePageViewModel homePageViewModel = new HomePageViewModel();
            homePageViewModel.PersonList = ct.Person.ToList();
            homePageViewModel.AdressList = ct.PersonAdress.ToList();
            return View(homePageViewModel);
        }
    }
}