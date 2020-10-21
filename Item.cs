using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    public abstract class Item
    {
        public double Cost { get; set; }
        public string Name { get; set; }
        public Item(string name) { Name = name; }
        //public double Price() { return Cost; }
    }
}
