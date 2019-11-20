using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneShopSite_201119.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string EMail { get; set; }
        public string FIO { get; set; }
        public string Address { get; set; }

    }
}