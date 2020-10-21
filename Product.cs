using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    class Product : Item
    {
        public Product(string name)
            : base(name)
        {
            switch (name)
            {
                case "animal food":
                    Cost = 2;
                    break;

                case "chair":
                    Cost = 5;
                    break;
            }
        }
    }
}
