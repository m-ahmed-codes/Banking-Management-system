namespace BankingManagementSystem
{
    partial class Withdraw
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
            label1 = new Label();
            groupBox2 = new GroupBox();
            ResetBtn = new Button();
            CheckBtn = new Button();
            balanceAmount = new Label();
            CheckAmount = new TextBox();
            label6 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            AccountNoTextbox = new TextBox();
            label3 = new Label();
            EnterDeposit = new Button();
            WithdrawTextbox = new TextBox();
            label2 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(372, 43);
            label1.Name = "label1";
            label1.Size = new Size(284, 44);
            label1.TabIndex = 15;
            label1.Text = "WithDraw Money";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ResetBtn);
            groupBox2.Controls.Add(CheckBtn);
            groupBox2.Controls.Add(balanceAmount);
            groupBox2.Controls.Add(CheckAmount);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(button1);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(35, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(938, 189);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Check";
            // 
            // ResetBtn
            // 
            ResetBtn.Location = new Point(677, 128);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(227, 43);
            ResetBtn.TabIndex = 23;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // CheckBtn
            // 
            CheckBtn.Location = new Point(321, 128);
            CheckBtn.Name = "CheckBtn";
            CheckBtn.Size = new Size(227, 43);
            CheckBtn.TabIndex = 22;
            CheckBtn.Text = "Check";
            CheckBtn.UseVisualStyleBackColor = true;
            CheckBtn.Click += CheckBtn_Click;
            // 
            // balanceAmount
            // 
            balanceAmount.AutoSize = true;
            balanceAmount.Location = new Point(552, 54);
            balanceAmount.Name = "balanceAmount";
            balanceAmount.Size = new Size(40, 25);
            balanceAmount.TabIndex = 21;
            balanceAmount.Text = "Rs: ";
            // 
            // CheckAmount
            // 
            CheckAmount.BorderStyle = BorderStyle.FixedSingle;
            CheckAmount.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            CheckAmount.Location = new Point(206, 44);
            CheckAmount.Name = "CheckAmount";
            CheckAmount.Size = new Size(276, 42);
            CheckAmount.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(28, 50);
            label6.Name = "label6";
            label6.Size = new Size(160, 29);
            label6.TabIndex = 19;
            label6.Text = "Check Amount";
            // 
            // button1
            // 
            button1.Location = new Point(373, 274);
            button1.Name = "button1";
            button1.Size = new Size(227, 43);
            button1.TabIndex = 18;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(AccountNoTextbox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(EnterDeposit);
            groupBox1.Controls.Add(WithdrawTextbox);
            groupBox1.Controls.Add(label2);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(37, 319);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(938, 318);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Deposit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(684, 50);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 21;
            label4.Text = "label4";
            // 
            // AccountNoTextbox
            // 
            AccountNoTextbox.BorderStyle = BorderStyle.FixedSingle;
            AccountNoTextbox.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            AccountNoTextbox.Location = new Point(286, 44);
            AccountNoTextbox.Name = "AccountNoTextbox";
            AccountNoTextbox.Size = new Size(276, 42);
            AccountNoTextbox.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 50);
            label3.Name = "label3";
            label3.Size = new Size(231, 29);
            label3.TabIndex = 19;
            label3.Text = "Enter the Account No ";
            // 
            // EnterDeposit
            // 
            EnterDeposit.Location = new Point(359, 250);
            EnterDeposit.Name = "EnterDeposit";
            EnterDeposit.Size = new Size(227, 43);
            EnterDeposit.TabIndex = 18;
            EnterDeposit.Text = "Enter";
            EnterDeposit.UseVisualStyleBackColor = true;
            EnterDeposit.Click += EnterDeposit_Click;
            // 
            // WithdrawTextbox
            // 
            WithdrawTextbox.BorderStyle = BorderStyle.FixedSingle;
            WithdrawTextbox.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            WithdrawTextbox.Location = new Point(286, 131);
            WithdrawTextbox.Name = "WithdrawTextbox";
            WithdrawTextbox.Size = new Size(276, 42);
            WithdrawTextbox.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 139);
            label2.Name = "label2";
            label2.Size = new Size(197, 29);
            label2.TabIndex = 16;
            label2.Text = "Enter the Amount ";
            // 
            // Withdraw
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Withdraw";
            Size = new Size(1026, 660);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox2;
        private Button CheckBtn;
        private Label balanceAmount;
        private TextBox CheckAmount;
        private Label label6;
        private Button button1;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox AccountNoTextbox;
        private Label label3;
        private Button EnterDeposit;
        private TextBox WithdrawTextbox;
        private Label label2;
        private Button ResetBtn;
    }
}
