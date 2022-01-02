using Bussiness_Layer;
using Bussiness_Layer.Abstract;
using Data_Entities.Concretes;
using System.Web.Mvc;

namespace ErgoDarun_Rent_a_Car.Controllers
{
    public class HomeController : Controller
    {
        Repository<Musteri> musteriRepo = new Repository<Musteri>();

        // GET: Home
        public ActionResult Index()
        {
            //var musteriList = musteriRepo.List();
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
                return RedirectToAction("Index","Musteriler");
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

        public ActionResult CalisanLogin()
        {
            return View();
        }
        /*public ActionResult CalisanLogin()
        {
            return View();

        }*/
    }
}