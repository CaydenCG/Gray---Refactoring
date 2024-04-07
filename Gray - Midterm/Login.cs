using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gray___Midterm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\cayde\source\repos\Gray - Midterm\Gray - Midterm\Banking.mdf"";Integrated Security=True;Connect Timeout=30";

        private void LoginSubmission_Click(object sender, EventArgs e)
        {
            if (CustNumLog.Text == "" || CustPin.Text == "")
            {
                MessageBox.Show("Please provide Customer Number and Pin");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from [CustomerInfo] where Customer_Number=@number and Pin=@pin", con);
                cmd.Parameters.AddWithValue("@number", CustNumLog.Text);
                cmd.Parameters.AddWithValue("@pin", CustPin.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    Menu fm = new Menu();

                    double savingsBalance = Convert.ToDouble(ds.Tables[0].Rows[0]["SavingsBal"]);
                    double checkingBalance = Convert.ToDouble(ds.Tables[0].Rows[0]["CheckingBal"]);

                    fm.SavingsBalText = savingsBalance.ToString("C");
                    fm.CheckingBalText = checkingBalance.ToString("C");

                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void LoginClear_Click(object sender, EventArgs e)
        {
            CustNumLog.Text = "";
            CustPin.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
