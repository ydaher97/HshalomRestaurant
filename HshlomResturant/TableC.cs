using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HshlomResturant
{
    public class TableC
    {
        public int TableNum;

        public List<Meal> lmeals = new List<Meal>();
        public int total = 0;
        public List<string> mealsl = new List<string>();
        public List<string> drinksl = new List<string>();
        public List<string> sweetsl = new List<string>();
   

        public TableC()
        {

        }
        public TableC(int tablenum)
        {
            this.TableNum = tablenum;
        }

        public int tablenum_property
        {
            get { return TableNum; }
            set { this.TableNum = value; }
        }

        //public void Add_Meal()
        //{
        //    Table tb = new Table();
        //    //mealsl.Add(meal);
         
        //    lmeals.Add(new Meal(Meals.Manchowsoup));
        //    foreach (Meal w in lmeals)
        //    {
        //        tb.Order.Text += w;
        //        total += w.PriceR();
        //    }
        //    lmeals.Clear();
        //}
        //public void Add_Drink(string drink)
        //{
        //    drinksl.Add(drink);
        //    return;
        //}
        
    }
}
