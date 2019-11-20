using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneShopSite_201119.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Producer {get; set;}
        public int Price { get; set; }

        public override string ToString() {
            return $"Phone name: {Name}, Producer: {Producer}";
        }
    }
}