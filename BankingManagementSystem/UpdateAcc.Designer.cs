namespace BankingManagementSystem
{
    partial class UpdateAcc
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
            CloseBtn = new Button();
            Error = new Label();
            AddAccount = new Button();
            AccountdataGridView = new DataGridView();
            DeleteBtn = new Button();
            UpdateBtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)AccountdataGridView).BeginInit();
            SuspendLayout();
            // 
            // CloseBtn
            // 
            CloseBtn.BackColor = Color.LightSlateGray;
            CloseBtn.Location = new Point(955, 7);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Padding = new Padding(4, 0, 0, 0);
            CloseBtn.Size = new Size(36, 34);
            CloseBtn.TabIndex = 28;
            CloseBtn.Text = "X";
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // Error
            // 
            Error.AutoSize = true;
            Error.Location = new Point(7, 333);
            Error.Name = "Error";
            Error.Size = new Size(0, 25);
            Error.TabIndex = 27;
            // 
            // AddAccount
            // 
            AddAccount.Location = new Point(560, 138);
            AddAccount.Name = "AddAccount";
            AddAccount.Size = new Size(220, 51);
            AddAccount.TabIndex = 26;
            AddAccount.Text = "Add Account";
            AddAccount.UseVisualStyleBackColor = true;
            AddAccount.Click += AddAccount_Click;
            // 
            // AccountdataGridView
            // 
            AccountdataGridView.AllowUserToAddRows = false;
            AccountdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AccountdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AccountdataGridView.Dock = DockStyle.Bottom;
            AccountdataGridView.GridColor = Color.White;
            AccountdataGridView.Location = new Point(0, 259);
            AccountdataGridView.Name = "AccountdataGridView";
            AccountdataGridView.RowHeadersWidth = 62;
            AccountdataGridView.RowTemplate.Height = 33;
            AccountdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AccountdataGridView.Size = new Size(1013, 383);
            AccountdataGridView.TabIndex = 25;
            AccountdataGridView.CellClick += AccountdataGridView_CellClick;
            AccountdataGridView.CellContentClick += AccountdataGridView_CellContentClick;
            AccountdataGridView.CellStateChanged += AccountdataGridView_CellStateChanged;
            AccountdataGridView.SelectionChanged += AccountdataGridView_SelectionChanged;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(283, 139);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(220, 51);
            DeleteBtn.TabIndex = 24;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(12, 138);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(220, 51);
            UpdateBtn.TabIndex = 23;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(369, 17);
            label1.Name = "label1";
            label1.Size = new Size(303, 44);
            label1.TabIndex = 22;
            label1.Text = "Update And Delete";
            // 
            // UpdateAcc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CloseBtn);
            Controls.Add(Error);
            Controls.Add(AddAccount);
            Controls.Add(AccountdataGridView);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(label1);
            Name = "UpdateAcc";
            Size = new Size(1013, 642);
            ((System.ComponentModel.ISupportInitialize)AccountdataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CloseBtn;
        private Label Error;
        private Button AddAccount;
        private DataGridView AccountdataGridView;
        private Button DeleteBtn;
        private Button UpdateBtn;
        private Label label1;
    }
}
