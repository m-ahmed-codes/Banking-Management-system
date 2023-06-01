namespace BankingManagementSystem
{
    partial class ChangePass
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
            label2 = new Label();
            OldPassTextBox = new TextBox();
            NewPassTextBox = new TextBox();
            label3 = new Label();
            ChangePassBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(408, 38);
            label1.Name = "label1";
            label1.Size = new Size(312, 49);
            label1.TabIndex = 0;
            label1.Text = "Change Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 171);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 1;
            label2.Text = "Old Password";
            // 
            // OldPassTextBox
            // 
            OldPassTextBox.BorderStyle = BorderStyle.FixedSingle;
            OldPassTextBox.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            OldPassTextBox.Location = new Point(185, 162);
            OldPassTextBox.Name = "OldPassTextBox";
            OldPassTextBox.Size = new Size(237, 42);
            OldPassTextBox.TabIndex = 2;
            // 
            // NewPassTextBox
            // 
            NewPassTextBox.BorderStyle = BorderStyle.FixedSingle;
            NewPassTextBox.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            NewPassTextBox.Location = new Point(185, 259);
            NewPassTextBox.Name = "NewPassTextBox";
            NewPassTextBox.Size = new Size(237, 42);
            NewPassTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 268);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 3;
            label3.Text = "New Password";
            // 
            // ChangePassBtn
            // 
            ChangePassBtn.Location = new Point(350, 390);
            ChangePassBtn.Name = "ChangePassBtn";
            ChangePassBtn.Size = new Size(276, 57);
            ChangePassBtn.TabIndex = 5;
            ChangePassBtn.Text = "Submit";
            ChangePassBtn.UseVisualStyleBackColor = true;
            ChangePassBtn.Click += ChangePassBtn_Click;
            // 
            // ChangePass
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ChangePassBtn);
            Controls.Add(NewPassTextBox);
            Controls.Add(label3);
            Controls.Add(OldPassTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChangePass";
            Size = new Size(1026, 664);
            Load += ChangePass_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OldPassTextBox;
        private TextBox NewPassTextBox;
        private Label label3;
        private Button ChangePassBtn;
    }
}
