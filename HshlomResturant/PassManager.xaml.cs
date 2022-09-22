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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HshlomResturant
{
    /// <summary>
    /// Interaction logic for PassManager.xaml
    /// </summary>
    
    public partial class PassManager : UserControl
    {
        FileRead fr = new FileRead();
        public PassManager()
        {
            InitializeComponent();
        }
        
        private void M1_Click(object sender, RoutedEventArgs e)
        {
           
            
            Check_Manager1();
            Check_Employee1();
                
            MgLg1.Password = "";
        }
        public void Check_Manager1()
        {
            List<string> lines = new List<string>();
            fr.Managers_Read(out lines);

            foreach (string l in lines)
            {

                string[] c = l.Split(',');
                if (MgLg1.Password == c[1])    // check if the password inserted for any manager
                                               //( == for password from the manager list)
                {

                    Management ma = new Management();
                    ma.Show();
                    

                }

            }
        }
        public void Check_Employee1()
        {
            List<string> lines1 = new List<string>();            
            fr.Employee_read(out lines1);

            foreach (string k in lines1)
            {
                string[] c1 = k.Split(',');
                if ((MgLg1.Password == c1[1]) && (c1[4] == "manager"))    //check if the password exist in the employees 
                                                                          //list and if he is a manager
                {

                    Management ma = new Management();
                    ma.Show();
 
                }

            }
        }
    }
}
