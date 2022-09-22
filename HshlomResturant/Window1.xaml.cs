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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        //public static string UserOnline;
        public string now = "";
        
        public Window1()
        {
            InitializeComponent();
        }
        
        private void UserOptions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = UserOptions.SelectedIndex;
          

            switch(i)
            {         
                case 1:
                    Options2.Children.Clear();
                    Options2.Children.Add(new TablesMaps());
                    break;
                case 2:
                    Options2.Children.Clear();
                    Options2.Children.Add(new PassManager());
                    break;
                case 3:
                    Options2.Children.Clear();
                    Options2.Children.Add(new Menu());
                    break;
                default:
                    break;
            }
            

        }
        private void MainLoad_Load(object sender, RoutedEventArgs e)
        {
            OnLineText.Text = MainWindow.UserOnline + " is connected";
        }
        private void Lout_Click(object sender, RoutedEventArgs e)
        {
            
            OnLineText.Text = "";
            OffLineText.Text = "No user is connected";
            Darea.IsEnabled = false;
            Options2.Children.Clear();
            
            //EmployeesShow es = new EmployeesShow();
            //es.EE.Items.Add(el);
            
        }

        private void Lin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
        }
        
    }
}
