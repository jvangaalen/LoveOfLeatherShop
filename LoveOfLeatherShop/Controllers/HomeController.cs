using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoveOfLeatherShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            KeyChain keyChain = new KeyChain()
            {
                Color = "Black",
                Size = "Medium",
                Engraved = false
            };

            return View(keyChain);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}