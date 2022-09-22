using System;
using System.IO;
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
    /// Interaction logic for ManagerLoginxaml.xaml
    /// </summary>
    public partial class ManagerLogin : Window
    {
        public string p = @"C:\Users\UPDATE\Desktop\פרויקט מתמ\HshlomResturant\HshlomResturant\ManegersPasswors.txt";
        public string pa = @"C:\Users\UPDATE\Desktop\פרויקט מתמ\HshlomResturant\HshlomResturant\EmployeesList.txt";
        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> lines = new List<string>();
            List<string> lines1 = new List<string>();
            lines = File.ReadAllLines(p).ToList();
            lines1 = File.ReadAllLines(pa).ToList();

            foreach (string l in lines)
            {
                string [] c = l.Split(',');
                if (MgLg.Password == c[1])
                {
                    Management ma = new Management();
                    ma.Show();
                    this.Hide();
                    break;
                }

                else
                {
                    MessageBox.Show("only manager can enter");
                    
                }
                break;
            }
            foreach(string k in lines1)
            {
                string [] c1 = k.Split(',');
                if ((MgLg.Password == c1[1]) && (c1[4] == "manager"))
                {
                    Management ma = new Management();
                    ma.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("only manager can enter");
                    
                }
                break;
            }
        }
    }
}
