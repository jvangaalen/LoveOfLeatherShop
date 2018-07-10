using LoveOfLeatherShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoveOfLeatherShop.Controllers
{
    public class KeyChainRomanNumController : Controller
    {
        // GET: KeyChainRomanNum
        public ActionResult Index()
        {
            KeyChainRomanNum keyChainRomanNum = new KeyChainRomanNum()
            {
                Color = "Medium Brown",
                Engraved = ""
            };
            return View(keyChainRomanNum);
        }
    }
}