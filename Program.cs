using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalCost = 0;
            Cart cart = new Cart();
            Product a = new Product("chair");
            Food b = new Food("can");
            Food c = new Food("orange");
            cart.AddCart(a);
            cart.AddCart(b); 
            cart.AddCart(c);
            foreach (Item index in cart.ACart)
            {
                totalCost += index.Cost;
            }
            Console.WriteLine($"The total cost is : {totalCost}");
        }
    }
}
