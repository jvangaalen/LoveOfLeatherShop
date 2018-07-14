using LoveOfLeatherShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoveOfLeatherShop.Controllers
{
    public class HandBagController : Controller
    {
        // GET: HandBag
        public ActionResult Index()
        {
            HandBag handBag = new HandBag()
            {
                Yellow = true,
                HasHair = true,
                FullGrain = true
            };

            return View(handBag);
        }
    }
}
