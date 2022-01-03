using Bussiness_Layer;
using Bussiness_Layer.Abstract;
using Data_Entities.Concretes;
using System.Web.Mvc;

namespace ErgoDarun_Rent_a_Car.Controllers
{
    public class HomeController : Controller
    {
        Repository<Musteri> musteriRepo = new Repository<Musteri>();
        Repository<Calisan> calisanRepo = new Repository<Calisan>();

        // GET: Home
        public ActionResult Index()
        {
            
            //Test test = new Test();

            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View("LoginPage");
        }
        [HttpPost]
        public ActionResult Login(Musteri kontrol)
        {
            Musteri musteri = new Musteri();
            var bilgiler = musteri.musteriKullaniciAd == kontrol.musteriKullaniciAd && musteri.musteriSifre == kontrol.musteriSifre;
            if (bilgiler != null)
            {
                return RedirectToAction("AracKiralama", "Musteriler");
            }
            else
            {
                return View("LoginPage");
            }
            
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

        public ActionResult Sorular()
        {
            return View("Sorular");
        }

        [HttpGet]
        public ActionResult SignIn()
        {
            return View("SignInPage");
        }

        [HttpPost]
        public ActionResult SignIn(Musteri musteri)
        {
            musteriRepo.Insert(musteri);
            musteriRepo.Save();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CalisanLogin()
        {
            return View("CalisanLogin");
        }

        [HttpPost]
        public ActionResult CalisanLogin(Calisan kontrol)
        {
            Calisan calisan = new Calisan();
            var bilgiler = calisan.calisanKullaniciAd == kontrol.calisanKullaniciAd && calisan.calisanSifre == kontrol.calisanSifre;
            if (bilgiler != null)
            {
                return RedirectToAction("AraclariListele", "Calisanlar");
            }
            else
            {
                return View("CalisanLogin");
            }


        }
    }
}