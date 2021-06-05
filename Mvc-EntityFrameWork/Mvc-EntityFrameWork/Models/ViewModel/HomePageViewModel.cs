using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_EntityFrameWork.Models
{
    public class HomePageViewModel
    {
        public List<Person> PersonList { get; set; }
        public List<PersonAdress> AdressList { get; set; }
    }
}