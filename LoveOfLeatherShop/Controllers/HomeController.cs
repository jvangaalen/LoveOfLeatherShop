using LoveOfLeatherShop.DAL;
using LoveOfLeatherShop.Models;
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
                Color = "Dark Brown", 
                EndType = "flagged",
                Engraved = ""
            };

            var X = new Context();
            X.KeyChains.Add(keyChain);
            X.SaveChanges();


            return View(keyChain);
        }       
    }
}