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
    public partial class AgentDashBoard : UserControl
    {
        public AgentDashBoard()
        {
            InitializeComponent();
            customDesign();
        }
        private void customDesign()
        {
            AccountPanel.Visible = false;
            TransactionPanel.Visible = false;
            ViewPanel.Visible = false;
            OtherOptionPanel.Visible = false;

        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideShow();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }


        }
        private void HideShow()
        {
            if (AccountPanel.Visible == true)
            { AccountPanel.Visible = false; }
            if (TransactionPanel.Visible == true) { TransactionPanel.Visible = false; }
            if (OtherOptionPanel.Visible == true) { OtherOptionPanel.Visible = false; }
            if (ViewPanel.Visible == true) { ViewPanel.Visible = false; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowSubMenu(AccountPanel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!AdminNavigationpanel.Instance.PanlContainer.Controls.ContainsKey("AddAccount"))
            {
                //AgentDashBoard agentDashBoard = new AgentDashBoard();
                AddAccount addacc = new AddAccount();


                addacc.Dock = DockStyle.Fill;
                AdminNavigationpanel.Instance.PanlContainer.Controls.Add(addacc);
            }
            AdminNavigationpanel.Instance.PanlContainer.Controls["AddAccount"].BringToFront();
            HideShow();

        }

        private void AgentDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!AdminNavigationpanel.Instance.PanlContainer.Controls.ContainsKey("UpdateAcc"))
            {
                
                UpdateAcc UA = new UpdateAcc();


                UA.Dock = DockStyle.Fill;
                AdminNavigationpanel.Instance.PanlContainer.Controls.Add(UA);
            }
            AdminNavigationpanel.Instance.PanlContainer.Controls["UpdateAcc"].BringToFront();
            HideShow();

        }

        private void TransactionBtn_Click(object sender, EventArgs e)
        {
            ShowSubMenu(TransactionPanel);

        }

        private void WithDrawBtn_Click(object sender, EventArgs e)
        {
            if (!AdminNavigationpanel.Instance.PanlContainer.Controls.ContainsKey("Withdraw"))
            {
                Withdraw wd = new Withdraw();

                wd.Dock = DockStyle.Fill;
                AdminNavigationpanel.Instance.PanlContainer.Controls.Add(wd);
            }
            AdminNavigationpanel.Instance.PanlContainer.Controls["Withdraw"].BringToFront();
            HideShow();
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (!AdminNavigationpanel.Instance.PanlContainer.Controls.ContainsKey("Deposit"))
            {
                Deposit dp = new Deposit();
                //AddAccount add = new AddAccount();


                dp.Dock = DockStyle.Fill;
                AdminNavigationpanel.Instance.PanlContainer.Controls.Add(dp);
            }
            AdminNavigationpanel.Instance.PanlContainer.Controls["Deposit"].BringToFront();
            HideShow();
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            if (!AdminNavigationpanel.Instance.PanlContainer.Controls.ContainsKey("Transfer"))
            {
            
                Transfer transfer = new Transfer();
                transfer.Dock = DockStyle.Fill;
                AdminNavigationpanel.Instance.PanlContainer.Controls.Add(transfer);
            }
            AdminNavigationpanel.Instance.PanlContainer.Controls["Transfer"].BringToFront();
            HideShow();
        }

        private void Viewbtn_Click(object sender, EventArgs e)
        {
            ShowSubMenu(ViewPanel);
        }

        private void AllAccountBtn_Click(object sender, EventArgs e)
        {
            
            if (!AdminNavigationpanel.Instance.PanlContainer.Controls.ContainsKey("AccountdataDisplay"))
            {
                AccountdataDisplay accountdataDisplay = new AccountdataDisplay();
                //Transfer transfer = new Transfer();
                accountdataDisplay.Dock = DockStyle.Fill;
                AdminNavigationpanel.Instance.PanlContainer.Controls.Add(accountdataDisplay);
            }
            AdminNavigationpanel.Instance.PanlContainer.Controls["AccountdataDisplay"].BringToFront();


            HideShow();
        }

        private void TransactionHistoryBtn_Click(object sender, EventArgs e)
        {
            if (!AdminNavigationpanel.Instance.PanlContainer.Controls.ContainsKey("TransactionHistoryData"))
            {
                TransactionHistoryData THD = new TransactionHistoryData();
                //Transfer transfer = new Transfer();
                THD.Dock = DockStyle.Fill;
                AdminNavigationpanel.Instance.PanlContainer.Controls.Add(THD);
            }
            AdminNavigationpanel.Instance.PanlContainer.Controls["TransactionHistoryData"].BringToFront();
            HideShow();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            AdminNavigationpanel ad = new AdminNavigationpanel();
            ad.Visible = false;  
            //Application.Exit();
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            if (!AdminNavigationpanel.Instance.PanlContainer.Controls.ContainsKey("ChangePass"))
            {
                ChangePass CP = new ChangePass();


                CP.Dock = DockStyle.Fill;
                AdminNavigationpanel.Instance.PanlContainer.Controls.Add(CP);
            }
            AdminNavigationpanel.Instance.PanlContainer.Controls["ChangePass"].BringToFront();
            HideShow();
        }

        private void OtherOptionBtn_Click(object sender, EventArgs e)
        {
            ShowSubMenu(OtherOptionPanel);
        }
    }
}
