using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace BankingManagementSystem
{
    public partial class AdminNavigationpanel : Form
    {
        static AdminNavigationpanel obj;

        public AdminNavigationpanel()
        {
            InitializeComponent();
            customDesign();
        }

        public static AdminNavigationpanel Instance
        {
            get
            {
                if (obj == null)
                {
                    obj = new AdminNavigationpanel();
                }
                return obj;
            }
        }

        public Panel PanlContainer
        {
            get { return PanelContainer; }
            set { PanelContainer = value; }
        }

        private void customDesign()
        {
            AccountPanel.Visible= false;
            TransactionPanel.Visible= false;
            ViewPanel.Visible= false;
            OtherOptionPanel.Visible= false;

        }

        private void HideShow()
        {
            if (AccountPanel.Visible == true)
            { AccountPanel.Visible = false; }
            if (TransactionPanel.Visible == true) { TransactionPanel.Visible = false; }
            if (OtherOptionPanel.Visible == true) { OtherOptionPanel.Visible = false; }
            if (ViewPanel.Visible == true) { ViewPanel.Visible = false; }
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                HideShow();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible=false;
            }


        }


        private void DashBoardBtn_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NewAccount_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AccountBtn_Click(object sender, EventArgs e)
        {
            ShowSubMenu(AccountPanel);

        }

        private void NewAccountBtn_Click(object sender, EventArgs e)
        {
            if (!AdminNavigationpanel.Instance.PanlContainer.Controls.ContainsKey("AddAccount"))
            {
             
                AddAccount add = new AddAccount();


                add.Dock = DockStyle.Fill;
                AdminNavigationpanel.Instance.PanlContainer.Controls.Add(add);
            }
            AdminNavigationpanel.Instance.PanlContainer.Controls["AddAccount"].BringToFront();
            HideShow();
        }

        private void UpdateAccountBtn_Click(object sender, EventArgs e)
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

                Deposit deposit = new Deposit();


                deposit.Dock = DockStyle.Fill;
                AdminNavigationpanel.Instance.PanlContainer.Controls.Add(deposit);
            }
            AdminNavigationpanel.Instance.PanlContainer.Controls["Deposit"].BringToFront();
            HideShow();
        }

        private void TransferBtn_Click(object sender, EventArgs e)
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

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            ShowSubMenu(ViewPanel);
        }

        private void AccountHolderBtn_Click(object sender, EventArgs e)
        {
            if (!AdminNavigationpanel.Instance.PanlContainer.Controls.ContainsKey("AccountdataDisplay"))
            {

                AccountdataDisplay ADD = new AccountdataDisplay();


                ADD.Dock = DockStyle.Fill;
                AdminNavigationpanel.Instance.PanlContainer.Controls.Add(ADD);
            }
            AdminNavigationpanel.Instance.PanlContainer.Controls["AccountdataDisplay"].BringToFront();
            HideShow();
        }

        private void TransactionHistoryBtn_Click(object sender, EventArgs e)
        {
            if (!AdminNavigationpanel.Instance.PanlContainer.Controls.ContainsKey("TransactionHistoryData"))
            {

                TransactionHistoryData THD = new TransactionHistoryData();


                THD.Dock = DockStyle.Fill;
                AdminNavigationpanel.Instance.PanlContainer.Controls.Add(THD);
            }
            AdminNavigationpanel.Instance.PanlContainer.Controls["TransactionHistoryData"].BringToFront();
            HideShow();
        }

        private void OtherOptionBtn_Click(object sender, EventArgs e)
        {
            ShowSubMenu(OtherOptionPanel);

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();

           
            HideShow();
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
            // Navigation Code
            HideShow();
        }

        private void DashBoardBtn_Click_1(object sender, EventArgs e)
        {
            if (!AdminNavigationpanel.Instance.PanlContainer.Controls.ContainsKey("AgentDashBoard"))
            {
                AgentDashBoard agentDashBoard = new AgentDashBoard();


                agentDashBoard.Dock = DockStyle.Fill;
                AdminNavigationpanel.Instance.PanlContainer.Controls.Add(agentDashBoard);
            }
            AdminNavigationpanel.Instance.PanlContainer.Controls["AgentDashBoard"].BringToFront();

        }

        private void AdminNavigationpanel_Load(object sender, EventArgs e)
        {
            // when agent login first dashboard open code
            obj = this;
            AgentDashBoard dash = new AgentDashBoard();
            dash.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(dash);
        }
    }
}
