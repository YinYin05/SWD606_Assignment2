namespace SWD606_Assignment2
{
    partial class LeaveManagement
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnReset = new Button();
            btnSearch = new Button();
            label3 = new Label();
            txtSearch = new TextBox();
            cmbSearch = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            btnLeaveApprovals = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1327, 385);
            dataGridView1.TabIndex = 0;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Cyan;
            btnReset.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnReset.Location = new Point(515, 57);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(85, 30);
            btnReset.TabIndex = 15;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Yellow;
            btnSearch.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnSearch.Location = new Point(432, 58);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(63, 29);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Go";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label3.Location = new Point(229, 61);
            label3.Name = "label3";
            label3.Size = new Size(35, 18);
            label3.TabIndex = 13;
            label3.Text = "by :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(86, 58);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(134, 27);
            txtSearch.TabIndex = 12;
            // 
            // cmbSearch
            // 
            cmbSearch.FormattingEnabled = true;
            cmbSearch.Location = new Point(268, 58);
            cmbSearch.Name = "cmbSearch";
            cmbSearch.Size = new Size(158, 28);
            cmbSearch.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label2.Location = new Point(20, 61);
            label2.Name = "label2";
            label2.Size = new Size(68, 18);
            label2.TabIndex = 10;
            label2.Text = "Search :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(550, 9);
            label1.Name = "label1";
            label1.Size = new Size(308, 27);
            label1.TabIndex = 16;
            label1.Text = "Employee Leave Balances";
            // 
            // btnLeaveApprovals
            // 
            btnLeaveApprovals.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnLeaveApprovals.Location = new Point(1165, 61);
            btnLeaveApprovals.Name = "btnLeaveApprovals";
            btnLeaveApprovals.Size = new Size(141, 29);
            btnLeaveApprovals.TabIndex = 17;
            btnLeaveApprovals.Text = "Leave Approvals";
            btnLeaveApprovals.UseVisualStyleBackColor = true;
            btnLeaveApprovals.Click += btnLeaveApprovals_Click;
            // 
            // LeaveManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1351, 527);
            Controls.Add(btnLeaveApprovals);
            Controls.Add(label1);
            Controls.Add(btnReset);
            Controls.Add(btnSearch);
            Controls.Add(label3);
            Controls.Add(txtSearch);
            Controls.Add(cmbSearch);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "LeaveManagement";
            Text = "Leave Management";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnReset;
        private Button btnSearch;
        private Label label3;
        private TextBox txtSearch;
        private ComboBox cmbSearch;
        private Label label2;
        private Label label1;
        private Button btnLeaveApprovals;
    }
}