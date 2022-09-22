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
    /// Interaction logic for forDelete.xaml
    /// </summary>
    public partial class EmployeeListTable : Window
    {

        public EmployeeListTable()
        {
            InitializeComponent();
            aa.ItemsSource = Employees.GetEmployees();
        }
        public static class Employees
        {
            public static List<Employee> GetEmployees()
            {
                
                List<string> lines = new List<string>();
                FileRead fr = new FileRead();
                fr.Employee_read(out lines);
                var list = new List<Employee>();    
                foreach(string z in lines)
                {
                    var line = z.Split(',');
                    var employee = new Employee()
                    {
                        Name = line[0],
                        ID = line[1],
                        Mail = line[2],
                        Phone = line[3],
                        Role = line[4]
                    };
                    list.Add(employee);
                }
                return list;
            }

        }
    }
}

