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
    /// Interaction logic for EmployeesShow.xaml
    /// </summary>
    public partial class EmployeesShow : Window
    {
        public EmployeesShow()
        {
            InitializeComponent();
            EE.ItemsSource = EmployeeLogin1.GetEmployeeHours();
        }

        public static class EmployeeLogin1
        {
            public static List<EmployeeLogin> GetEmployeeHours()
            {
                
                List<string> lines = new List<string>();
                FileRead fr = new FileRead();
                fr.Ehours(out lines);
                var lis = new List<EmployeeLogin>();
                foreach(string i in lines)
                {
                    var line = i.Split(',');
                    var employeelogin = new EmployeeLogin()
                    {
                        Date = line[0],
                        StartTime = line[1],
                        Name = line[2],
                        

                    };
                    lis.Add(employeelogin);
                }
                return lis;
            }
        }

        
    }
}
