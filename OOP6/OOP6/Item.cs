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
        public Item() { }
        public double Price() { return Cost; }
    }
}
