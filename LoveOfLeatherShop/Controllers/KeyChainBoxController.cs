using LoveOfLeatherShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoveOfLeatherShop.Controllers
{
    public class KeyChainBoxController : Controller
    {
        // GET: KeyChainBox
        public ActionResult Index()
        {
            KeyChainBox keyChainBox = new KeyChainBox();
            keyChainBox.Name = "For the Love of Leather";
            keyChainBox.KeyChains = new List<KeyChain>();

            for (int i = 0; i <= 99; i++)
            {
                KeyChain key = new KeyChain()
                {
                    Color = "Brown",
                    Size = "Large",
                    Engraved = false
                };

            }

            return View(keyChainBox);
        }
    }
}