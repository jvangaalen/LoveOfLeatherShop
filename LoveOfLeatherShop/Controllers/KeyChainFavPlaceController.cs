using LoveOfLeatherShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoveOfLeatherShop.Controllers
{
    public class KeyChainFavPlace: Controller
    {
        public string Engraved { get; private set; }

        // GET: KeyChainFavPlace
        public ActionResult Index()
        {
            KeyChainFavPlace keyChainFavPlace = new KeyChainFavPlace()
            {
                Engraved = "",
            };
            return View(keyChainFavPlace);
        }
    }
}