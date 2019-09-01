using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    class Admin
    {
        public void Addnewitem(List<Product> products)
        {

            Console.WriteLine("Enter item name");
            var itemname = Console.ReadLine();
            Console.WriteLine("Enter price");
            var price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter quantity");
            var quantity = int.Parse(Console.ReadLine());
            products.Add(new Product()
            {
                Itemid = Constants.Itemid++,
                Item = itemname,
                Price = price,
                Instock = quantity,
            }) ;
            Console.WriteLine("Item Added");
            Console.ReadKey();
        }
        public void Addstock(List<Product>products)
        {
            Console.WriteLine("Select itemid to add stock");
            var itemid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter quantity");
            int quantitytobeadded = int.Parse(Console.ReadLine());
            products[itemid].Instock = products[itemid].Instock + quantitytobeadded;
            ViewProducts(products);
            Console.ReadKey();
        }
        public void ViewProducts(List<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine(product.Itemid + " " + product.Item + " " + product.Instock + " " + product.Price);
            }
        }
    }
}
