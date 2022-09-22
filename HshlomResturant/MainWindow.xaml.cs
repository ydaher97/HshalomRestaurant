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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static string UserOnline;
        public string now = "";
        public string lnow = "";
        int hour = DateTime.Now.Hour;
        int min = DateTime.Now.Minute;
        int sec = DateTime.Now.Second;
        int year = DateTime.Now.Year;
        int month = DateTime.Now.Month;
        int day = DateTime.Now.Day;

        FileRead fr = new FileRead();

        public MainWindow()
        {
            InitializeComponent();

        }


        private void SignInBtn_Click(object sender, RoutedEventArgs e)
        {

            
            Check_Manager();
            Check_Employee();
            Check_Login();
            
            InBox.Text = "";                                   //clear the textbox after login
            PssBox.Password = "";                             //clear the passwordbox after login 
            
        }
        public void Time()
        {
            now = $"{hour}:{min}:{sec}";                // variable to save the time now
        }
        public void Check_Manager()
        {
            
            List<string> lines = new List<string>();
            
            fr.Managers_Read(out lines);

            foreach (string l in lines)
            {
                string[] c = l.Split(',');

                if ((InBox.Text == c[0]) && (PssBox.Password == c[1]))
                {
                    UserOnline = InBox.Text;
                    Window1 w1 = new Window1();
                    w1.Show();
                    this.Hide();
                   

                }
            }
        }
        public void Check_Employee()
        {
            List<string> lines1 = new List<string>();
            
            fr.Employee_read(out lines1);

            foreach (string k in lines1)
            {
                string[] c1 = k.Split(',');

                if ((InBox.Text == c1[0]) && (PssBox.Password == c1[1]))         //check if the details was inserted 
                                                                                 //for an employee (exists in the employees list)
                {
                    UserOnline = InBox.Text;                 // save the user name who connected
                    Window1 w1 = new Window1();
                    w1.Show();
                    this.Hide();

                }

            }

        }
        public void Check_Login()
        {
            List<string> lines2 = new List<string>();
            
            fr.Ehours(out lines2);
            EmployeeLogin el = new EmployeeLogin();

            el.Date = $"{day}/{month}/{year}";
            el.StartTime = $"{hour}:{min}:{sec}";
            el.Name = InBox.Text;

            lines2.Add($"{el.Date},{el.StartTime},{el.Name}");   //add a details of the connection like date,time to the list that read the file
                                                                 //write the list on our file
            File.WriteAllLines(fr.p3, lines2);

        }


    }




}
