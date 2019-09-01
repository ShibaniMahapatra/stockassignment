using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    class Customer
    {

        public void ViewProducts(List<Product> products)
        {
            foreach(var product in products)
            {
                Console.WriteLine(product.Itemid+" "+product.Item+" "+product.Instock+" "+product.Price);
            }
        }

        public void BuyProduct(List<Product> products, List<Product> cartproducts, int itemidtobuy)
        {
            //Console.WriteLine("What do you want to buy");
            //var itemidtobuy = int.Parse(Console.ReadLine());
            var index = products.IndexOf(products.Find(item => item.Itemid == itemidtobuy));
            if (index == -1)
                Console.WriteLine("Not found");
            else
            {
                Console.WriteLine("Index"+index);
                Console.WriteLine("Enter Quantity");
                var quantity = int.Parse(Console.ReadLine());
                if (products[index].Instock < quantity)
                {
                    Console.WriteLine("stock not present");
                }
                else
                {
                    cartproducts.Add(new Product()
                    {
                        Itemid = index,
                        Item = products[index].Item,
                        Quantity = quantity,
                        Sum = quantity * products[index].Price,
                        Price = products[index].Price
                    });
                    products[index].Instock = products[index].Instock - quantity;
                    Console.WriteLine("Product added");
                }
            }
        }
        public void ViewCart(List<Product> cartproducts)
        {
            Console.WriteLine("ItemID \t" + "Quantity\t " + "Price\t" + "Sum");
            foreach (var product in cartproducts)
            {
                Console.WriteLine(product.Itemid + " \t" + product.Item + " " + product.Quantity + " " + product.Price + " " + product.Sum);
            }
        }
    }
}
