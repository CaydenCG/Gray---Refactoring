using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gray___Midterm
{
    public partial class Menu : Form
    {
        public string SavingsBalText
        {
            get { return SavingsBal.Text; }
            set { SavingsBal.Text = value; }
        }

        public string CheckingBalText
        {
            get { return CheckingsBal.Text; }
            set { CheckingsBal.Text = value; }
        }
        public Menu()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login fl = new Login();
            fl.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Withdraws based on user input
        private void ButtonWithdraw_Click(object sender, EventArgs e)
        {
            double amount;
            if (!double.TryParse(AmountBal.Text, out amount))
            {
                MessageBox.Show("Please enter a valid number in the amount field.");
                return;
            }

            bool checkingSelected = CheckBox.Checked;
            bool savingsSelected = SaveBox.Checked;

            if (checkingSelected && savingsSelected)
            {
                MessageBox.Show("Please select only one account to transfer to.");
                return;
            }

            if (!checkingSelected && !savingsSelected)
            {
                MessageBox.Show("Please select an account to transfer to.");
                return;
            }

            SQLHelper.WithdrawFromAccount(checkingSelected, savingsSelected, amount, CheckingsBal, SavingsBal);
        }

        //transfers based on user input
        private void ButtonTransfer_Click(object sender, EventArgs e)
        {
            double amount;
            if (!double.TryParse(AmountBal.Text, out amount))
            {
                MessageBox.Show("Please enter a valid number in the amount field.");
                return;
            }

            bool checkingSelected = CheckBox.Checked;
            bool savingsSelected = SaveBox.Checked;

            if (checkingSelected && savingsSelected)
            {
                MessageBox.Show("Please select only one account to transfer to.");
                return;
            }

            if (!checkingSelected && !savingsSelected)
            {
                MessageBox.Show("Please select an account to transfer to.");
                return;
            }

            string selectedAccountType = checkingSelected ? "CheckingBal" : "SavingsBal";

            double currentBalance = SQLHelper.GetAccountBalance(selectedAccountType);

            if (currentBalance < amount)
            {
                MessageBox.Show("Insufficient funds in the selected account.");
                return;
            }

            string destinationAccountType = checkingSelected ? "SavingsBal" : "CheckingBal";

            SQLHelper.TransferFunds(selectedAccountType, destinationAccountType, amount);

            MessageBox.Show($"Successfully transferred {amount:C} from {selectedAccountType} to {destinationAccountType}.");

            SavingsBalText = SQLHelper.GetAccountBalance("SavingsBal").ToString("C");
            CheckingBalText = SQLHelper.GetAccountBalance("CheckingBal").ToString("C");
        }
    }
}

