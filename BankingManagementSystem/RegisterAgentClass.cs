using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingManagementSystem
{
    class MyAgentException : Exception
    {
        public MyAgentException(string msg) : base(msg)
        {

        }
    }
    internal class RegisterAgentClass
    {
        string agentName;
        string agentUsername;
        string agentPassword;
        int agentPhoneNo;
        string agentAddress;
        int flag =0;

        public string AgentName
        {
            get { return agentName; }
            set { agentName = value; }
        }

        public int Flag
        {
            get { return flag; }
            set { flag = value; }
        }

        public string AgentUsername
        {
            get { return agentUsername; }
            set { agentUsername = value; }
        }
        public string AgentPassword
        {
            get { return agentPassword; }
            set { agentPassword = value; }
        }

        public int Agentphoneno
        {
            get { return agentPhoneNo; }
            set
            {
                agentPhoneNo = value;
            }
        }
        public string AgentAddress
        {
            get { return agentAddress; }
                        set
            {
                agentAddress = value;
            }
        }
        public void AddAgentdata()
        {
            agentName = "";
            agentUsername = "";
            agentPassword = "";
            agentPhoneNo = 0;
            agentAddress = "";


        }

        public void AddAgentdata(string AN, string AUN, string AP, int APN, string AD)
        {
             agentName = AN;
            agentUsername = AUN;
            agentPassword = AP;
            agentPhoneNo = APN;
            agentAddress = AD;


        }

        public void deleteAgent()
        {

        }


        public void AgentSubmit()
        {
            try
            {
                if (agentName == "" || agentUsername == ""|| agentPassword == ""  || agentAddress == "" || Agentphoneno.ToString() == "")
                {
                    throw new MyAgentException("Please Enter above all the field");

                }
                else
                {
                    SqlConnection con = new SqlConnection(dataBaseString.Connection);

                    
                    SqlCommand cmd = new SqlCommand("INSERT INTO AgentTb VALUES (@AgentName,@AgentUsername,@AgentPassword,@AgentPhoneNo,@AgentAddress)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@AgentName", agentName);
                    cmd.Parameters.AddWithValue("@AgentUsername", agentUsername);
                    cmd.Parameters.AddWithValue("@AgentPassword", agentPassword);
                    cmd.Parameters.AddWithValue("@AgentAddress", agentAddress);
                    cmd.Parameters.AddWithValue("@AgentPhoneNo", Agentphoneno);

                    // SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AdminTb where AdminUsername = '" + AdminUsername + "' and AdminPass = '" + AdminPassword + "'  ", con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Agent Added successfully");

                    flag = 1;
                    
                    
                    


                  

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);


            }
        }








    }
}
