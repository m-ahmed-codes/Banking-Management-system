namespace BankingManagementSystem
{
    partial class TransactionHistoryData
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
            TransactionData = new DataGridView();
            print = new Button();
            NodataError = new Label();
            label1 = new Label();
            ClearBtn = new Button();
            SearchBtn = new Button();
            SearchBox = new TextBox();
            label2 = new Label();
            Select = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)TransactionData).BeginInit();
            SuspendLayout();
            // 
            // TransactionData
            // 
            TransactionData.AllowUserToAddRows = false;
            TransactionData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TransactionData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TransactionData.Dock = DockStyle.Bottom;
            TransactionData.GridColor = Color.White;
            TransactionData.Location = new Point(0, 302);
            TransactionData.Name = "TransactionData";
            TransactionData.RowHeadersWidth = 62;
            TransactionData.RowTemplate.Height = 33;
            TransactionData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TransactionData.Size = new Size(1206, 383);
            TransactionData.TabIndex = 30;
            // 
            // print
            // 
            print.BackgroundImageLayout = ImageLayout.None;
            print.FlatStyle = FlatStyle.Flat;
            print.Location = new Point(828, 242);
            print.Name = "print";
            print.Size = new Size(232, 54);
            print.TabIndex = 29;
            print.Text = "Print pdf";
            print.UseVisualStyleBackColor = true;
            print.Click += print_Click;
            // 
            // NodataError
            // 
            NodataError.AutoSize = true;
            NodataError.Location = new Point(132, 222);
            NodataError.Name = "NodataError";
            NodataError.Size = new Size(0, 25);
            NodataError.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(422, 12);
            label1.Name = "label1";
            label1.Size = new Size(342, 49);
            label1.TabIndex = 27;
            label1.Text = "Transaction History";
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(672, 169);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(182, 47);
            ClearBtn.TabIndex = 34;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(479, 167);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(163, 49);
            SearchBtn.TabIndex = 33;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // SearchBox
            // 
            SearchBox.BorderStyle = BorderStyle.FixedSingle;
            SearchBox.Location = new Point(170, 176);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(193, 31);
            SearchBox.TabIndex = 32;
            SearchBox.KeyPress += SearchBox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 179);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 31;
            label2.Text = "Search";
            // 
            // Select
            // 
            Select.FormattingEnabled = true;
            Select.Items.AddRange(new object[] { "Acc Num", "Transaction Type" });
            Select.Location = new Point(170, 87);
            Select.Name = "Select";
            Select.Size = new Size(195, 33);
            Select.TabIndex = 35;
            Select.Text = "Select";
            // 
            // TransactionHistoryData
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Select);
            Controls.Add(ClearBtn);
            Controls.Add(SearchBtn);
            Controls.Add(SearchBox);
            Controls.Add(label2);
            Controls.Add(TransactionData);
            Controls.Add(print);
            Controls.Add(NodataError);
            Controls.Add(label1);
            Name = "TransactionHistoryData";
            Size = new Size(1206, 685);
            ((System.ComponentModel.ISupportInitialize)TransactionData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TransactionData;
        private Button print;
        private Label NodataError;
        private Label label1;
        private Button ClearBtn;
        private Button SearchBtn;
        private TextBox SearchBox;
        private Label label2;
        private ComboBox Select;
    }
}
