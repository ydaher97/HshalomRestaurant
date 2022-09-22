using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HshlomResturant
{
    /// <summary>
    /// Interaction logic for Table.xaml
    /// </summary>

    public enum Meals { Manchowsoup = 100, Chicken = 90, Noodlesoup = 80, Talumeinsoup = 120, Mushroom = 105 }

    public enum Drinks { cola = 9, fanta = 7, zero = 8, lemonada = 4, orange = 6, water = 5 }

    
    public partial class Table : Window
    {
        private List<Meal> lmeals = new List<Meal>();
        private List<Drink> ldrinks = new List<Drink>();
        int c = 0;
        int total = 0;
        //int a = 0;
        int hour = DateTime.Now.Hour;
        int min = DateTime.Now.Minute;
        int sec = DateTime.Now.Second;
        int year = DateTime.Now.Year;
        int mon = DateTime.Now.Month;
        int day = DateTime.Now.Day;
        DayOfWeek d = DateTime.Now.DayOfWeek;
        string Ename;

        int Tablenum;
        //internal int tablenumber_property;

        //public int tnumber_1 { get; set; }

        public Table()
        {
            InitializeComponent();
            PrintBtn.IsEnabled = false;
            AddBtn.IsEnabled = false;
            EndO.IsEnabled = false;
            PayB.IsEnabled = false;
        }
        public Table(int t)
        {
           InitializeComponent();
           this.Tablenum = t;
        }

        public int tablenum_proprety
        {
            get { return this.Tablenum; }
            set { this.Tablenum = value; }
        }
        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            //Order.Text = "";
            AddBtn.IsEnabled = true;
            EndO.IsEnabled = true;

            foreach (TableC t in Employee.tableslist)
            {
                if (t.tablenum_property == this.Tablenum)
                {
                    MessageBox.Show("this table is opened!!", "");
                    return;
                }
            }

            Employee em = new Employee();
            TablesMaps tm = new TablesMaps();
            em.OpenT(this.Tablenum);
            
            
        }

        private void alltables_Click(object sender, RoutedEventArgs e)
        {
            
            this.Hide();                //close the table window
            
        }

        private void MLoad_Load(object sender, RoutedEventArgs e)
        {
            
            Ename = MainWindow.UserOnline;     //loading the name the connecting user
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)  //button to add order number
        {
            c++;         
            OrderN.Text = "Order " + c + "\nEmployee name : " + Ename;
            //Order.Text += "your order" + c;

        }
        

        private void b1_Click(object sender, RoutedEventArgs e)
        {

            lmeals.Add(new Meal(Meals.Manchowsoup));
            foreach (Meal w in lmeals)
            {

                Order.Text += w;
                total += w.PriceR();
            }
            lmeals.Clear();


        }
        private void b2_Click(object sender, RoutedEventArgs e)
        {

            lmeals.Add(new Meal(Meals.Chicken));
            foreach (Meal w in lmeals)
            {
                Order.Text += w;
                total += w.PriceR();
            }
            lmeals.Clear();

        }
        private void b3_Click(object sender, RoutedEventArgs e)
        {
            lmeals.Add(new Meal(Meals.Noodlesoup));
            foreach(Meal w in lmeals)
            {
                Order.Text += w;
                total += w.PriceR();
            }
            lmeals.Clear();
        }
        private void b4_Click(object sender, RoutedEventArgs e)
        {
            lmeals.Add(new Meal(Meals.Talumeinsoup));
            foreach (Meal w in lmeals)
            {
                Order.Text += w;
                total += w.PriceR();
            }
            lmeals.Clear();
        }
        private void b5_Click(object sender, RoutedEventArgs e)
        {
            lmeals.Add(new Meal(Meals.Mushroom));
            foreach (Meal w in lmeals)
            {
                Order.Text += w;
                total += w.PriceR();
            }
            lmeals.Clear();

        }
        private void PrintTotal()
        {
            Order.Text += $"\n\nyour price : {total}\n*****************\n"
                + $"{day}/{mon}/{year}\n{hour}:{min}:{sec}  {d}";
        }

        private void EndO_Click(object sender, RoutedEventArgs e)  //display the final recipt
        {
            PrintTotal();
            PayB.IsEnabled = true;
            PrintBtn.IsEnabled = true;
        }

        private void PrintBtn_Click(object sender, RoutedEventArgs e) //print the recipt
        {
            MessageBox.Show(OrderN.Text + "\n" + Order.Text); 
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Order.Text = "";
            total = 0;
            AddBtn.IsEnabled = false;
            PrintBtn.IsEnabled = false;
            EndO.IsEnabled = false;
        }
        private void b11_Click(object sender, RoutedEventArgs e)
        {
            ldrinks.Add(new Drink(Drinks.cola));
            foreach(Drink d in ldrinks)
            {
                Order.Text += d;
                total += d.PriceR();

            }
            ldrinks.Clear();

        }
        private void b22_Click(object sender, RoutedEventArgs e)
        {
            ldrinks.Add(new Drink(Drinks.fanta));
            foreach(Drink d in ldrinks)
            {
                Order.Text += d;
                total += d.PriceR();
            }
            ldrinks.Clear();
        }
        private void b33_Click(object sender, RoutedEventArgs e)
        {
            ldrinks.Add(new Drink(Drinks.zero));
            foreach(Drink d in ldrinks)
            {
                Order.Text += d;
                total += d.PriceR();
            }
            ldrinks.Clear();
        }
        private void b44_Click(object sender, RoutedEventArgs e)
        {
            ldrinks.Add(new Drink(Drinks.lemonada));
            foreach (Drink d in ldrinks)
            {
                Order.Text += d;
                total += d.PriceR();
            }
            ldrinks.Clear();
        }
        private void b55_Click(object sender, RoutedEventArgs e)
        {
            ldrinks.Add(new Drink(Drinks.orange));
            foreach(Drink d in ldrinks)
            {
                Order.Text += d;
                total += d.PriceR();
            }
            ldrinks.Clear();
        }
        private void b66_Click(object sender, RoutedEventArgs e)
        {
            ldrinks.Add(new Drink(Drinks.water));
            foreach (Drink d in ldrinks)
            {
                Order.Text += d;
                total += d.PriceR();
            }
            ldrinks.Clear();
        }

        private void Payment_Click(object sender, RoutedEventArgs e)
        {
            Payment pa = new Payment();
            pa.Xpay.Text = $"{total.ToString()}";
            pa.Show();
        }
    }
}
