using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Item
    {
        public string title { get; set; }
        public string descriprion { get; set; }
        public decimal price { get; set; }
        public bool sold { get; set; }
        public bool paymentDistributed { get; set; }
        public Vendor owner { get; set; }

        public string Display
        {
            get
            {
                return string.Format("{0} - ${1}", title, price);
            }
        }
    }
}
