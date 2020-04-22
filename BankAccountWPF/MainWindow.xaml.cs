using BankAccountCore;
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

namespace BankAccountWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateBankAcc_Click(object sender, RoutedEventArgs e)
        {
            double balance = Convert.ToDouble(InitialBalanceTxt.Text);
            Account acc = new Account(balance);

            MessageBox.Show($"Your balance is {acc.GetBalanceDisplay()}");
        }
    }
}
