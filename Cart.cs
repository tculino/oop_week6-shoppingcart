using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    class Cart
    {
        public List<Item> aCart { get; set; }
        public Cart() { }
        public void AddCart(Item anItem) { aCart.Add(anItem); }
        public void RemoveCart(Item anItem) {aCart.Remove(anItem); }
    }
}
