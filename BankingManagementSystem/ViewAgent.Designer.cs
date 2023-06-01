namespace BankingManagementSystem
{
    partial class ViewAgent
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
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AdmindataGridView = new System.Windows.Forms.DataGridView();
            this.RegisterAgent = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdmindataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(413, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 44);
            this.label1.TabIndex = 14;
            this.label1.Text = "View All Agents";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(33, 145);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(220, 51);
            this.UpdateBtn.TabIndex = 16;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(304, 146);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(220, 51);
            this.DeleteBtn.TabIndex = 17;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AdmindataGridView
            // 
            this.AdmindataGridView.AllowUserToAddRows = false;
            this.AdmindataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AdmindataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdmindataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AdmindataGridView.GridColor = System.Drawing.Color.White;
            this.AdmindataGridView.Location = new System.Drawing.Point(0, 286);
            this.AdmindataGridView.Name = "AdmindataGridView";
            this.AdmindataGridView.RowHeadersWidth = 62;
            this.AdmindataGridView.RowTemplate.Height = 33;
            this.AdmindataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AdmindataGridView.Size = new System.Drawing.Size(1124, 383);
            this.AdmindataGridView.TabIndex = 18;
            this.AdmindataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdmindataGridView_CellClick);
            this.AdmindataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdmindataGridView_CellContentClick);
            this.AdmindataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdmindataGridView_CellDoubleClick);
            this.AdmindataGridView.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.AdmindataGridView_CellStateChanged);
            this.AdmindataGridView.SelectionChanged += new System.EventHandler(this.AdmindataGridView_SelectionChanged);
            // 
            // RegisterAgent
            // 
            this.RegisterAgent.Location = new System.Drawing.Point(593, 145);
            this.RegisterAgent.Name = "RegisterAgent";
            this.RegisterAgent.Size = new System.Drawing.Size(220, 51);
            this.RegisterAgent.TabIndex = 19;
            this.RegisterAgent.Text = "Register Agent";
            this.RegisterAgent.UseVisualStyleBackColor = true;
            this.RegisterAgent.Click += new System.EventHandler(this.RegisterAgent_Click);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Location = new System.Drawing.Point(51, 340);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 25);
            this.Error.TabIndex = 20;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.CloseBtn.Location = new System.Drawing.Point(999, 14);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.CloseBtn.Size = new System.Drawing.Size(36, 34);
            this.CloseBtn.TabIndex = 21;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ViewAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.RegisterAgent);
            this.Controls.Add(this.AdmindataGridView);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.label1);
            this.Name = "ViewAgent";
            this.Size = new System.Drawing.Size(1124, 669);
            this.Load += new System.EventHandler(this.ViewAgent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdmindataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private DataGridView AdmindataGridView;
        private Button RegisterAgent;
        private Label Error;
        private Button CloseBtn;
    }
}
