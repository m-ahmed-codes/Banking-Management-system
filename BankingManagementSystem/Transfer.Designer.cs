namespace BankingManagementSystem
{
    partial class Transfer
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
            groupBox1 = new GroupBox();
            toLabel = new Label();
            AccNoTextBox = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            fromLabel = new Label();
            fromTextBox = new TextBox();
            label3 = new Label();
            EnterDeposit = new Button();
            toTextbox = new TextBox();
            label2 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(toLabel);
            groupBox1.Controls.Add(AccNoTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(fromLabel);
            groupBox1.Controls.Add(fromTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(EnterDeposit);
            groupBox1.Controls.Add(toTextbox);
            groupBox1.Controls.Add(label2);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(9, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(938, 492);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Transfer";
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.Location = new Point(545, 143);
            toLabel.Name = "toLabel";
            toLabel.Size = new Size(35, 25);
            toLabel.TabIndex = 26;
            toLabel.Text = "Rs:";
            // 
            // AccNoTextBox
            // 
            AccNoTextBox.BorderStyle = BorderStyle.FixedSingle;
            AccNoTextBox.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            AccNoTextBox.Location = new Point(171, 232);
            AccNoTextBox.Name = "AccNoTextBox";
            AccNoTextBox.Size = new Size(276, 42);
            AccNoTextBox.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 238);
            label1.Name = "label1";
            label1.Size = new Size(95, 29);
            label1.TabIndex = 24;
            label1.Text = "Account";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.loupe;
            pictureBox1.Image = Properties.Resources.loupe;
            pictureBox1.InitialImage = Properties.Resources.loupe;
            pictureBox1.Location = new Point(424, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = Properties.Resources.loupe;
            pictureBox2.Image = Properties.Resources.loupe;
            pictureBox2.InitialImage = Properties.Resources.loupe;
            pictureBox2.Location = new Point(424, 44);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // fromLabel
            // 
            fromLabel.AutoSize = true;
            fromLabel.Location = new Point(545, 50);
            fromLabel.Name = "fromLabel";
            fromLabel.Size = new Size(35, 25);
            fromLabel.TabIndex = 21;
            fromLabel.Text = "Rs:";
            // 
            // fromTextBox
            // 
            fromTextBox.BorderStyle = BorderStyle.FixedSingle;
            fromTextBox.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            fromTextBox.Location = new Point(127, 44);
            fromTextBox.Name = "fromTextBox";
            fromTextBox.Size = new Size(276, 42);
            fromTextBox.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 50);
            label3.Name = "label3";
            label3.Size = new Size(66, 29);
            label3.TabIndex = 19;
            label3.Text = "From";
            // 
            // EnterDeposit
            // 
            EnterDeposit.Location = new Point(342, 408);
            EnterDeposit.Name = "EnterDeposit";
            EnterDeposit.Size = new Size(227, 43);
            EnterDeposit.TabIndex = 18;
            EnterDeposit.Text = "Enter";
            EnterDeposit.UseVisualStyleBackColor = true;
            EnterDeposit.Click += EnterDeposit_Click;
            // 
            // toTextbox
            // 
            toTextbox.BorderStyle = BorderStyle.FixedSingle;
            toTextbox.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            toTextbox.Location = new Point(127, 133);
            toTextbox.Name = "toTextbox";
            toTextbox.Size = new Size(276, 42);
            toTextbox.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 139);
            label2.Name = "label2";
            label2.Size = new Size(36, 29);
            label2.TabIndex = 16;
            label2.Text = "To";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(360, 21);
            label4.Name = "label4";
            label4.Size = new Size(251, 44);
            label4.TabIndex = 21;
            label4.Text = "Transfer Money";
            // 
            // Transfer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Name = "Transfer";
            Size = new Size(972, 609);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label fromLabel;
        private TextBox fromTextBox;
        private Label label3;
        private Button EnterDeposit;
        private TextBox toTextbox;
        private Label label2;
        private Label toLabel;
        private TextBox AccNoTextBox;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
    }
}
