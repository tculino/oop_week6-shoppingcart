using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    class Food : Item
    {
        public Food(string name)
            : base(name)
        {
            switch (name)
            {
                case "orange":
                    Cost = 0.25;
                    break;

                case "apple":
                    Cost = 0.6;
                    break;

                case "can":
                    Cost = 1;
                    break;
            }
        }
    }
}
