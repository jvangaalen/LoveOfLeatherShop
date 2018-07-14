using LoveOfLeatherShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoveOfLeatherShop.Controllers
{
    public class BraceletController : Controller
    {
        // GET: KeyChainRomanNum
        public ActionResult Index()
        {
            Bracelet bracelet = new Bracelet()
            {
                WristSize = 5,
                Color = "Medium Brown",
                Engraved = ""
            };
            return View(bracelet);
        }
    }
}