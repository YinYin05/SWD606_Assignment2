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
            ((System.ComponentModel.ISupportInitialize)dgvLeaveApprovals).BeginInit();
            SuspendLayout();
            // 
            // dgvLeaveApprovals
            // 
            dgvLeaveApprovals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLeaveApprovals.Location = new Point(40, 94);
            dgvLeaveApprovals.Name = "dgvLeaveApprovals";
            dgvLeaveApprovals.RowHeadersWidth = 51;
            dgvLeaveApprovals.Size = new Size(1744, 527);
            dgvLeaveApprovals.TabIndex = 0;
            // 
            // LeaveApprovals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1829, 653);
            Controls.Add(dgvLeaveApprovals);
            Name = "LeaveApprovals";
            Text = "LeaveApprovals";
            Load += LeaveApprovals_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLeaveApprovals).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLeaveApprovals;
    }
}