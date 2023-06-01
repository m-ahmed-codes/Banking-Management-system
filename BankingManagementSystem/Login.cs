using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BankingManagementSystem
{
    class MyException : Exception
    {
        public MyException(string msg) : base(msg)
        {

        }
    }

    internal class Login
    {
        int AgentID;





        string AdminUsername;
       public static string AdminPassword;
        int selectingBoxIndex = -1;
        int flag;

        public string AdUsername{
            get { return AdminUsername;}
            set { AdminUsername = value; }  

          }

       

         public  string AdPassword { get { return AdminPassword;} set { AdminPassword = value; } }
        public int Selectingboxindex
        {
            get { return selectingBoxIndex; }
            set { selectingBoxIndex = value; }
        }
        public int Flag
        {
            get { return flag; }
            set { flag = value; }
        }

        public  Login()
        {
            AdminUsername= "";
            //AdminPassword= "";
            Selectingboxindex = -1;
            
        }
        
        SqlConnection con = new SqlConnection(dataBaseString.Connection);
        //dataBaseString dbs = new dataBaseString();
        //string con = dbs.Con; 

        public void GetIdUserName()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select AgentId from AgentTb where Agentpassword = '" + AdminPassword + "'   ", con);
           
            DataTable dt = new DataTable();
            sda.Fill(dt);
            AgentID = int.Parse(dt.Rows[0][0].ToString());
                
           // MessageBox.Show("AgentPass" + AdminPassword.ToString());
            //MessageBox.Show("result"+ dt.ToString());
            //MessageBox.Show("result" + );
        }



        public void ChangePassword(string old, string newpass)
        {
            try
            {
                GetIdUserName();
                SqlCommand cmd = new SqlCommand("UPDATE AgentTb SET AgentPassword = @AgentPassword WHERE AgentID = @Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", this.AgentID);
                if (old.ToString() == newpass.ToString())
                {
                    MessageBox.Show("Both cannot be same");

                }
                else
                {
                    cmd.Parameters.AddWithValue("@AgentPassword", newpass);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Agent Login Credential updated Successfully");
                }

                // cmd.Parameters.AddWithValue("@Names", AccountdataGridView.SelectedRows[0].Cells[1].Value);




            }
            catch (Exception ex) {
                MessageBox.Show("Error "+ex.Message);

            }
           

        }
       

        public void SubmitAdminData()
        {
            
            try
            {
                if (Selectingboxindex == -1)
                {
                    throw new MyException("Role Not selected \n Please Select the Role");

                }
                else if(Selectingboxindex == 0) 
                {
                    if (AdminUsername == "" || AdPassword == "")
                    {
                        throw new MyException("AdminName And AdminPassword can not be empty  ");

                    }
                    else
                    {
                       

                        con.Open(); 
                        SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AdminTb where AdminUsername = '"+AdminUsername+"' and AdminPass = '"+AdminPassword+"'  ",con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        
                        
                        //AdminID = int.Parse(dt.Rows[0][0].ToString()) ;
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            LoginAgent loginAgent= new LoginAgent();

                            loginAgent.Show();
                            Form1 loginForm = new Form1();
                            loginForm.Hide();
                            flag = 1;

                            con.Close();

                        }
                        else
                        {
                            MessageBox.Show("Wrong admin And Password");

                            flag = 0;
                        }
                        
                    }
                    
                   

                }else if (Selectingboxindex == 1)
                {
                    if (AdminUsername == "" || AdPassword == "")
                    {
                        throw new MyException("UserName And Password can not be empty  ");

                    }
                    else
                    {


                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AgentTb where AgentUsername = '" + AdminUsername + "' and AgentPassword= '" + AdminPassword + "'  ", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        
                       
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            AdminNavigationpanel adminNavi = new AdminNavigationpanel();

                            adminNavi.Show();
                            Form1 loginForm = new Form1();
                            loginForm.Hide();
                            flag = 1;

                            con.Close();

                        }
                        else
                        {
                            MessageBox.Show("Wrong Agent UserNAme And Password");

                            flag = 0;
                        }

                    }

                }
                
            }
            catch (Exception ex)
            {
                    MessageBox.Show("Error :"+ex.Message);
                

            }





            }
        }
}
