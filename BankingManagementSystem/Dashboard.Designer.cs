namespace BankingManagementSystem
{
    partial class Dashboard
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
            this.LogoutBtn2 = new System.Windows.Forms.Button();
            this.ViewAgentBtn2 = new System.Windows.Forms.Button();
            this.RegisterAgentBtn2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogoutBtn2
            // 
            this.LogoutBtn2.BackColor = System.Drawing.Color.SteelBlue;
            this.LogoutBtn2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogoutBtn2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogoutBtn2.Location = new System.Drawing.Point(708, 227);
            this.LogoutBtn2.Name = "LogoutBtn2";
            this.LogoutBtn2.Size = new System.Drawing.Size(264, 170);
            this.LogoutBtn2.TabIndex = 8;
            this.LogoutBtn2.Text = "Logout";
            this.LogoutBtn2.UseVisualStyleBackColor = false;
            this.LogoutBtn2.Click += new System.EventHandler(this.LogoutBtn2_Click);
            // 
            // ViewAgentBtn2
            // 
            this.ViewAgentBtn2.BackColor = System.Drawing.Color.SteelBlue;
            this.ViewAgentBtn2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewAgentBtn2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ViewAgentBtn2.Location = new System.Drawing.Point(389, 227);
            this.ViewAgentBtn2.Name = "ViewAgentBtn2";
            this.ViewAgentBtn2.Size = new System.Drawing.Size(264, 170);
            this.ViewAgentBtn2.TabIndex = 7;
            this.ViewAgentBtn2.Text = "View Agent";
            this.ViewAgentBtn2.UseVisualStyleBackColor = false;
            this.ViewAgentBtn2.Click += new System.EventHandler(this.ViewAgentBtn2_Click);
            // 
            // RegisterAgentBtn2
            // 
            this.RegisterAgentBtn2.BackColor = System.Drawing.Color.SteelBlue;
            this.RegisterAgentBtn2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegisterAgentBtn2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RegisterAgentBtn2.Location = new System.Drawing.Point(82, 227);
            this.RegisterAgentBtn2.Name = "RegisterAgentBtn2";
            this.RegisterAgentBtn2.Size = new System.Drawing.Size(264, 170);
            this.RegisterAgentBtn2.TabIndex = 6;
            this.RegisterAgentBtn2.Text = "Register Agent";
            this.RegisterAgentBtn2.UseVisualStyleBackColor = false;
            this.RegisterAgentBtn2.Click += new System.EventHandler(this.RegisterAgentBtn2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "DashBoard";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.Location = new System.Drawing.Point(998, 18);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(36, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogoutBtn2);
            this.Controls.Add(this.ViewAgentBtn2);
            this.Controls.Add(this.RegisterAgentBtn2);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1125, 678);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LogoutBtn2;
        private Button ViewAgentBtn2;
        private Button RegisterAgentBtn2;
        private Label label1;
        private Button button1;
    }
}
