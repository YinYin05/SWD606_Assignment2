namespace SWD606_Assignment2
{
    partial class UpdatePayroll
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
            btnCancel = new Button();
            btnSave = new Button();
            txtTotal = new TextBox();
            label10 = new Label();
            txtHourlyRate = new TextBox();
            label9 = new Label();
            txtLeave = new TextBox();
            label8 = new Label();
            txtWorkHours = new TextBox();
            label7 = new Label();
            txtTimeOut = new TextBox();
            label6 = new Label();
            txtTimeIn = new TextBox();
            label5 = new Label();
            txtDate = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(271, 475);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 51);
            btnCancel.TabIndex = 43;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            btnSave.Location = new Point(129, 475);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 51);
            btnSave.TabIndex = 42;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtTotal.Location = new Point(174, 411);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(272, 32);
            txtTotal.TabIndex = 41;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label10.Location = new Point(49, 414);
            label10.Name = "label10";
            label10.Size = new Size(55, 23);
            label10.TabIndex = 40;
            label10.Text = "Total";
            // 
            // txtHourlyRate
            // 
            txtHourlyRate.Enabled = false;
            txtHourlyRate.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtHourlyRate.Location = new Point(174, 374);
            txtHourlyRate.Name = "txtHourlyRate";
            txtHourlyRate.Size = new Size(272, 32);
            txtHourlyRate.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label9.Location = new Point(49, 377);
            label9.Name = "label9";
            label9.Size = new Size(122, 23);
            label9.TabIndex = 38;
            label9.Text = "Hourly Rate";
            // 
            // txtLeave
            // 
            txtLeave.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtLeave.Location = new Point(174, 338);
            txtLeave.Name = "txtLeave";
            txtLeave.Size = new Size(272, 32);
            txtLeave.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label8.Location = new Point(49, 341);
            label8.Name = "label8";
            label8.Size = new Size(69, 23);
            label8.TabIndex = 36;
            label8.Text = "Leave";
            // 
            // txtWorkHours
            // 
            txtWorkHours.Enabled = false;
            txtWorkHours.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtWorkHours.Location = new Point(174, 302);
            txtWorkHours.Name = "txtWorkHours";
            txtWorkHours.Size = new Size(272, 32);
            txtWorkHours.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label7.Location = new Point(49, 305);
            label7.Name = "label7";
            label7.Size = new Size(119, 23);
            label7.TabIndex = 34;
            label7.Text = "Work Hours";
            // 
            // txtTimeOut
            // 
            txtTimeOut.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtTimeOut.Location = new Point(174, 265);
            txtTimeOut.Name = "txtTimeOut";
            txtTimeOut.Size = new Size(272, 32);
            txtTimeOut.TabIndex = 33;
            txtTimeOut.TextChanged += txtTimeOut_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label6.Location = new Point(49, 268);
            label6.Name = "label6";
            label6.Size = new Size(99, 23);
            label6.TabIndex = 32;
            label6.Text = "Time OUT";
            // 
            // txtTimeIn
            // 
            txtTimeIn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtTimeIn.Location = new Point(174, 229);
            txtTimeIn.Name = "txtTimeIn";
            txtTimeIn.Size = new Size(272, 32);
            txtTimeIn.TabIndex = 31;
            txtTimeIn.TextChanged += txtTimeIn_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.Location = new Point(49, 232);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 30;
            label5.Text = "Time IN";
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtDate.Location = new Point(174, 193);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(272, 32);
            txtDate.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.Location = new Point(49, 196);
            label4.Name = "label4";
            label4.Size = new Size(56, 23);
            label4.TabIndex = 28;
            label4.Text = "Date";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtLastName.Location = new Point(174, 156);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(272, 32);
            txtLastName.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.Location = new Point(49, 159);
            label3.Name = "label3";
            label3.Size = new Size(113, 23);
            label3.TabIndex = 26;
            label3.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtFirstName.Location = new Point(174, 119);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(272, 32);
            txtFirstName.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(50, 122);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 24;
            label2.Text = "First Name";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtID.Location = new Point(174, 82);
            txtID.Name = "txtID";
            txtID.Size = new Size(272, 32);
            txtID.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.Location = new Point(50, 85);
            label1.Name = "label1";
            label1.Size = new Size(30, 23);
            label1.TabIndex = 22;
            label1.Text = "ID";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTotal);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtHourlyRate);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtLeave);
            panel1.Controls.Add(txtDate);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtWorkHours);
            panel1.Controls.Add(txtTimeIn);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtTimeOut);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 560);
            panel1.TabIndex = 44;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(146, 19);
            label11.Name = "label11";
            label11.Size = new Size(212, 34);
            label11.TabIndex = 44;
            label11.Text = "Update Payroll";
            // 
            // UpdatePayroll
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(513, 582);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            Name = "UpdatePayroll";
            Text = "Update Payroll";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox txtTotal;
        private Label label10;
        private TextBox txtHourlyRate;
        private Label label9;
        private TextBox txtLeave;
        private Label label8;
        private TextBox txtWorkHours;
        private Label label7;
        private TextBox txtTimeOut;
        private Label label6;
        private TextBox txtTimeIn;
        private Label label5;
        private TextBox txtDate;
        private Label label4;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private Panel panel1;
        private Label label11;
    }
}