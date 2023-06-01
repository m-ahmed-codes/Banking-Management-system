using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingManagementSystem
{
    
    public partial class LoginAgent : Form
    {
        static LoginAgent _obj;
        public LoginAgent()
        {
            InitializeComponent();
           
          
        }

        public static LoginAgent Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new LoginAgent();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelCon; }
            set { panelCon = value; }
        }


        private void DashBoardBtn_Click(object sender, EventArgs e)
        {
            
            if (!LoginAgent.Instance.PnlContainer.Controls.ContainsKey("Dashboard"))
            {
                Register newAgent = new Register();

                newAgent.Dock = DockStyle.Fill;
                LoginAgent.Instance.PnlContainer.Controls.Add(newAgent);
            }
            LoginAgent.Instance.PnlContainer.Controls["Dashboard"].BringToFront();

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (!LoginAgent.Instance.PnlContainer.Controls.ContainsKey("Register"))
            {
                Register newAgent = new Register();

                newAgent.Dock = DockStyle.Fill;
                LoginAgent.Instance.PnlContainer.Controls.Add(newAgent);
            }
            LoginAgent.Instance.PnlContainer.Controls["Register"].BringToFront();
            //dashboard1.Hide();
            //viewAgent1.Hide();
            //register1.Show();
            //register1.BringToFront();

        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            //dashboard1.Hide();
            //register1.Hide();
            //viewAgent1.Show();
            //register1.BringToFront();
            if (!LoginAgent.Instance.PnlContainer.Controls.ContainsKey("ViewAgent"))
            {
                ViewAgent newAgent = new ViewAgent();

                newAgent.Dock = DockStyle.Fill;
                LoginAgent.Instance.PnlContainer.Controls.Add(newAgent);
            }
            LoginAgent.Instance.PnlContainer.Controls["ViewAgent"].BringToFront();

        }

        private void LoginAgent_Load(object sender, EventArgs e)
        {
            _obj = this;
            Dashboard dash = new Dashboard();
            dash.Dock= DockStyle.Fill;
            panelCon.Controls.Add(dash);


        }

        private void RegisterAgentBtn2_Click(object sender, EventArgs e)
        {
            
            //register1.BringToFront();
        }

        private void ViewAgentBtn2_Click(object sender, EventArgs e)
        {
        //    register1.Hide();
        //    viewAgent1.Show();
        //    register1.BringToFront();
        }

        private void LogoutBtn2_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            logout.Show();
            this.Hide();
        }

        private void LogoutAgentForm_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            logout.Show();
            this.Hide();

        }

        private void RegisterAgentBtn2_Click_1(object sender, EventArgs e)
        {

        }

        private void dashboard1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCon_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
