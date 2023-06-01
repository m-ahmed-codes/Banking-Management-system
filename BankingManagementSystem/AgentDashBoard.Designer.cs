namespace BankingManagementSystem
{
    partial class AgentDashBoard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DashBoard = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AccountPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TransactionPanel = new System.Windows.Forms.Panel();
            this.Transfer = new System.Windows.Forms.Button();
            this.DepositBtn = new System.Windows.Forms.Button();
            this.WithDrawBtn = new System.Windows.Forms.Button();
            this.TransactionBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.TransactionHistoryBtn = new System.Windows.Forms.Button();
            this.AllAccountBtn = new System.Windows.Forms.Button();
            this.Viewbtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.OtherOptionPanel = new System.Windows.Forms.Panel();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.ChangePasswordBtn = new System.Windows.Forms.Button();
            this.OtherOptionBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.AccountPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TransactionPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.ViewPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.OtherOptionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashBoard
            // 
            this.DashBoard.AutoSize = true;
            this.DashBoard.Font = new System.Drawing.Font("Calibri", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DashBoard.Location = new System.Drawing.Point(440, 69);
            this.DashBoard.Name = "DashBoard";
            this.DashBoard.Size = new System.Drawing.Size(214, 51);
            this.DashBoard.TabIndex = 0;
            this.DashBoard.Text = "DashBoard";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AccountPanel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(105, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 193);
            this.panel1.TabIndex = 2;
            // 
            // AccountPanel
            // 
            this.AccountPanel.Controls.Add(this.button3);
            this.AccountPanel.Controls.Add(this.button2);
            this.AccountPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountPanel.Location = new System.Drawing.Point(0, 60);
            this.AccountPanel.Name = "AccountPanel";
            this.AccountPanel.Size = new System.Drawing.Size(297, 124);
            this.AccountPanel.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(0, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(297, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = "Update Account";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(297, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "New Account";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TransactionPanel);
            this.panel2.Controls.Add(this.TransactionBtn);
            this.panel2.Location = new System.Drawing.Point(678, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 298);
            this.panel2.TabIndex = 3;
            // 
            // TransactionPanel
            // 
            this.TransactionPanel.Controls.Add(this.Transfer);
            this.TransactionPanel.Controls.Add(this.DepositBtn);
            this.TransactionPanel.Controls.Add(this.WithDrawBtn);
            this.TransactionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TransactionPanel.Location = new System.Drawing.Point(0, 60);
            this.TransactionPanel.Name = "TransactionPanel";
            this.TransactionPanel.Size = new System.Drawing.Size(297, 195);
            this.TransactionPanel.TabIndex = 2;
            // 
            // Transfer
            // 
            this.Transfer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Transfer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Transfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Transfer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Transfer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Transfer.Location = new System.Drawing.Point(0, 120);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(297, 60);
            this.Transfer.TabIndex = 5;
            this.Transfer.Text = "Transfer One to One";
            this.Transfer.UseVisualStyleBackColor = false;
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // DepositBtn
            // 
            this.DepositBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.DepositBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DepositBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DepositBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DepositBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DepositBtn.Location = new System.Drawing.Point(0, 60);
            this.DepositBtn.Name = "DepositBtn";
            this.DepositBtn.Size = new System.Drawing.Size(297, 60);
            this.DepositBtn.TabIndex = 4;
            this.DepositBtn.Text = "Deposit";
            this.DepositBtn.UseVisualStyleBackColor = false;
            this.DepositBtn.Click += new System.EventHandler(this.DepositBtn_Click);
            // 
            // WithDrawBtn
            // 
            this.WithDrawBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.WithDrawBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.WithDrawBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WithDrawBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WithDrawBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WithDrawBtn.Location = new System.Drawing.Point(0, 0);
            this.WithDrawBtn.Name = "WithDrawBtn";
            this.WithDrawBtn.Size = new System.Drawing.Size(297, 60);
            this.WithDrawBtn.TabIndex = 3;
            this.WithDrawBtn.Text = "WithDraw";
            this.WithDrawBtn.UseVisualStyleBackColor = false;
            this.WithDrawBtn.Click += new System.EventHandler(this.WithDrawBtn_Click);
            // 
            // TransactionBtn
            // 
            this.TransactionBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.TransactionBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TransactionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TransactionBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TransactionBtn.Location = new System.Drawing.Point(0, 0);
            this.TransactionBtn.Name = "TransactionBtn";
            this.TransactionBtn.Size = new System.Drawing.Size(297, 60);
            this.TransactionBtn.TabIndex = 1;
            this.TransactionBtn.Text = "Transaction";
            this.TransactionBtn.UseVisualStyleBackColor = false;
            this.TransactionBtn.Click += new System.EventHandler(this.TransactionBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ViewPanel);
            this.panel4.Controls.Add(this.Viewbtn);
            this.panel4.Location = new System.Drawing.Point(105, 442);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(297, 193);
            this.panel4.TabIndex = 4;
            // 
            // ViewPanel
            // 
            this.ViewPanel.Controls.Add(this.TransactionHistoryBtn);
            this.ViewPanel.Controls.Add(this.AllAccountBtn);
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewPanel.Location = new System.Drawing.Point(0, 60);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(297, 124);
            this.ViewPanel.TabIndex = 2;
            // 
            // TransactionHistoryBtn
            // 
            this.TransactionHistoryBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TransactionHistoryBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TransactionHistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionHistoryBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TransactionHistoryBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TransactionHistoryBtn.Location = new System.Drawing.Point(0, 60);
            this.TransactionHistoryBtn.Name = "TransactionHistoryBtn";
            this.TransactionHistoryBtn.Size = new System.Drawing.Size(297, 60);
            this.TransactionHistoryBtn.TabIndex = 4;
            this.TransactionHistoryBtn.Text = "Transaction History";
            this.TransactionHistoryBtn.UseVisualStyleBackColor = false;
            this.TransactionHistoryBtn.Click += new System.EventHandler(this.TransactionHistoryBtn_Click);
            // 
            // AllAccountBtn
            // 
            this.AllAccountBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AllAccountBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AllAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllAccountBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AllAccountBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AllAccountBtn.Location = new System.Drawing.Point(0, 0);
            this.AllAccountBtn.Name = "AllAccountBtn";
            this.AllAccountBtn.Size = new System.Drawing.Size(297, 60);
            this.AllAccountBtn.TabIndex = 3;
            this.AllAccountBtn.Text = "All Account";
            this.AllAccountBtn.UseVisualStyleBackColor = false;
            this.AllAccountBtn.Click += new System.EventHandler(this.AllAccountBtn_Click);
            // 
            // Viewbtn
            // 
            this.Viewbtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.Viewbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Viewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Viewbtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Viewbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Viewbtn.Location = new System.Drawing.Point(0, 0);
            this.Viewbtn.Name = "Viewbtn";
            this.Viewbtn.Size = new System.Drawing.Size(297, 60);
            this.Viewbtn.TabIndex = 1;
            this.Viewbtn.Text = "View";
            this.Viewbtn.UseVisualStyleBackColor = false;
            this.Viewbtn.Click += new System.EventHandler(this.Viewbtn_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.OtherOptionPanel);
            this.panel6.Controls.Add(this.OtherOptionBtn);
            this.panel6.Location = new System.Drawing.Point(675, 442);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(297, 193);
            this.panel6.TabIndex = 5;
            // 
            // OtherOptionPanel
            // 
            this.OtherOptionPanel.Controls.Add(this.LogoutBtn);
            this.OtherOptionPanel.Controls.Add(this.ChangePasswordBtn);
            this.OtherOptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OtherOptionPanel.Location = new System.Drawing.Point(0, 60);
            this.OtherOptionPanel.Name = "OtherOptionPanel";
            this.OtherOptionPanel.Size = new System.Drawing.Size(297, 124);
            this.OtherOptionPanel.TabIndex = 2;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LogoutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogoutBtn.Location = new System.Drawing.Point(0, 60);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(297, 60);
            this.LogoutBtn.TabIndex = 4;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // ChangePasswordBtn
            // 
            this.ChangePasswordBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ChangePasswordBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChangePasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePasswordBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChangePasswordBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChangePasswordBtn.Location = new System.Drawing.Point(0, 0);
            this.ChangePasswordBtn.Name = "ChangePasswordBtn";
            this.ChangePasswordBtn.Size = new System.Drawing.Size(297, 60);
            this.ChangePasswordBtn.TabIndex = 3;
            this.ChangePasswordBtn.Text = "Change Password";
            this.ChangePasswordBtn.UseVisualStyleBackColor = false;
            this.ChangePasswordBtn.Click += new System.EventHandler(this.ChangePasswordBtn_Click);
            // 
            // OtherOptionBtn
            // 
            this.OtherOptionBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.OtherOptionBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.OtherOptionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OtherOptionBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OtherOptionBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OtherOptionBtn.Location = new System.Drawing.Point(0, 0);
            this.OtherOptionBtn.Name = "OtherOptionBtn";
            this.OtherOptionBtn.Size = new System.Drawing.Size(297, 60);
            this.OtherOptionBtn.TabIndex = 1;
            this.OtherOptionBtn.Text = "Other Option";
            this.OtherOptionBtn.UseVisualStyleBackColor = false;
            this.OtherOptionBtn.Click += new System.EventHandler(this.OtherOptionBtn_Click);
            // 
            // AgentDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DashBoard);
            this.Name = "AgentDashBoard";
            this.Size = new System.Drawing.Size(1159, 685);
            this.panel1.ResumeLayout(false);
            this.AccountPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.TransactionPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ViewPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.OtherOptionPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label DashBoard;
        private Button button1;
        private Panel panel1;
        private Panel AccountPanel;
        private Button button3;
        private Button button2;
        private Panel panel2;
        private Panel TransactionPanel;
        private Button Transfer;
        private Button DepositBtn;
        private Button WithDrawBtn;
        private Button TransactionBtn;
        private Panel panel4;
        private Panel ViewPanel;
        private Button TransactionHistoryBtn;
        private Button AllAccountBtn;
        private Button Viewbtn;
        private Panel panel6;
        private Panel OtherOptionPanel;
        private Button LogoutBtn;
        private Button ChangePasswordBtn;
        private Button OtherOptionBtn;
    }
}
