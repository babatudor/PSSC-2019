using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public double commission { get; set; }
        public decimal paymentDue { get; set; }

        public string Display1
        {
            get
            {
                return string.Format("{0} {1} - ${2}", firstName, lastName, paymentDue);
            }
        }
        
        public Vendor()
        {
            commission = .5;
        }

    }
}
