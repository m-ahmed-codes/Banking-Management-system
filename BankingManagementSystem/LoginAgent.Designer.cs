namespace BankingManagementSystem
{
    partial class LoginAgent
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LogoutAgentForm = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.DashBoardBtn = new System.Windows.Forms.Button();
            this.panelCon = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 782);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LogoutAgentForm);
            this.panel2.Controls.Add(this.ViewBtn);
            this.panel2.Controls.Add(this.RegisterBtn);
            this.panel2.Controls.Add(this.DashBoardBtn);
            this.panel2.Location = new System.Drawing.Point(0, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 271);
            this.panel2.TabIndex = 0;
            // 
            // LogoutAgentForm
            // 
            this.LogoutAgentForm.BackColor = System.Drawing.Color.SteelBlue;
            this.LogoutAgentForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoutAgentForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogoutAgentForm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LogoutAgentForm.Location = new System.Drawing.Point(0, 198);
            this.LogoutAgentForm.Name = "LogoutAgentForm";
            this.LogoutAgentForm.Size = new System.Drawing.Size(319, 66);
            this.LogoutAgentForm.TabIndex = 3;
            this.LogoutAgentForm.Text = "Logout";
            this.LogoutAgentForm.UseVisualStyleBackColor = false;
            this.LogoutAgentForm.Click += new System.EventHandler(this.LogoutAgentForm_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.ViewBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ViewBtn.Location = new System.Drawing.Point(0, 132);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(319, 66);
            this.ViewBtn.TabIndex = 2;
            this.ViewBtn.Text = "View Agents";
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.RegisterBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegisterBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegisterBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RegisterBtn.Location = new System.Drawing.Point(0, 66);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(319, 66);
            this.RegisterBtn.TabIndex = 1;
            this.RegisterBtn.Text = "Register Agent";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // DashBoardBtn
            // 
            this.DashBoardBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.DashBoardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashBoardBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DashBoardBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DashBoardBtn.Location = new System.Drawing.Point(0, 0);
            this.DashBoardBtn.Name = "DashBoardBtn";
            this.DashBoardBtn.Size = new System.Drawing.Size(319, 66);
            this.DashBoardBtn.TabIndex = 0;
            this.DashBoardBtn.Text = "DashBoard";
            this.DashBoardBtn.UseVisualStyleBackColor = false;
            this.DashBoardBtn.Click += new System.EventHandler(this.DashBoardBtn_Click);
            // 
            // panelCon
            // 
            this.panelCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCon.Location = new System.Drawing.Point(320, 0);
            this.panelCon.Name = "panelCon";
            this.panelCon.Size = new System.Drawing.Size(1054, 782);
            this.panelCon.TabIndex = 1;
            this.panelCon.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCon_Paint);
            // 
            // LoginAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1374, 782);
            this.Controls.Add(this.panelCon);
            this.Controls.Add(this.panel1);
            this.Name = "LoginAgent";
            this.Text = "LoginAgent";
            this.Load += new System.EventHandler(this.LoginAgent_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button LogoutAgentForm;
        private Button ViewBtn;
        private Button RegisterBtn;
        private Button DashBoardBtn;
        private Panel panelCon;
    }
}