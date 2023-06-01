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

namespace BankingManagementSystem
{
    public partial class Withdraw : UserControl
    {
        public Withdraw()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(dataBaseString.Connection);
        int balance;
        private void CheckBalance()
        {

            con.Open();

            string Query = "select * from AccountTb where Accno = " + CheckAmount.Text + "";
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataReader read = cmd.ExecuteReader();
            if (read.HasRows)
            {
                read.Close();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    balanceAmount.Text = "Rs: " + dr["AccBalance"].ToString();
                }

            }
            else
            {
                balanceAmount.Text = "Account does not Exits";


            }
            read.Close();
            con.Close();



        }

        public virtual void GetNewBalance()
        {

            con.Open();

            string Query = "select * from AccountTb where Accno = " + AccountNoTextbox.Text + "";
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataReader read = cmd.ExecuteReader();
            if (read.HasRows)
            {
                read.Close();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    //balanceAmount.Text = "Rs" + dr["AccBalance"].ToString();
                    balance = Convert.ToInt32(dr["AccBalance"].ToString());
                }

            }
            else
            {
                balanceAmount.Text = "Account does not Exits";


            }
            read.Close();
            con.Close();

        }

        private void WithDraw()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into TransactionTb(TName,TDate,TAmt,TACNum)values(@TN,@TD,@TA,@TAC)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@TN", "WithDraw");
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@TA", WithdrawTextbox.Text);
                cmd.Parameters.AddWithValue("@TAC", AccountNoTextbox.Text);


                // SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AdminTb where AdminUsername = '" + AdminUsername + "' and AdminPass = '" + AdminPassword + "'  ", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }

        }



        private void CheckBtn_Click(object sender, EventArgs e)
        {
            if (CheckAmount.Text == "")
            {
                MessageBox.Show("Please Enter the Account number");

            }
            else
            {
                CheckBalance();
            }
        }
        private void clear()
        {
            balanceAmount.Text = "Rs: ";
            CheckAmount.Clear();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void EnterDeposit_Click(object sender, EventArgs e)
        {
            if (AccountNoTextbox.Text == "" || WithdrawTextbox.Text == "")
            {
                MessageBox.Show("Please enter the fields");

            }
            else
            {
                WithDraw();
                GetNewBalance();
                if (balance < Convert.ToInt32(WithdrawTextbox.Text) )
                {
                    MessageBox.Show("Insufficient Balance");

                }
                else
                {
                    try
                    {

                    
                    int newBal = balance - Convert.ToInt32(WithdrawTextbox.Text);
                    SqlCommand cmd = new SqlCommand("Update AccountTb SET AccBalance = @AB WHERE AccNo = @Id", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@AB", newBal);
                    cmd.Parameters.AddWithValue("@ID", AccountNoTextbox.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    //CheckBalance();
                    MessageBox.Show("Money Deducted");
                    AccountNoTextbox.Clear();
                    WithdrawTextbox.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
               

               

            }


            
        }
    }
}
