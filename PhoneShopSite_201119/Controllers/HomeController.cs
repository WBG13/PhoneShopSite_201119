using PhoneShopSite_201119.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneShopSite_201119.Controllers
{
    public class HomeController : Controller
    {
        PhoneContext phoneContext = new PhoneContext();

        public ActionResult Index()
        {
            IEnumerable<Phone> Phones = phoneContext.Phones;
            ViewBag.Phones = Phones;
            return View();
        }
    }
}