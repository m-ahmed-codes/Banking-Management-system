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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }
       

        private void RegisterAgentBtn2_Click(object sender, EventArgs e)
        {
            if (!LoginAgent.Instance.PnlContainer.Controls.ContainsKey("Register"))
            {
                Register newAgent = new Register();

                newAgent.Dock = DockStyle.Fill;
                LoginAgent.Instance.PnlContainer.Controls.Add(newAgent);
            }
            LoginAgent.Instance.PnlContainer.Controls["Register"].BringToFront();
          
        }

        private void ViewAgentBtn2_Click(object sender, EventArgs e)
        {
            if (!LoginAgent.Instance.PnlContainer.Controls.ContainsKey("ViewAgent"))
            {
                ViewAgent newAgent = new ViewAgent();

                newAgent.Dock = DockStyle.Fill;
                LoginAgent.Instance.PnlContainer.Controls.Add(newAgent);
            }
            LoginAgent.Instance.PnlContainer.Controls["ViewAgent"].BringToFront();


        }

        private void LogoutBtn2_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            logout.Show();
            LoginAgent.Instance.Hide();


        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
