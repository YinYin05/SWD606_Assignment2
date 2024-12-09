namespace SWD606_Assignment2
{
    partial class LeaveApprovals
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
            dgvLeaveApprovals = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            cmbSearch = new ComboBox();
            txtSearch = new TextBox();
            label3 = new Label();
            btnSearch = new Button();
            cmbSortBy = new ComboBox();
            label4 = new Label();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLeaveApprovals).BeginInit();
            SuspendLayout();
            // 
            // dgvLeaveApprovals
            // 
            dgvLeaveApprovals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLeaveApprovals.Location = new Point(116, 126);
            dgvLeaveApprovals.Name = "dgvLeaveApprovals";
            dgvLeaveApprovals.RowHeadersWidth = 51;
            dgvLeaveApprovals.Size = new Size(799, 290);
            dgvLeaveApprovals.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(845, 449);
            label1.Name = "label1";
            label1.Size = new Size(186, 25);
            label1.TabIndex = 1;
            label1.Text = "Leave Approvals List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 57);
            label2.Name = "label2";
            label2.Size = new Size(67, 17);
            label2.TabIndex = 2;
            label2.Text = "Search :";
            // 
            // cmbSearch
            // 
            cmbSearch.FormattingEnabled = true;
            cmbSearch.Location = new Point(298, 54);
            cmbSearch.Name = "cmbSearch";
            cmbSearch.Size = new Size(158, 28);
            cmbSearch.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(116, 54);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(134, 27);
            txtSearch.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(259, 57);
            label3.Name = "label3";
            label3.Size = new Size(37, 17);
            label3.TabIndex = 5;
            label3.Text = "by :";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(462, 54);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(63, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Go";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cmbSortBy
            // 
            cmbSortBy.FormattingEnabled = true;
            cmbSortBy.Location = new Point(1574, 52);
            cmbSortBy.Name = "cmbSortBy";
            cmbSortBy.Size = new Size(195, 28);
            cmbSortBy.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1499, 55);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 8;
            label4.Text = "Sort By :";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(545, 53);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(85, 30);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // LeaveApprovals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1043, 483);
            Controls.Add(btnReset);
            Controls.Add(label4);
            Controls.Add(cmbSortBy);
            Controls.Add(btnSearch);
            Controls.Add(label3);
            Controls.Add(txtSearch);
            Controls.Add(cmbSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvLeaveApprovals);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LeaveApprovals";
            Text = "Leave Approvals";
            Load += LeaveApprovals_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLeaveApprovals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLeaveApprovals;
        private Label label1;
        private Label label2;
        private ComboBox cmbSearch;
        private TextBox txtSearch;
        private Label label3;
        private Button btnSearch;
        private ComboBox cmbSortBy;
        private Label label4;
        private Button btnReset;
    }
}