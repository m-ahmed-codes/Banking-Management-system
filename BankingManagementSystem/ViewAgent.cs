using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Runtime.InteropServices.JavaScript.JSType;
//using System.Drawing.font;

namespace BankingManagementSystem
{
    
    public partial class ViewAgent : UserControl
    {
        SqlConnection con = new SqlConnection(dataBaseString.Connection);
        public ViewAgent()
        {
            InitializeComponent();
            AgentRecord();


        }
        int AgentId  ;
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgentRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from AgentTb ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                dt.Load(sdr);
                con.Close();
                AdmindataGridView.DataSource = dt;


            }
            else
            {
                Error.Text = "No data of Agents";
                //MessageBox.Show("Nodata");
            }
            

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        
        private void AdmindataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
            
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            
                //MessageBox.Show("asa " + this.AgentId);
                if (AgentId>0)
                {
                 //   MessageBox.Show("Enter if");
                  
                        SqlCommand cmd = new SqlCommand("UPDATE AgentTb SET AgentName = @Names,AgentUserName = @AgentUserName,AgentPassword = @AgentPassword,AgentPhoneNo =@AgentPhoneNo,AgentAddress = @Address WHERE AgentId = @Id", con);
                        cmd.CommandType = CommandType.Text;
                    
                    cmd.Parameters.AddWithValue("@Id", this.AgentId);

                          
                        cmd.Parameters.AddWithValue("@Names", AdmindataGridView.SelectedRows[0].Cells[1].Value);
                        cmd.Parameters.AddWithValue("@AgentUserName", AdmindataGridView.SelectedRows[0].Cells[2].Value);
                        cmd.Parameters.AddWithValue("@AgentPassword", AdmindataGridView.SelectedRows[0].Cells[3].Value);
                        cmd.Parameters.AddWithValue("@AgentPhoneNo", AdmindataGridView.SelectedRows[0].Cells[4].Value);
                        cmd.Parameters.AddWithValue("@Address", AdmindataGridView.SelectedRows[0].Cells[5].Value);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                
                    MessageBox.Show("Agent Info is updated Successfully");

                    AgentRecord();

                }
                else
                {
                MessageBox.Show("please select the row");
                }

            
                
                //resetForm();


                
                
               
        }

        private void AdmindataGridView_CellClick(object sender, DataGridViewCellEventArgs e)

        {
            AdmindataGridView.SelectedRows[0].Cells[0].ReadOnly = true;
            AdmindataGridView.SelectedRows[0].Cells[7].ReadOnly = true;
            AdmindataGridView.SelectedRows[0].Cells[8].ReadOnly = true;

            AgentId = Convert.ToInt32(AdmindataGridView.SelectedRows[0].Cells[0].Value);
           


        }

        private void ViewAgent_Load(object sender, EventArgs e)
        {
            AgentRecord();
        }

        private void AdmindataGridView_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
          
        }

        private void AdmindataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void AdmindataGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in ((DataGridView)sender).SelectedCells)
            {
                cell.Style = new DataGridViewCellStyle()
                {
                    BackColor = Color.White,
                    //Font = new Font("Tahoma", 8F),
                    ForeColor = SystemColors.WindowText,
                    SelectionBackColor = Color.CornflowerBlue,
                    SelectionForeColor = SystemColors.ControlLightLight
                };
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            
            

            if (AgentId > 0)
            {
               var DialogResult =  MessageBox.Show("Do you want to delete this row", "Conditional",MessageBoxButtons.OKCancel);

               if (DialogResult == DialogResult.OK)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM AgentTb WHERE AgentId = @ID", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@ID", this.AgentId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                    MessageBox.Show("Agent data deleted from the table Successfully");

                    AgentRecord();
                }


            
          


             }
             else
            {
                MessageBox.Show("Please select the row to delete Or There is no data");
            }
        }

        private void RegisterAgent_Click(object sender, EventArgs e)
        {
            if (!LoginAgent.Instance.PnlContainer.Controls.ContainsKey("Register"))
            {
                Register newAgentt = new Register();

                newAgentt.Dock = DockStyle.Fill;
                LoginAgent.Instance.PnlContainer.Controls.Add(newAgentt);
            }
            LoginAgent.Instance.PnlContainer.Controls["Register"].BringToFront();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
