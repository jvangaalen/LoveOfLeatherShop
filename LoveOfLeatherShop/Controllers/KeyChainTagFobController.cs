using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoveOfLeatherShop.Controllers
{
    public class KeyChainTagFobController : Controller
    {
        // GET: KeyChainTagFob
        public ActionResult Index()
        {

            KeyChainTagFob keyChainTagFob = new KeyChainTagFob()
            {
                Color = "Black",
                EndType = "Medium",
                Engraved = ""
            };

            return View(keyChainTagFob);
        }
    }
}
