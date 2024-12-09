namespace SWD606_Assignment2
{
    partial class PayrollTable
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
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePickerFrom = new DateTimePicker();
            dateTimePickerTo = new DateTimePicker();
            btnFilter = new Button();
            btnReset = new Button();
            btnResetFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 249);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1105, 434);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 98);
            label1.Name = "label1";
            label1.Size = new Size(146, 23);
            label1.TabIndex = 1;
            label1.Text = "Employee ID :";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(164, 98);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 26);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Yellow;
            btnSearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnSearch.Location = new Point(300, 95);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 40);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(570, 99);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 4;
            label2.Text = "Filter Dates :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.Location = new Point(679, 99);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 5;
            label3.Text = "From :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.Location = new Point(679, 141);
            label4.Name = "label4";
            label4.Size = new Size(43, 23);
            label4.TabIndex = 6;
            label4.Text = "To :";
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            dateTimePickerFrom.Location = new Point(746, 96);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(251, 26);
            dateTimePickerFrom.TabIndex = 7;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            dateTimePickerTo.Location = new Point(747, 140);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(250, 26);
            dateTimePickerTo.TabIndex = 8;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(255, 192, 128);
            btnFilter.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnFilter.Location = new Point(747, 173);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(110, 40);
            btnFilter.TabIndex = 9;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Cyan;
            btnReset.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnReset.Location = new Point(416, 95);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(110, 40);
            btnReset.TabIndex = 10;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnResetFilter
            // 
            btnResetFilter.BackColor = Color.FromArgb(255, 128, 0);
            btnResetFilter.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnResetFilter.Location = new Point(887, 172);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(110, 40);
            btnResetFilter.TabIndex = 11;
            btnResetFilter.Text = "Reset";
            btnResetFilter.UseVisualStyleBackColor = false;
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // PayrollTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1129, 736);
            Controls.Add(btnResetFilter);
            Controls.Add(btnReset);
            Controls.Add(btnFilter);
            Controls.Add(dateTimePickerTo);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PayrollTable";
            Text = "Payroll Table";
            Load += PayrollTable_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private Button btnFilter;
        private Button btnReset;
        private Button btnResetFilter;
    }
}