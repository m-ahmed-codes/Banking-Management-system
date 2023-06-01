namespace BankingManagementSystem
{
    partial class AccountdataDisplay
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            NodataError = new Label();
            print = new Button();
            dataGridViewBindingSource = new BindingSource(components);
            VIewdataGridView = new DataGridView();
            label2 = new Label();
            SearchBox = new TextBox();
            SearchBtn = new Button();
            ClearBtn = new Button();
            Select = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VIewdataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(422, 25);
            label1.Name = "label1";
            label1.Size = new Size(299, 49);
            label1.TabIndex = 0;
            label1.Text = "All Account Data";
            // 
            // NodataError
            // 
            NodataError.AutoSize = true;
            NodataError.Location = new Point(142, 256);
            NodataError.Name = "NodataError";
            NodataError.Size = new Size(0, 27);
            NodataError.TabIndex = 2;
            // 
            // print
            // 
            print.BackgroundImageLayout = ImageLayout.None;
            print.FlatStyle = FlatStyle.Flat;
            print.Location = new Point(773, 275);
            print.Name = "print";
            print.Size = new Size(232, 54);
            print.TabIndex = 3;
            print.Text = "Print pdf";
            print.UseVisualStyleBackColor = true;
            print.Click += print_Click;
            // 
            // dataGridViewBindingSource
            // 
            dataGridViewBindingSource.DataSource = typeof(DataGridView);
            dataGridViewBindingSource.CurrentChanged += dataGridViewBindingSource_CurrentChanged;
            // 
            // VIewdataGridView
            // 
            VIewdataGridView.AllowUserToAddRows = false;
            VIewdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            VIewdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VIewdataGridView.Dock = DockStyle.Bottom;
            VIewdataGridView.GridColor = Color.White;
            VIewdataGridView.Location = new Point(0, 335);
            VIewdataGridView.Name = "VIewdataGridView";
            VIewdataGridView.RowHeadersWidth = 62;
            VIewdataGridView.RowTemplate.Height = 33;
            VIewdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            VIewdataGridView.Size = new Size(1138, 383);
            VIewdataGridView.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 196);
            label2.Name = "label2";
            label2.Size = new Size(73, 27);
            label2.TabIndex = 27;
            label2.Text = "Search";
            // 
            // SearchBox
            // 
            SearchBox.BorderStyle = BorderStyle.FixedSingle;
            SearchBox.Location = new Point(173, 193);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(193, 34);
            SearchBox.TabIndex = 28;
            SearchBox.KeyPress += SearchBox_KeyPress;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(482, 184);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(163, 49);
            SearchBtn.TabIndex = 29;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(675, 186);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(182, 47);
            ClearBtn.TabIndex = 30;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // Select
            // 
            Select.FormattingEnabled = true;
            Select.Items.AddRange(new object[] { "Id", "Name" });
            Select.Location = new Point(69, 98);
            Select.Name = "Select";
            Select.Size = new Size(195, 35);
            Select.TabIndex = 31;
            Select.Text = "Select";
            // 
            // AccountdataDisplay
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Select);
            Controls.Add(ClearBtn);
            Controls.Add(SearchBtn);
            Controls.Add(SearchBox);
            Controls.Add(label2);
            Controls.Add(VIewdataGridView);
            Controls.Add(print);
            Controls.Add(NodataError);
            Controls.Add(label1);
            Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "AccountdataDisplay";
            Size = new Size(1138, 718);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)VIewdataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label NodataError;
        private Button print;
        private DataGridView VIewdataGridView;
        private BindingSource dataGridViewBindingSource;
        private DataGridView AccountdataGridView;
        private Label label2;
        private TextBox SearchBox;
        private Button SearchBtn;
        private Button ClearBtn;
        private ComboBox Select;
    }
}
