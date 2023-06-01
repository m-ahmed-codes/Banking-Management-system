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
    public partial class Transfer : UserControl
    {
        public Transfer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(dataBaseString.Connection);

        int balance;
        int toBalance;


        private void CheckAvailableBalnce()
        {
            try
            {
                con.Open();

                string Query = "select * from AccountTb where AccNo = " + fromTextBox.Text + "";
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

                        fromLabel.Text = "Rs: " + dr["AccBalance"].ToString();
                        balance = Convert.ToInt32(dr["AccBalance"].ToString());

                    }

                }
                else
                {
                    fromLabel.Text = "Account does not Exits";


                }
                read.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }
        private void CheckAvailableBalnce(string text)
        {
            try
            {
                con.Open();

                string Query = "select * from AccountTb where AccNo = " + text + "";
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

                        toLabel.Text = "Rs: " + dr["AccBalance"].ToString();
                         toBalance= Convert.ToInt32(dr["AccBalance"].ToString());
                    }

                }
                else
                {
                    toLabel.Text = "Account does not Exits";



                }
                read.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (fromTextBox.Text == "")
            {
                MessageBox.Show("Please Enter From Account no");

            }
            else
            {


                SqlConnection con = new SqlConnection(dataBaseString.Connection);

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTb where AccNo = '" + fromTextBox.Text + "'   ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    CheckAvailableBalnce();
                    



                    con.Close();

                }
                else
                {
                    MessageBox.Show("Accout Does not Exits");
                    fromTextBox.Text = "";
                }

            }
        }

        private void transfer()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into TransferTb(TrSrc,TrDest,TrAmt,TrDate)values(@TS,@TDe,@TrA,@TD)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@TS", fromTextBox.Text);
                cmd.Parameters.AddWithValue("@TDe", toTextbox.Text);
                cmd.Parameters.AddWithValue("@TrA", AccNoTextBox.Text);
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);


                // SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AdminTb where AdminUsername = '" + AdminUsername + "' and AdminPass = '" + AdminPassword + "'  ", con);
                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Transfer Completed");


            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void Subtraction()
        {
            try
            {
                //GetNewBalance();
                int newBal = balance - Convert.ToInt16(AccNoTextBox.Text);
                //MessageBox.Show("newbal"+newBal);
                //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1VM4CU7\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True");


                SqlCommand cmd = new SqlCommand("Update AccountTb SET AccBalance = @AB WHERE AccNo = @Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@AB", newBal);
                cmd.Parameters.AddWithValue("@ID", fromTextBox.Text);

                // SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AdminTb where AdminUsername = '" + AdminUsername + "' and AdminPass = '" + AdminPassword + "'  ", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //CheckBalance();
              // MessageBox.Show("money deducted form from");
              //  AccNoTextBox.Clear();
               // fromTextBox.Clear();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
        private void Addition()
        {
            try
            {
                //GetNewBalance();
                int newBal = toBalance + Convert.ToInt16(AccNoTextBox.Text);
               // MessageBox.Show("newbal" + newBal);
                //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1VM4CU7\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True");


                SqlCommand cmd = new SqlCommand("Update AccountTb SET AccBalance = @AB WHERE AccNo = @Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@AB", newBal);
                cmd.Parameters.AddWithValue("@ID", toTextbox.Text);

                // SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AdminTb where AdminUsername = '" + AdminUsername + "' and AdminPass = '" + AdminPassword + "'  ", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //CheckBalance();
               // MessageBox.Show("money added in to to");
                //  AccNoTextBox.Clear();
                // fromTextBox.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (toTextbox.Text == "")
            {
                MessageBox.Show("Please Enter From Account no");

            }
            else
            {


                SqlConnection con = new SqlConnection(dataBaseString.Connection);

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTb where AccNo = '" + toTextbox.Text + "'   ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    CheckAvailableBalnce(toTextbox.Text);
                    // LoginAgent loginAgent = new LoginAgent();

                    //loginAgent.Show();
                    //Form1 loginForm = new Form1();
                    //loginForm.Hide();
                    if (fromTextBox.Text == toTextbox.Text)
                    {
                        MessageBox.Show("From and To are same");
                        toTextbox.Text = "";
                        toLabel.Text = "";
                    }


                    con.Close();

                }
                else
                {
                    MessageBox.Show("Accout Does not Exits");
                    toTextbox.Text = "";
                }

            }

        }
        private void Clear()
        {
            fromTextBox.Clear();
            toTextbox.Clear();
            AccNoTextBox.Clear();
            fromLabel.Text = "Rs:";
            toLabel.Text = "Rs:";
        }

        private void EnterDeposit_Click(object sender, EventArgs e)
        {
            if (toTextbox.Text == "" || fromTextBox.Text == "" || AccNoTextBox.Text == "")
            {
                MessageBox.Show("Please enter the detail");
            }
            else if (Convert.ToInt32(AccNoTextBox.Text) > balance)
            {
                MessageBox.Show("Insufisiant Balance");
            }
            else
            {
                
                Subtraction();
                Addition();
                transfer();
                Clear();



            }
        }
    }
}
