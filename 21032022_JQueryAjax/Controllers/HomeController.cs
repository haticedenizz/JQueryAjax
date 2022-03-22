using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _21032022_JQueryAjax.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public static List<string> liste = new List<string>() {"TV","Telefon","Laptop","Monitor"};
        public PartialViewResult VerileriGetir(string veri="")
        {
            if(string.IsNullOrEmpty(veri)==false)
            {
                liste.Add(veri);
            }

            System.Threading.Thread.Sleep(3000);
            return PartialView("_VerilerPartialPage",liste);
        }

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult Index3()
        {
            return View();
        }
        public ActionResult Index4()
        {
            return View();
        }
        public JsonResult VerileriGetir2(string veri="")
        {
            if (string.IsNullOrEmpty(veri) == false)
            {
                liste.Add(veri);
            }
            System.Threading.Thread.Sleep(3000);
            return Json(liste, JsonRequestBehavior.AllowGet);
        }

    }
}