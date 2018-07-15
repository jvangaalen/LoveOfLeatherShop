using LoveOfLeatherShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoveOfLeatherShop.Controllers
{
    public class EngravedController : Controller
    {
        // GET: Engraved
        public ActionResult Index()
        {
            Engraved engraved = new Engraved()
            {
                Message = ""
            };
            return View(engraved);
        }
    }
}