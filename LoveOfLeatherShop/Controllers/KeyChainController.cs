using LoveOfLeatherShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoveOfLeatherShop.Controllers
{
    public class KeyChainController : Controller
    {
        // GET: KeyChain
        public ActionResult Index()
        {
            KeyChain keyChain = new KeyChain()
            {
                Color = "Light Brown",
                EndType = "Rounded",
                Engraved = ""
            };

            return View();
        }
    }
}