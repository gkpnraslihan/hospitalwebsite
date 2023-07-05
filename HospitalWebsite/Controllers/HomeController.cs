using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Baslik = "Ana Sayfa";
            ViewBag.AnaSayfa = "active";
            return View();
        }
        public ActionResult Communication()
        {
            ViewBag.Baslik = "İletişim Sayfası";
            ViewBag.Communication = "active";
            return View();
        }





    }
}