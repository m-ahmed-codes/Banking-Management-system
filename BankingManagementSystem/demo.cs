using System.Runtime.InteropServices;

// In SDK-style projects such as this one, several assembly attributes that were historically
// defined in this file are now automatically added during build and populated with
// values defined in project properties. For details of which attributes are included
// and how to customise this process see: https://aka.ms/assembly-info-properties


// Setting ComVisible to false makes the types in this assembly not visible to COM
// components.  If you need to access a type in this assembly from COM, set the ComVisible
// attribute to true on that type.

[assembly: ComVisible(false)]

//using System.Data.SqlClient;
//using System.Windows.Forms;
//using System;
//using System.Data;

//namespace loginWithserver
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }
//        int StudentID;
//        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1VM4CU7\SQLEXPRESS;Initial Catalog=server1;Integrated Security=True");
//        private void Form1_Load(object sender, EventArgs e)
//        {
//            GetStudentRecord();

//        }
//        private void GetStudentRecord()
//        {

//            SqlCommand cmd = new SqlCommand("Select * from StudentTb", con);
//            DataTable dt = new DataTable();

//            con.Open();

//            SqlDataReader sdr = cmd.ExecuteReader();
//            dt.Load(sdr);
//            con.Close();

//            StudentRecordGridView.DataSource = dt;

//        }

//        private void SubmitBtn_Click(object sender, EventArgs e)
//        {
//            if (isvalid())
//            {
//                SqlCommand cmd = new SqlCommand("INSERT INTO StudentTb VALUES (@Names,@FatherName,@RollNumber,@Address,@Mobile)", con);
//                cmd.CommandType = CommandType.Text;
//                cmd.Parameters.AddWithValue("@Names", NameText.Text);
//                cmd.Parameters.AddWithValue("@FatherName", FatherNameText.Text);
//                cmd.Parameters.AddWithValue("@RollNumber", RollNoText.Text);
//                cmd.Parameters.AddWithValue("@Address", AdrressText.Text);
//                cmd.Parameters.AddWithValue("@Mobile", MobileText.Text);

//                con.Open();
//                cmd.ExecuteNonQuery();
//                con.Close();

//                MessageBox.Show("New student added");

//                GetStudentRecord();
//                resetForm();


//            }
//        }
//        private bool isvalid()
//        {
//            if (NameText.Text == string.Empty)
//            {
//                MessageBox.Show("Student name cannot be empty", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return false;

//            }
//            return true;
//        }

//        private void ResetBtn_Click(object sender, EventArgs e)
//        {



//            resetForm();
//        }

//        private void resetForm()
//        {
//            StudentID = 0;
//            NameText.Clear();
//            FatherNameText.Clear();
//            RollNoText.Clear();
//            AdrressText.Clear();
//            MobileText.Clear();


//            NameText.Focus();
//        }

//        private void StudentRecordGridView_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
//            StudentID = Convert.ToInt32(StudentRecordGridView.SelectedRows[0].Cells[0].Value);
//            NameText.Text = StudentRecordGridView.SelectedRows[0].Cells[1].Value.ToString();
//            FatherNameText.Text = StudentRecordGridView.SelectedRows[0].Cells[2].Value.ToString();
//            RollNoText.Text = StudentRecordGridView.SelectedRows[0].Cells[3].Value.ToString();
//            AdrressText.Text = StudentRecordGridView.SelectedRows[0].Cells[4].Value.ToString();
//            MobileText.Text = StudentRecordGridView.SelectedRows[0].Cells[5].Value.ToString();


//        }

//        private void UpdateBtn_Click(object sender, EventArgs e)
//        {
//            if (StudentID > 0)
//            {
//                SqlCommand cmd = new SqlCommand("UPDATE StudentTb SET Name = @Names,FatherName = @FatherName,RollNumber = @RollNumber,Address = @Address,Mobile =@Mobile WHERE StudentID = @ID", con);
//                cmd.CommandType = CommandType.Text;
//                cmd.Parameters.AddWithValue("@Names", NameText.Text);
//                cmd.Parameters.AddWithValue("@FatherName", FatherNameText.Text);
//                cmd.Parameters.AddWithValue("@RollNumber", RollNoText.Text);
//                cmd.Parameters.AddWithValue("@Address", AdrressText.Text);
//                cmd.Parameters.AddWithValue("@Mobile", MobileText.Text);
//                cmd.Parameters.AddWithValue("@ID", this.StudentID);

//                con.Open();
//                cmd.ExecuteNonQuery();
//                con.Close();

//                MessageBox.Show("student Info is updated Successfully");

//                GetStudentRecord();
//                resetForm();


//            }
//            else
//            {
//                MessageBox.Show("Please selesct the row");
//            }
//        }

//        private void DeleteBtn_Click(object sender, EventArgs e)
//        {
//            if (StudentID > 0)
//            {
//                SqlCommand cmd = new SqlCommand("DELETE FROM StudentTb WHERE StudentID = @ID", con);
//                cmd.CommandType = CommandType.Text;

//                cmd.Parameters.AddWithValue("@ID", this.StudentID);

//                con.Open();
//                cmd.ExecuteNonQuery();
//                con.Close();

//                MessageBox.Show("student id delete from the table Successfully");

//                GetStudentRecord();
//                resetForm();


//            }
//            else
//            {
//                MessageBox.Show("Please selesct the row to delete");
//            }

//        }
//    }
//}

// The following GUID is for the ID of the typelib if this project is exposed to COM.

[assembly: Guid("5b5c99f8-ba83-4025-b0f0-f10fad2e6ecc")]
