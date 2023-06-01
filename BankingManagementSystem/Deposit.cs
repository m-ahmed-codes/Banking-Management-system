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
    public partial class Deposit : UserControl
    {
        public Deposit()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(dataBaseString.Connection);
        int balance;
        private  void CheckBalance(){
          
            con.Open();
            
            string Query = "select * from AccountTb where Accno = "+ CheckAmount.Text + "";
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void deposit()
        {
            try
            {
                

                SqlCommand cmd = new SqlCommand("insert into TransactionTb(TName,TDate,TAmt,TACNum)values(@TN,@TD,@TA,@TAC)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@TN", "Deposit");
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@TA", AmountTextbox.Text);
                cmd.Parameters.AddWithValue("@TAC", AccountNoTextbox.Text);


                // SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AdminTb where AdminUsername = '" + AdminUsername + "' and AdminPass = '" + AdminPassword + "'  ", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

               
            }
            catch(Exception ex) {
                con.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void EnterDeposit_Click(object sender, EventArgs e)
        {
            if (AccountNoTextbox.Text =="" || AmountTextbox.Text=="")
            {
                MessageBox.Show("Please enter the fields");

            }
            else
            {
                deposit();
                GetNewBalance();
                int newBal = balance + Convert.ToInt32(AmountTextbox.Text);
                SqlConnection con = new SqlConnection(dataBaseString.Connection);


                SqlCommand cmd = new SqlCommand("Update AccountTb SET AccBalance = @AB WHERE AccNo = @Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@AB", newBal);
                cmd.Parameters.AddWithValue("@ID", AccountNoTextbox.Text);

                // SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AdminTb where AdminUsername = '" + AdminUsername + "' and AdminPass = '" + AdminPassword + "'  ", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //CheckBalance();
                MessageBox.Show("Money Deposit");
                AccountNoTextbox.Clear();
                AmountTextbox.Clear();

            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

        private void resetBtn_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
