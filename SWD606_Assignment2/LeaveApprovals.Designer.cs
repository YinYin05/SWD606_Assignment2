﻿namespace SWD606_Assignment2
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
            dgvLeaveApprovals.BackgroundColor = SystemColors.Control;
            dgvLeaveApprovals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLeaveApprovals.Location = new Point(40, 94);
            dgvLeaveApprovals.Name = "dgvLeaveApprovals";
            dgvLeaveApprovals.RowHeadersWidth = 51;
            dgvLeaveApprovals.Size = new Size(1744, 527);
            dgvLeaveApprovals.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(801, 3);
            label1.Name = "label1";
            label1.Size = new Size(289, 34);
            label1.TabIndex = 1;
            label1.Text = "Leave Approvals List";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(46, 54);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 2;
            label2.Text = "Search :";
            // 
            // cmbSearch
            // 
            cmbSearch.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSearch.FormattingEnabled = true;
            cmbSearch.Location = new Point(363, 51);
            cmbSearch.Name = "cmbSearch";
            cmbSearch.Size = new Size(189, 31);
            cmbSearch.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtSearch.Location = new Point(138, 51);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(166, 32);
            txtSearch.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.Location = new Point(312, 54);
            label3.Name = "label3";
            label3.Size = new Size(47, 23);
            label3.TabIndex = 5;
            label3.Text = "by :";
            label3.Click += label3_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Yellow;
            btnSearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnSearch.Location = new Point(574, 48);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 39);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Go";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cmbSortBy
            // 
            cmbSortBy.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSortBy.FormattingEnabled = true;
            cmbSortBy.Location = new Point(1574, 52);
            cmbSortBy.Name = "cmbSortBy";
            cmbSortBy.Size = new Size(195, 31);
            cmbSortBy.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.Location = new Point(1481, 54);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 8;
            label4.Text = "Sort By :";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Cyan;
            btnReset.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnReset.Location = new Point(682, 47);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(106, 40);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // LeaveApprovals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1829, 653);
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