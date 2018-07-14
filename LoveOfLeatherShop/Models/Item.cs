using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoveOfLeatherShop.Models
{
    public class Item
    {
        public int Id { get; set;}
        public string Name { get; set; }

        public virtual List<Bracelet> Bracelets { get; set; }
        public virtual List<HandBag> HandBags { get; set; }
        public virtual List<KeyChain> KeyChains { get; set; }
    }
}