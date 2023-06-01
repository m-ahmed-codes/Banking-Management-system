namespace BankingManagementSystem
{
    partial class Register
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
            name = new Label();
            Namebox = new TextBox();
            UserNameBox = new TextBox();
            Uname = new Label();
            PassBox = new TextBox();
            password = new Label();
            AddressBox = new TextBox();
            address = new Label();
            Phonebox = new TextBox();
            phoneNum = new Label();
            deleteBtn = new Button();
            submitBtn = new Button();
            label1 = new Label();
            ResetBtn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(87, 112);
            name.Name = "name";
            name.Size = new Size(72, 29);
            name.TabIndex = 0;
            name.Text = "Name";
            // 
            // Namebox
            // 
            Namebox.BorderStyle = BorderStyle.FixedSingle;
            Namebox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Namebox.Location = new Point(87, 158);
            Namebox.Name = "Namebox";
            Namebox.Size = new Size(206, 37);
            Namebox.TabIndex = 1;
            Namebox.TextChanged += textBox1_TextChanged;
            // 
            // UserNameBox
            // 
            UserNameBox.BorderStyle = BorderStyle.FixedSingle;
            UserNameBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserNameBox.Location = new Point(413, 158);
            UserNameBox.Name = "UserNameBox";
            UserNameBox.Size = new Size(206, 37);
            UserNameBox.TabIndex = 3;
            // 
            // Uname
            // 
            Uname.AutoSize = true;
            Uname.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Uname.Location = new Point(413, 112);
            Uname.Name = "Uname";
            Uname.Size = new Size(113, 29);
            Uname.TabIndex = 2;
            Uname.Text = "Username";
            // 
            // PassBox
            // 
            PassBox.BorderStyle = BorderStyle.FixedSingle;
            PassBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PassBox.Location = new Point(743, 158);
            PassBox.Name = "PassBox";
            PassBox.Size = new Size(206, 37);
            PassBox.TabIndex = 5;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(743, 112);
            password.Name = "password";
            password.Size = new Size(105, 29);
            password.TabIndex = 4;
            password.Text = "Password";
            // 
            // AddressBox
            // 
            AddressBox.BorderStyle = BorderStyle.FixedSingle;
            AddressBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddressBox.Location = new Point(413, 279);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(206, 37);
            AddressBox.TabIndex = 9;
            // 
            // address
            // 
            address.AutoSize = true;
            address.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            address.Location = new Point(413, 233);
            address.Name = "address";
            address.Size = new Size(91, 29);
            address.TabIndex = 8;
            address.Text = "Address";
            // 
            // Phonebox
            // 
            Phonebox.BorderStyle = BorderStyle.FixedSingle;
            Phonebox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Phonebox.Location = new Point(87, 279);
            Phonebox.Name = "Phonebox";
            Phonebox.Size = new Size(206, 37);
            Phonebox.TabIndex = 7;
            Phonebox.TextChanged += Phonebox_TextChanged;
            // 
            // phoneNum
            // 
            phoneNum.AutoSize = true;
            phoneNum.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneNum.Location = new Point(87, 233);
            phoneNum.Name = "phoneNum";
            phoneNum.Size = new Size(162, 29);
            phoneNum.TabIndex = 6;
            phoneNum.Text = "Phone Number";
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.SteelBlue;
            deleteBtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.ForeColor = SystemColors.ControlLightLight;
            deleteBtn.Location = new Point(743, 436);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(233, 50);
            deleteBtn.TabIndex = 12;
            deleteBtn.Text = "View List";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.SteelBlue;
            submitBtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            submitBtn.ForeColor = SystemColors.ControlLightLight;
            submitBtn.Location = new Point(87, 436);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(233, 50);
            submitBtn.TabIndex = 10;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(413, 14);
            label1.Name = "label1";
            label1.Size = new Size(249, 44);
            label1.TabIndex = 13;
            label1.Text = "Register Agents";
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.SteelBlue;
            ResetBtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ResetBtn.ForeColor = SystemColors.ControlLightLight;
            ResetBtn.Location = new Point(413, 436);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(233, 50);
            ResetBtn.TabIndex = 14;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSlateGray;
            button1.Location = new Point(999, 18);
            button1.Name = "button1";
            button1.Padding = new Padding(4, 0, 0, 0);
            button1.Size = new Size(36, 34);
            button1.TabIndex = 15;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(button1);
            Controls.Add(ResetBtn);
            Controls.Add(label1);
            Controls.Add(deleteBtn);
            Controls.Add(submitBtn);
            Controls.Add(AddressBox);
            Controls.Add(address);
            Controls.Add(Phonebox);
            Controls.Add(phoneNum);
            Controls.Add(PassBox);
            Controls.Add(password);
            Controls.Add(UserNameBox);
            Controls.Add(Uname);
            Controls.Add(Namebox);
            Controls.Add(name);
            Name = "Register";
            Size = new Size(1095, 714);
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private TextBox Namebox;
        private TextBox UserNameBox;
        private Label Uname;
        private TextBox PassBox;
        private Label password;
        private TextBox AddressBox;
        private Label address;
        private TextBox Phonebox;
        private Label phoneNum;
        private Button deleteBtn;
        private Button submitBtn;
        private Label label1;
        private Button ResetBtn;
        private Button button1;
    }
}
