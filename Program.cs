using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Admin admin = new Admin();
            List<Product> productlist = new List<Product>
            {
                new Product(){Itemid=Constants.Itemid++, Item="pen", Instock=10, Price=20.0},
                new Product(){Itemid=Constants.Itemid++, Item="pencil",Instock=15,Price=30.0 },
                new Product(){Itemid=Constants.Itemid++, Item="book",Instock=20,Price=25.0},
            };
            List<Product> cartlist = new List<Product>();
            while(true)
            {
                Console.WriteLine(("Enter 0 for login as admin or 1 for login as customer"));
                var choice = int.Parse(Console.ReadLine());
                if (choice == 0)
                {
                    Console.WriteLine("Enter 1 for Add new item 2 for update existing stock 3 for display item list 4 for logout");
                    var adminchoice = int.Parse(Console.ReadLine());
                    if (adminchoice == 1)
                        admin.Addnewitem(productlist);
                    else if(adminchoice==2)
                    {
                        admin.Addstock(productlist);
                    }
                    else if(adminchoice==3)
                    {
                        admin.ViewProducts(productlist);
                    }
                }
                else
                {
                    while(true)
                    {

                        customer.ViewProducts(productlist);
                        Console.WriteLine("Press -1 to view cart");
                        Console.WriteLine("What do you want to buy");
                        int choicetovieworbuy = int.Parse(Console.ReadLine());
                        if (choicetovieworbuy == -1)
                            customer.ViewCart(cartlist);
                        else
                        {
                            customer.BuyProduct(productlist, cartlist,choicetovieworbuy);
                        }
                        //customer.ViewProducts(productlist);
                        Console.ReadKey();
                    }
                }
           
            }
        }
    }
}
    


