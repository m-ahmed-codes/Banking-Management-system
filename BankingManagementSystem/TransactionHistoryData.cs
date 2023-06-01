using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingManagementSystem
{
    public partial class TransactionHistoryData : UserControl
    {
        public TransactionHistoryData()
        {
            InitializeComponent();
            DisplayAccHolder();
        }
        SqlConnection con = new SqlConnection(dataBaseString.Connection);
        private void DisplayAccHolder()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from TransactionTb ", con);
                DataTable dt = new DataTable();

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    dt.Load(sdr);
                    con.Close();
                    TransactionData.DataSource = dt;
                }
                else
                {
                    NodataError.Text = "No data of Transaction";
                    //MessageBox.Show("Nodata");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }





        }

        private void print_Click(object sender, EventArgs e)
        {
            if (TransactionData.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Enable to find data" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {

                            PdfPTable ptable = new PdfPTable(TransactionData.Columns.Count);
                            ptable.DefaultCell.Padding = 2;
                            ptable.WidthPercentage = 100;
                            ptable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in TransactionData.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                ptable.AddCell(pCell);
                            }

                            foreach (DataGridViewRow row in TransactionData.Rows)
                            {
                                foreach (DataGridViewCell dCell in row.Cells)
                                {
                                    ptable.AddCell(dCell.Value.ToString());

                                }
                            }
                            // exporting

                            iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 10f, 10f, 0f);

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(ptable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("data Exported succesfully", "info");
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Error While Eporting data" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found");
            }

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text == "" || Select.Text == "Select")
            {
                MessageBox.Show("Select option or search box is empty");
            }
            else
            {
                if (Select.Text == "Acc Num")
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(SearchBox.Text, "^[0-9]*$"))
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("select *from TransactionTb where TACNum = @TACNum ", con);
                            cmd.Parameters.AddWithValue("TACNum", SearchBox.Text);

                            DataTable dt = new DataTable();

                            con.Open();

                            SqlDataReader sdr = cmd.ExecuteReader();
                            dt.Load(sdr);
                            con.Close();
                            TransactionData.DataSource = dt;
                        }
                        catch (Exception ex)
                        {
                            con.Close();
                            MessageBox.Show(ex.Message);

                        }

                    }
                    else
                    {
                        MessageBox.Show("Please Enter number in search box");

                    }

                }
                else
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(SearchBox.Text, "^[A-Za-z]*$"))
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("select *from TransactionTb where  TName like @TName ", con);

                            cmd.Parameters.AddWithValue("TName", string.Format("%{0}%", SearchBox.Text));
                            DataTable dt = new DataTable();

                            con.Open();

                            SqlDataReader sdr = cmd.ExecuteReader();
                            dt.Load(sdr);
                            con.Close();
                            TransactionData.DataSource = dt;

                        }
                        catch (Exception ex)
                        {
                            con.Close();
                            MessageBox.Show(ex.Message);

                        }

                    }
                    else
                    {
                        MessageBox.Show("Please Enter number in search box");

                    }
                }
            }


        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            SearchBox.Clear();
            DisplayAccHolder();
        }

        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SearchBtn.PerformClick();
            }
        }
    }
}
