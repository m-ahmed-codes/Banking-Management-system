namespace BankingManagementSystem
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Login login = new Login();
        int flag = 1;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            if (flag == 1)
            {
                Bitmap b = new Bitmap(@"C:\Users\IQBAL HUSSAIN\source\repos\BankingManagementSystem\Properties/eye.png");
                
                eyebtn.Image= b;
                flag = 0;
                passwordBox.UseSystemPasswordChar = false;
            }
            else
            {
                Bitmap b = new Bitmap(@"C:\Users\IQBAL HUSSAIN\source\repos\BankingManagementSystem\Properties/invisible.png");
                eyebtn.Image = b;
                passwordBox.UseSystemPasswordChar = true;
                flag = 1;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // LoginAgent loginAgent= new LoginAgent();

            //loginAgent.Show();
            // Visible = false;

            login.AdUsername = UserNameBox.Text;
            login.AdPassword = passwordBox.Text;
            login.Selectingboxindex = selectingBox.SelectedIndex;
            login.SubmitAdminData();

            if (login.Flag == 0)
            {
                UserNameBox.Clear();
                passwordBox.Clear();

            }else if (login.Flag == 1)
            {
                this.Hide();


            } 

           




        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            UserNameBox.Clear();
            passwordBox.Clear();
            selectingBox.SelectedIndex= -1;
            selectingBox.Text= "Role";
        }

        private void selectingBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}