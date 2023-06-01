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
//using static System.Runtime.InteropServices.JavaScript.JSType;
using iTextSharp.text;
using iTextSharp.text.pdf;
//using System.Data.Common;
using System.IO;
//using System.Reflection.Metadata;

namespace BankingManagementSystem
{
    public partial class AccountdataDisplay : UserControl
    {
        public AccountdataDisplay()
        {
            InitializeComponent();
            DisplayAccHolder();
        }
        SqlConnection con = new SqlConnection(dataBaseString.Connection);
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
                    VIewdataGridView.DataSource = dt;
                }
                else
                {
                    NodataError.Text = "No data of Agents";
                    //MessageBox.Show("Nodata");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }





        }

        //public void ExportToPdf(DataGridView dwg, string fileName)
        //{
        //    BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1250, BaseFont.EMBEDDED);
        //    PdfPTable pdftable = new PdfPTable(dwg.Columns.Count);
        //    pdftable.DefaultCell.Padding = 3;
        //    pdftable.WidthPercentage = 100;
        //    pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
        //    pdftable.DefaultCell.BorderWidth = 1;

        //    iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
        //    // Add Header
        //    foreach (DataGridViewColumn column in dwg.Columns)
        //    {
        //        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
        //        cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
        //        pdftable.AddCell(cell);

        //    }

        //    //add datarow
        //    foreach (DataGridViewRow row in dwg.Rows)
        //    {
        //        foreach (DataGridViewCell Cell in row.Cells)
        //        {
        //            // MessageBox.Show("dadadaad"+ Cell.Value.ToString());
        //            pdftable.AddCell(new Phrase(Cell.Value.ToString(), text));

        //        }


        //    }


        //    var savefiledialoge = new SaveFileDialog();
        //    savefiledialoge.FileName = fileName;
        //    savefiledialoge.DefaultExt = ".pdf";
        //    if (savefiledialoge.ShowDialog() == DialogResult.OK)
        //    {
        //        using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
        //        {


        //            Document pdf = new Document(PageSize.A4, 10f, 10f, 10, 0f);
        //            if (stream == null)
        //            {
        //                MessageBox.Show("daada");
        //            }
        //            PdfWriter.GetInstance(pdf, stream);
        //            pdf.Open();
        //            pdf.Add(pdftable);
        //            stream.Close();
        //            pdf.Close();

        //        }
        //    }


        //}
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void print_Click(object sender, EventArgs e)
        {
            //ExportToPdf(VIewdataGridView, "test");
            if (VIewdataGridView.Rows.Count > 0)
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

                            PdfPTable ptable = new PdfPTable(VIewdataGridView.Columns.Count);
                            ptable.DefaultCell.Padding = 2;
                            ptable.WidthPercentage = 100;
                            ptable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in VIewdataGridView.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                ptable.AddCell(pCell);
                            }

                            foreach (DataGridViewRow row in VIewdataGridView.Rows)
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            //   MessageBox.Show("here" + Select.Text);
            if (SearchBox.Text == "" || Select.Text == "Select")
            {
                MessageBox.Show("Select option or search box is empty");
            }
            else
            {
                if (Select.Text == "Id")
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(SearchBox.Text, "^[0-9]*$"))
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("select *from AccountTb where AccNo = @AccNo ", con);
                            cmd.Parameters.AddWithValue("AccNo", SearchBox.Text);

                            DataTable dt = new DataTable();

                            con.Open();

                            SqlDataReader sdr = cmd.ExecuteReader();
                            dt.Load(sdr);
                            con.Close();
                            VIewdataGridView.DataSource = dt;
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
                            SqlCommand cmd = new SqlCommand("select *from AccountTb where  AccName like @AccName ", con);

                            cmd.Parameters.AddWithValue("AccName", string.Format("%{0}%", SearchBox.Text));
                            DataTable dt = new DataTable();

                            con.Open();

                            SqlDataReader sdr = cmd.ExecuteReader();
                            dt.Load(sdr);
                            con.Close();
                            VIewdataGridView.DataSource = dt;

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

        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SearchBtn.PerformClick();
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            SearchBox.Clear();
            DisplayAccHolder();

        }
    }
}
