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

            Bracelet bracelet = new Bracelet()
            {
                WristSize = 5,
                Color = "Dark Brown",
                Engraved = ""
            };

            return View(bracelet);
        
            HandBag handBag = new HandBag()
            {
                Yellow = true,
                HasHair = true,
                FullGrain = true
            };

            return View(handBag);       

            KeyChain keyChain = new KeyChain()
            {
                Color = "Black",
                EndType = "Medium",
                Engraved = ""
            };

            return View(keyChain);
        }       
    }
}