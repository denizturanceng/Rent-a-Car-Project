using Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErgoDarun_Rent_a_Car.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Test test = new Test();
             
            return View();
        }

        public ActionResult Login()
        {
            return View("LoginPage");
        }

        public ActionResult Hakkimizda()
        {
            return View("Hakkimizda");
        }

        public ActionResult AracKiralama()
        {
            return View("AracKiralama");
        }

        public ActionResult Kampanyalar()
        {
            return View("Kampanyalar");
        }
    }
}