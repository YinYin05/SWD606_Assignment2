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
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(501, 389);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 43;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(384, 389);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 42;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(293, 340);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(236, 27);
            txtTotal.TabIndex = 41;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(206, 339);
            label10.Name = "label10";
            label10.Size = new Size(42, 20);
            label10.TabIndex = 40;
            label10.Text = "Total";
            // 
            // txtHourlyRate
            // 
            txtHourlyRate.Enabled = false;
            txtHourlyRate.Location = new Point(293, 307);
            txtHourlyRate.Name = "txtHourlyRate";
            txtHourlyRate.Size = new Size(236, 27);
            txtHourlyRate.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(206, 306);
            label9.Name = "label9";
            label9.Size = new Size(87, 20);
            label9.TabIndex = 38;
            label9.Text = "Hourly Rate";
            // 
            // txtLeave
            // 
            txtLeave.Location = new Point(293, 274);
            txtLeave.Name = "txtLeave";
            txtLeave.Size = new Size(236, 27);
            txtLeave.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(206, 273);
            label8.Name = "label8";
            label8.Size = new Size(47, 20);
            label8.TabIndex = 36;
            label8.Text = "Leave";
            // 
            // txtWorkHours
            // 
            txtWorkHours.Enabled = false;
            txtWorkHours.Location = new Point(293, 241);
            txtWorkHours.Name = "txtWorkHours";
            txtWorkHours.Size = new Size(236, 27);
            txtWorkHours.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(206, 240);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 34;
            label7.Text = "Work Hours";
            // 
            // txtTimeOut
            // 
            txtTimeOut.Location = new Point(293, 208);
            txtTimeOut.Name = "txtTimeOut";
            txtTimeOut.Size = new Size(236, 27);
            txtTimeOut.TabIndex = 33;
            txtTimeOut.TextChanged += txtTimeOut_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(206, 207);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 32;
            label6.Text = "Time OUT";
            // 
            // txtTimeIn
            // 
            txtTimeIn.Location = new Point(293, 175);
            txtTimeIn.Name = "txtTimeIn";
            txtTimeIn.Size = new Size(236, 27);
            txtTimeIn.TabIndex = 31;
            txtTimeIn.TextChanged += txtTimeIn_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(206, 174);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 30;
            label5.Text = "Time IN";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(293, 142);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(236, 27);
            txtDate.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(206, 141);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 28;
            label4.Text = "Date";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(293, 100);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(236, 27);
            txtLastName.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 99);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 26;
            label3.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(293, 67);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(236, 27);
            txtFirstName.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 66);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 24;
            label2.Text = "First Name";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(293, 34);
            txtID.Name = "txtID";
            txtID.Size = new Size(236, 27);
            txtID.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 33);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 22;
            label1.Text = "ID";
            // 
            // UpdatePayroll
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtTotal);
            Controls.Add(label10);
            Controls.Add(txtHourlyRate);
            Controls.Add(label9);
            Controls.Add(txtLeave);
            Controls.Add(label8);
            Controls.Add(txtWorkHours);
            Controls.Add(label7);
            Controls.Add(txtTimeOut);
            Controls.Add(label6);
            Controls.Add(txtTimeIn);
            Controls.Add(label5);
            Controls.Add(txtDate);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "UpdatePayroll";
            Text = "UpdatePayroll";
            ResumeLayout(false);
            PerformLayout();
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
    }
}