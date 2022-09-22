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
    /// Interaction logic for Management.xaml
    /// </summary>
    public partial class Management : Window
    {
        
        public Management()
        {
            InitializeComponent();
            
        }

        private void Add_Employee_Click(object sender, RoutedEventArgs e) //adding employee
        {
            //Employee e1 = new Employee();
            //e1.Name = NameB.Text;
            //e1.ID = IdB.Text;
            //e1.Mail = MailB.Text;
            //e1.Phone = PhoneB.Text;
            //e1.Role = RoleB.Text;

            List<string> lines = new List<string>();
            FileRead fr = new FileRead();
            fr.Employee_read(out lines);

            if (NameB.Text == "")       //check if the name was inserted
            {
                MessageBox.Show("insert the name");
                return;
            }          
            if (IdB.Text.Length != 9)     //check if the id number is correct (= 9)
            {
                MessageBox.Show("missing numbers in id number !!");
                return;
            }
            if (PhoneB.Text.Length != 10)  //check if the phone number is correct (= 10)
            {
                MessageBox.Show("missing numbers in phone number !!");
                return;
            }
            if ((!MailB.Text.Contains("@gmail.com")) && (!MailB.Text.Contains("@hotmail.com")) && (MailB.Text != ""))  // check if the mail is correct
            {
                MessageBox.Show("incorrect mail");
                return;
            }
            if (RoleB.Text == "")    // check if the role was inserted
            {
                MessageBox.Show("enter employee role");
                return;
            }
            else if ((RoleB.Text != "manager") && (RoleB.Text != "chef") && (RoleB.Text != "waiter"))
            {
                MessageBox.Show("this role not exist !!!");
                return;
            }
            try            //if was inserted only numbers thin correct else throw exception
            {
                
                int a;
                int b;
                bool intPhoneNum = int.TryParse(PhoneB.Text.Trim(), out a);
                if (!intPhoneNum)
                {
                    throw new Exception("incorrect phone number");
                }
                bool intIdNum = int.TryParse(IdB.Text.Trim(), out b);
                if(!intIdNum)
                {
                    throw new Exception("incorrect id number");
                }
                lines.Add($"{NameB.Text},{IdB.Text},{MailB.Text},{PhoneB.Text},{RoleB.Text}");  //add this fields to the list of our file text             
                MessageBox.Show("employee added succeffuly");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);              
            }

            
            File.WriteAllLines(fr.p2, lines);     // write the list in our file
            
            
        }   

        private void El_Click(object sender, RoutedEventArgs e)   //display all the employees in the restaurant
        {
            
            EmployeeListTable elt = new EmployeeListTable();
            elt.Show();

        }
        
        private void rep_Click(object sender, RoutedEventArgs e)  //display the hours of connecting for every employee
        {
            EmployeesShow es = new EmployeesShow();
            es.Show();
            

        }

        private void Remove_Employee_Click(object sender, RoutedEventArgs e) //removing employee
        {
            List<string> lines = new List<string>();
            FileRead fr = new FileRead();
            fr.Employee_read(out lines);
            bool y = false;
            foreach(string r in lines)
            {
                string[] r1 = r.Split(',');
                if ((NameB.Text != r1[0]) && (NameB.Text != ""))
                {
                                  
                }
                else
                {
                    
                    y = true;
                }
                
            }

            if (y == true)
            {
                lines.Remove($"{NameB.Text},{IdB.Text},{MailB.Text},{PhoneB.Text},{RoleB.Text}");
                File.WriteAllLines(fr.p2, lines);
                MessageBox.Show("removed");
            }
            else
            {
                MessageBox.Show("this employee does not exists");
            }
        }
    }
}
