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
            List<Item> cart = new List<Item>();
            Orange a = new Orange();
            cart.Add(a);
            foreach (Item index in cart)
            {
                totalCost += index.Cost;
            }
            Console.WriteLine($"The total cost is : {totalCost}");
        }
    }
}
