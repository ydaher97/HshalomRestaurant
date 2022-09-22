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
    /// Interaction logic for Payment.xaml
    /// </summary>
    public partial class Payment : Window
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void ComboB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if((bool)c1.IsSelected)
            {
                tx1.IsEnabled = false;
                tx1.Text = " ";
            }
            else
            {
                tx1.IsEnabled = true;
            }

        }

        public void Bpay_Click(object sender, RoutedEventArgs e)
        {
            if(ComboB.Text == "" || tx1.Text == "" || Xpay.Text == "")
            {
                MessageBox.Show("No payment method selected\nor card no.");
            }
            else if((bool)c2.IsSelected && tx1.Text == "" )
            {
                MessageBox.Show("card no missed");
            }
            else
            {
                MessageBox.Show("Order payment completed successfully !!!");
                this.Hide();
            }

           

        }
    }
}
