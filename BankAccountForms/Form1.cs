using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankAccountCore;

namespace BankAccountForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double initialBalance = Convert.ToDouble(initialbalancetxt.Text);
            Account acc = new Account(initialBalance);

            MessageBox.Show($"You created an acc with {acc.GetBalanceDisplay()}");
        }
    }
}
