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
    public partial class UpdateAcc : UserControl
    {
        public UpdateAcc()
        {
            InitializeComponent();
            DisplayAccHolder();
        }
        SqlConnection con = new SqlConnection(dataBaseString.Connection);
        int accountNo;
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DisplayAccHolder()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from AccountTb ", con);
                DataTable dt = new DataTable();

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    dt.Load(sdr);
                    con.Close();
                    AccountdataGridView.DataSource = dt;


                }
                else
                {
                    Error.Text = "No data of Agents";
                    //MessageBox.Show("Nodata");
                }

            }catch (Exception ex) {
                MessageBox.Show(ex.Message);
            
            }

           



        }


        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (accountNo > 0)
            {

                // SqlCommand cmd = new SqlCommand("INSERT INTO AccountTb VALUES (@AccName,@AccPhone,@AccEdu,@AccGender,@AccIncome,@AccAdd,@AccBalance,@AccType)", con);
                SqlCommand cmd = new SqlCommand("UPDATE AccountTb SET AccName = @AccName,AccPhoneNo = @AccPhone,AccEdu = @AccEdu,AccGender =@AccGender,AccIncome = @AccIncome,AccAdd = @AccAdd,AccBalance = @AccBalance,AccType=@AccType WHERE AccNo = @Id", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", this.accountNo);


                // cmd.Parameters.AddWithValue("@Names", AccountdataGridView.SelectedRows[0].Cells[1].Value);
                cmd.Parameters.AddWithValue("@AccName", AccountdataGridView.SelectedRows[0].Cells[1].Value);
                cmd.Parameters.AddWithValue("@AccPhone", AccountdataGridView.SelectedRows[0].Cells[2].Value);
                cmd.Parameters.AddWithValue("@AccEdu", AccountdataGridView.SelectedRows[0].Cells[3].Value);
                cmd.Parameters.AddWithValue("@AccGender", AccountdataGridView.SelectedRows[0].Cells[4].Value);
                cmd.Parameters.AddWithValue("@AccIncome", AccountdataGridView.SelectedRows[0].Cells[5].Value);
                cmd.Parameters.AddWithValue("@AccAdd", AccountdataGridView.SelectedRows[0].Cells[6].Value);
                cmd.Parameters.AddWithValue("@AccBalance", AccountdataGridView.SelectedRows[0].Cells[7].Value);
                cmd.Parameters.AddWithValue("@AccType", AccountdataGridView.SelectedRows[0].Cells[8].Value);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Agent Info is updated Successfully");

                DisplayAccHolder();

            }
            else
            {
                MessageBox.Show("please select the row");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (accountNo > 0)
            {
                var DialogResult = MessageBox.Show("Do you want to delete this row", "Conditional", MessageBoxButtons.OKCancel);

                if (DialogResult == DialogResult.OK)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM AccountTb  WHERE  AccNo = @ID", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@ID", this.accountNo);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                    MessageBox.Show("Account data deleted from the table Successfully");

                    DisplayAccHolder();
                }






            }
            else
            {
                MessageBox.Show("Please select the row to delete Or There is no data");
            }
        }

        private void AccountdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AccountdataGridView.SelectedRows[0].Cells[0].ReadOnly = true;
            AccountdataGridView.SelectedRows[0].Cells[7].ReadOnly = true;
            AccountdataGridView.SelectedRows[0].Cells[8].ReadOnly = true;
            accountNo = Convert.ToInt32(AccountdataGridView.SelectedRows[0].Cells[0].Value);
        }

        private void AccountdataGridView_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {

        }

        private void AccountdataGridView_SelectionChanged(object sender, EventArgs e)
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

        private void AddAccount_Click(object sender, EventArgs e)
        {
            if (!AdminNavigationpanel.Instance.PanlContainer.Controls.ContainsKey("AddAccount"))
            {
                MessageBox.Show("Inside");
                AddAccount add = new AddAccount();


                add.Dock = DockStyle.Fill;
                AdminNavigationpanel.Instance.PanlContainer.Controls.Add(add);
            }
            AdminNavigationpanel.Instance.PanlContainer.Controls["AddAccount"].BringToFront();
        }

        private void AccountdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
