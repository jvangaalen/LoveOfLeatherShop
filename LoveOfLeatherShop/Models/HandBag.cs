using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoveOfLeatherShop.Models
{
    public class HandBag
    {
        public int Id { get; set; }
        public bool Yellow { get;  set; }
        public bool HasHair { get; set; }
        public bool FullGrain { get;  set; }

        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
    }
}
