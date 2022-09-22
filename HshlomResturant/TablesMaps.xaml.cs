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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HshlomResturant
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class TablesMaps : UserControl
    {
        public TablesMaps()
        {
            InitializeComponent();
            
        }


        //int TableNum;
        public static TablesMaps tm;
        

        private void T2_Click(object sender, RoutedEventArgs e)
        {
            Employee e2 = new Employee();
            e2.Open_Table_Window(2);
        }

        private void T3_Click(object sender, RoutedEventArgs e)
        {
            Employee e3 = new Employee();
            e3.Open_Table_Window(3);
        }

        private void T4_Click(object sender, RoutedEventArgs e)
        {
            Employee e4 = new Employee();
            e4.Open_Table_Window(4);
        }

        private void T5_Click(object sender, RoutedEventArgs e)
        {
            Employee e5 = new Employee();
            e5.Open_Table_Window(5);
        }

        private void T6_Click(object sender, RoutedEventArgs e)
        {
            Employee e6 = new Employee();
            e6.Open_Table_Window(6);
        }

        private void T7_Click(object sender, RoutedEventArgs e)
        {
            Employee e7 = new Employee();
            e7.Open_Table_Window(7);
        }

        private void T1_Click(object sender, RoutedEventArgs e)
        {
            Employee e1 = new Employee();
            e1.Open_Table_Window(1);
        }

        
    }
}
