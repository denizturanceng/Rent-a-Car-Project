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
        Repository<Araclar> aracRepo = new Repository<Araclar>();


        // GET: Calisanlar
        public ActionResult Cikis()
        {
            return RedirectToAction("Index", "Home");
        }

        public ActionResult AraclariListele()
        {
            return View(aracRepo.List());
        }

        public ActionResult KiralamaTalepleri()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AracEkleme()
        {
            return View("AracEkleme");
        }
        [HttpPost]
        public ActionResult AracEkleme(Araclar araclar)
        {
            aracRepo.Insert(araclar);
            aracRepo.Save();
            return View("AracEkleme");
        }
        [HttpGet]
        public ActionResult AracSilme()
        {
            return View("AracSilme");
        }

        [HttpPost]
        public ActionResult AracSilme(int aracID)
        {
            var model = aracRepo.GetByID(aracID);
            aracRepo.Delete(model);
            return RedirectToAction("AraclariListele");
        }

        public ActionResult MusterileriListeleme()
        {
            return View(musteriRepo.List());
        }

    }
}