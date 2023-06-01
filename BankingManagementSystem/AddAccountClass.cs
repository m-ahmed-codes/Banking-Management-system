using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingManagementSystem
{
    class MyAddAccException : Exception
    {
        public MyAddAccException(string msg) : base(msg)
        {

        }
    }
    internal class AddAccountClass : Customer
    {
        int accountno;
        string BankName = "Ahmed Bank";
        double balance;
        string accountType;
        int flag = 0 ;

       public AddAccountClass()
        {
            accountno = 0;
            balance= 0;
            accountType = string.Empty;

        }


        public void setDataAccMethod(string CN, int CP, string CE, string CG, int CI, string CA,string AT)
        {
            
            CustomerName = CN;
            CustomerPhoneNo = CP;
            CustomerEduaction = CE;
            CustomerGender = CG;
            CustomerIncome = CI;
            CustomerAddress = CA;
            accountType = AT;
        }
        public int Flag
        {
            get { return flag; }
            set { flag = value; }
        }
        public int AccountNo 
        {
            get{ return accountno; }
            set{ accountno = value; }

        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public string AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }

        public void addAccount()
        {
            try
            {
                if (CustomerName == "" || CustomerEduaction == "" || CustomerGender == " " || CustomerAddress == "" || CustomerPhoneNo.ToString() == "0" || CustomerIncome.ToString() == "0" || accountType == "")
                {
                    throw new MyAgentException("Please Enter above all the field");

                }
                else
                {
                    SqlConnection con = new SqlConnection(dataBaseString.Connection);


                    SqlCommand cmd = new SqlCommand("INSERT INTO AccountTb VALUES (@AccName,@AccPhone,@AccEdu,@AccGender,@AccIncome,@AccAdd,@AccBalance,@AccType)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@AccName", CustomerName);
                    cmd.Parameters.AddWithValue("@AccPhone", CustomerPhoneNo);
                    cmd.Parameters.AddWithValue("@AccEdu", CustomerEduaction);
                    cmd.Parameters.AddWithValue("@AccGender", CustomerGender);
                    cmd.Parameters.AddWithValue("@AccIncome", CustomerIncome);
                    cmd.Parameters.AddWithValue("@AccAdd", CustomerAddress);
                    cmd.Parameters.AddWithValue("@AccBalance", balance);
                    cmd.Parameters.AddWithValue("@AccType", accountType);

                    // SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AdminTb where AdminUsername = '" + AdminUsername + "' and AdminPass = '" + AdminPassword + "'  ", con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Account created Successfully");

                    flag = 1;

                    //DataTable dt = new DataTable();





                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);


            }
        }









    }
}
