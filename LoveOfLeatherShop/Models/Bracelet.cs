using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoveOfLeatherShop.Models
{
    public class Bracelet
    {
        public int Id { get; set; }
        public int WristSize { get;  set; }
        public string Color { get; set; }
        public string Engraved { get;  set; }

        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
    }
}