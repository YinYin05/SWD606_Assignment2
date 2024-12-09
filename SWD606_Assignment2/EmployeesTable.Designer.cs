namespace SWD606_Assignment2
{
    partial class EmployeesTable
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
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            btnReset = new Button();
            btnAddEmployee = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.Location = new Point(40, 25);
            label1.Name = "label1";
            label1.Size = new Size(144, 23);
            label1.TabIndex = 0;
            label1.Text = "Search Input :";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(190, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(152, 34);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Yellow;
            btnSearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnSearch.Location = new Point(385, 18);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 37);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1445, 366);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Cyan;
            btnReset.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnReset.Location = new Point(521, 18);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(110, 37);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.Fuchsia;
            btnAddEmployee.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnAddEmployee.Location = new Point(1251, 20);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(232, 37);
            btnAddEmployee.TabIndex = 0;
            btnAddEmployee.Text = "Add New Employee";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // EmployeesTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1515, 450);
            Controls.Add(btnAddEmployee);
            Controls.Add(btnReset);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmployeesTable";
            Text = "Employees Table";
            Load += EmployeesTable_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Button btnReset;
        private Button btnAddEmployee;
    }
}