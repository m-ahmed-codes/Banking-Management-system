namespace BankingManagementSystem
{
    partial class Deposit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AmountDisplay = new System.Windows.Forms.Label();
            this.AccountNoTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EnterDeposit = new System.Windows.Forms.Button();
            this.AmountTextbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.balanceAmount = new System.Windows.Forms.Label();
            this.CheckAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(406, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 44);
            this.label1.TabIndex = 15;
            this.label1.Text = "Deposit Money";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Enter the Amount ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AmountDisplay);
            this.groupBox1.Controls.Add(this.AccountNoTextbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.EnterDeposit);
            this.groupBox1.Controls.Add(this.AmountTextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(40, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 318);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deposit";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AmountDisplay
            // 
            this.AmountDisplay.AutoSize = true;
            this.AmountDisplay.Location = new System.Drawing.Point(684, 50);
            this.AmountDisplay.Name = "AmountDisplay";
            this.AmountDisplay.Size = new System.Drawing.Size(0, 25);
            this.AmountDisplay.TabIndex = 21;
            // 
            // AccountNoTextbox
            // 
            this.AccountNoTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountNoTextbox.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AccountNoTextbox.Location = new System.Drawing.Point(286, 44);
            this.AccountNoTextbox.Name = "AccountNoTextbox";
            this.AccountNoTextbox.Size = new System.Drawing.Size(276, 42);
            this.AccountNoTextbox.TabIndex = 20;
            this.AccountNoTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Enter the Account No ";
            // 
            // EnterDeposit
            // 
            this.EnterDeposit.Location = new System.Drawing.Point(359, 250);
            this.EnterDeposit.Name = "EnterDeposit";
            this.EnterDeposit.Size = new System.Drawing.Size(227, 43);
            this.EnterDeposit.TabIndex = 18;
            this.EnterDeposit.Text = "Enter";
            this.EnterDeposit.UseVisualStyleBackColor = true;
            this.EnterDeposit.Click += new System.EventHandler(this.EnterDeposit_Click);
            // 
            // AmountTextbox
            // 
            this.AmountTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AmountTextbox.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountTextbox.Location = new System.Drawing.Point(286, 131);
            this.AmountTextbox.Name = "AmountTextbox";
            this.AmountTextbox.Size = new System.Drawing.Size(276, 42);
            this.AmountTextbox.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resetBtn);
            this.groupBox2.Controls.Add(this.CheckBtn);
            this.groupBox2.Controls.Add(this.balanceAmount);
            this.groupBox2.Controls.Add(this.CheckAmount);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(38, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(938, 189);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(686, 128);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(227, 43);
            this.resetBtn.TabIndex = 23;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // CheckBtn
            // 
            this.CheckBtn.Location = new System.Drawing.Point(361, 128);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(227, 43);
            this.CheckBtn.TabIndex = 22;
            this.CheckBtn.Text = "Check";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // balanceAmount
            // 
            this.balanceAmount.AutoSize = true;
            this.balanceAmount.Location = new System.Drawing.Point(552, 54);
            this.balanceAmount.Name = "balanceAmount";
            this.balanceAmount.Size = new System.Drawing.Size(40, 25);
            this.balanceAmount.TabIndex = 21;
            this.balanceAmount.Text = "Rs: ";
            // 
            // CheckAmount
            // 
            this.CheckAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CheckAmount.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckAmount.Location = new System.Drawing.Point(206, 44);
            this.CheckAmount.Name = "CheckAmount";
            this.CheckAmount.Size = new System.Drawing.Size(276, 42);
            this.CheckAmount.TabIndex = 20;
            this.CheckAmount.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(28, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Check Amount";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 43);
            this.button1.TabIndex = 18;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Deposit";
            this.Size = new System.Drawing.Size(1023, 662);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox AccountNoTextbox;
        private Label label3;
        private Button EnterDeposit;
        private TextBox AmountTextbox;
        private Label AmountDisplay;
        private GroupBox groupBox2;
        private Button CheckBtn;
        private Label balanceAmount;
        private TextBox CheckAmount;
        private Label label6;
        private Button button1;
        private Button resetBtn;
    }
}
