using Bussiness_Layer;
using Bussiness_Layer.Abstract;
using Data_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErgoDarun_Rent_a_Car.Controllers
{
    public class CalisanlarController : Controller
    {
        Repository<Musteri> musteriRepo = new Repository<Musteri>();


        // GET: Calisanlar
        public ActionResult Index()
        {
            
            return View();
        }
    }
}