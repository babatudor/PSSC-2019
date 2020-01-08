using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Store
    {
        public string name { get; set; }
        public List<Vendor> vendors { get; set; }
        public List<Item> item { get; set; }

       
        public Store()
        {
            vendors = new List<Vendor>();
            item = new List<Item>();
        }

    }
}
