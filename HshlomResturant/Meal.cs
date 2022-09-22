using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HshlomResturant
{
    public class Meal
    {
        public Meals meals { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        //public Meal(string name,int price)
        //{
        //    this.Name = name;
        //    this.Price = price;
        //}

        public Meal(Meals meals)
        {
            this.meals = meals;
        }
        public int PriceR()
        {
            int price = 0;
            price += (int)meals;
            return price;
        }

        public override string ToString()
        {
            return $"{meals} -------- {(int)meals}\n";
        }
        
    }
}
