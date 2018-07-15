using LoveOfLeatherShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoveOfLeatherShop.Controllers
{
    public class EndTypeController : Controller
    {
        // GET: endType
        public ActionResult Index()
        {
            EndType endType = new EndType()
            {
                KeyChainEnd = "Rounded"
            };
            return View(endType);
        }
    }
}