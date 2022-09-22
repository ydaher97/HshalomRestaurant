using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HshlomResturant
{
    public class Drink
    {
        public Drinks drinks { get; set; }

        public string Name { get; set; }
        public int Price { get; set; }

        public Drink(Drinks drinks)
        {
            this.drinks = drinks;
        }
        public int PriceR()
        {
            int price = 0;
            price += (int)drinks;
            return price;
        }
        public override string ToString()
        {

            return $"{drinks} -------- {(int)drinks}\n";
        }
    }
}
