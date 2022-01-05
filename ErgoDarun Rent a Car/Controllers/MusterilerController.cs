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
    public class MusterilerController : Controller
    {

        Repository<Araclar>aracRepo = new Repository<Araclar>();
        
        // GET: Musteriler

        public ActionResult Cikis()
        {
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult AraclariListele()
        {
            Araclar araclar = new Araclar();
            return View(aracRepo.List());
        }


        [HttpPost]
        public ActionResult AraclariListele( string aracKiralanabilirlikDurumu)
        {
            
            return RedirectToAction("AraclariListele");
        }

        [HttpGet]

        public ActionResult AracKiralama() 
        {
            return View("AracKiralama");
        }

        [HttpPost]
        public ActionResult AracKiralama(string aracKiralanabilirlikDurumu,string musteriKiralamaSuresiGun, int aracKiralayanMusteriID)
        {
            Musteri musteri = new Musteri();
            Araclar araclar = new Araclar();

            {
                araclar.aracKiralayanMusteriID = musteri.musteriID;
                araclar.aracKiralanabilirlikDurumu = "Dolu";
                araclar.aracKiralananGun = musteri.musteriKiralamaSuresiGun;
            }

            return View("AracKiralama");
        }
    }
}