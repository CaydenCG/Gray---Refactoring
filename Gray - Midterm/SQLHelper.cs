using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gray___Midterm
{
    internal class SQLHelper
    {
        public static void WithdrawFromAccount(bool checkingSelected, bool savingsSelected, double amount, Label checkingLabel, Label savingsLabel)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\cayde\source\repos\Gray - Midterm\Gray - Midterm\Banking.mdf"";Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string accountType;
                    Label accountLabel;

                    if (checkingSelected)
                    {
                        accountType = "CheckingBal";
                        accountLabel = checkingLabel;
                    }
                    else if (savingsSelected)
                    {
                        accountType = "SavingsBal";
                        accountLabel = savingsLabel;
                    }
                    else
                    {
                        MessageBox.Show("Please select either checking or savings account.");
                        return;
                    }

                    // Check if the selected account has sufficient balance
                    double balance = GetAccountBalance(accountType);
                    if (balance < amount)
                    {
                        MessageBox.Show("Insufficient funds in the selected account.");
                        return;
                    }

                    UpdateBalance(connection, accountType, -amount);

                    MessageBox.Show($"Successfully withdrew {amount:C} from {accountType}. Remaining balance: {(balance - amount):C}.");

                    accountLabel.Text = (balance - amount).ToString("C");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public static double GetAccountBalance(string accountType)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\cayde\source\repos\Gray - Midterm\Gray - Midterm\Banking.mdf"";Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $"SELECT {accountType} FROM CustomerInfo"; 
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            return Convert.ToDouble(result);
                        }
                        else
                        {
                            MessageBox.Show("No data found for the specified account type.");
                            return 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return 0; 
            }
        }

        private static void UpdateBalance(SqlConnection connection, string accountType, double amount)
        {
            string query = $"UPDATE CustomerInfo SET {accountType} = {accountType} + @Amount"; 
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Amount", amount);
                command.ExecuteNonQuery();
            }

        }
        public static void TransferFunds(string sourceAccountType, string destinationAccountType, double amount)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\cayde\source\repos\Gray - Midterm\Gray - Midterm\Banking.mdf"";Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the source account has sufficient balance and if so transfers it
                    double sourceBalance = GetAccountBalance(sourceAccountType);
                    if (sourceBalance < amount)
                    {
                        MessageBox.Show("Insufficient funds in the selected account.");
                        return;
                    }

                    UpdateBalance(connection, sourceAccountType, -amount);

                    UpdateBalance(connection, destinationAccountType, amount);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
