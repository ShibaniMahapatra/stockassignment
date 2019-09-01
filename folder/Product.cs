using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    class Product
    {
        public int Itemid { get; set; }
        public string Item { get; set; }
        public double Price { get; set; }
        public int Instock { get; set; }
        public int Quantity { get; set; }
        public double Sum { get; set; }
    }
}




//productlist.Add({itemid=Constants.Itemid++, item="pen", instock=10, price=20.0});
//new Product{itemid=Constants.Itemid++, item="book",instock=20,price=25.0},
//new Product{itemid=Constants.Itemid++, item="pencil",instock=15,price=30.0},
//new Product{itemid=Constants.Itemid++, item="toys",instock=12,price=10.0}

