using LoveOfLeatherShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoveOfLeatherShop.Controllers
{
    public class ColorController : Controller
    {
        // GET: Color
        public ActionResult Index()
        {
            Color color = new Color()
            {
                ColorChoice = "Light Brown"
            };
            return View(color);
        }
    }
}