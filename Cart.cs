using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    class Cart
    {
        public List<Item> ACart { get; set; }
        public Cart()
        {
            List<Item> aCart = new List<Item>();
            ACart = aCart;
        }
        public void AddCart(Item anItem) { ACart.Add(anItem); }
        public void RemoveCart(Item anItem) {ACart.Remove(anItem); }
    }
}
