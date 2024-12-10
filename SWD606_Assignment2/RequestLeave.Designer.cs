namespace SWD606_Assignment2
{
    partial class RequestLeave
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
            label2 = new Label();
            label3 = new Label();
            btnSubmit = new Button();
            datePickerStart = new DateTimePicker();
            datePickerEnd = new DateTimePicker();
            label4 = new Label();
            comboLeaveType = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            txtAnnual = new TextBox();
            txtSick = new TextBox();
            label7 = new Label();
            txtReason = new TextBox();
            label8 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 85);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 0;
            label1.Text = "Reason";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(120, 213);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 2;
            label2.Text = "Start date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(121, 270);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 3;
            label3.Text = "End date";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.WhiteSmoke;
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(486, 403);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // datePickerStart
            // 
            datePickerStart.Checked = false;
            datePickerStart.CustomFormat = "";
            datePickerStart.Location = new Point(206, 206);
            datePickerStart.Name = "datePickerStart";
            datePickerStart.Size = new Size(250, 27);
            datePickerStart.TabIndex = 5;
            datePickerStart.ValueChanged += datePickerStart_ValueChanged;
            // 
            // datePickerEnd
            // 
            datePickerEnd.Location = new Point(206, 266);
            datePickerEnd.Name = "datePickerEnd";
            datePickerEnd.Size = new Size(250, 27);
            datePickerEnd.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(105, 139);
            label4.Name = "label4";
            label4.Size = new Size(92, 17);
            label4.TabIndex = 7;
            label4.Text = "Leave Type";
            // 
            // comboLeaveType
            // 
            comboLeaveType.FormattingEnabled = true;
            comboLeaveType.Location = new Point(216, 134);
            comboLeaveType.Name = "comboLeaveType";
            comboLeaveType.Size = new Size(252, 28);
            comboLeaveType.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(75, 23);
            label5.Name = "label5";
            label5.Size = new Size(160, 20);
            label5.TabIndex = 9;
            label5.Text = "Leave Credits Balance";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(5, 66);
            label6.Name = "label6";
            label6.Size = new Size(156, 20);
            label6.TabIndex = 10;
            label6.Text = "Annual Leave (Hours)";
            // 
            // txtAnnual
            // 
            txtAnnual.Enabled = false;
            txtAnnual.Location = new Point(174, 63);
            txtAnnual.Name = "txtAnnual";
            txtAnnual.Size = new Size(125, 27);
            txtAnnual.TabIndex = 11;
            // 
            // txtSick
            // 
            txtSick.Enabled = false;
            txtSick.Location = new Point(174, 96);
            txtSick.Name = "txtSick";
            txtSick.Size = new Size(125, 27);
            txtSick.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(11, 99);
            label7.Name = "label7";
            label7.Size = new Size(134, 20);
            label7.TabIndex = 12;
            label7.Text = "Sick Leave (Hours)";
            // 
            // txtReason
            // 
            txtReason.Location = new Point(96, 80);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(406, 27);
            txtReason.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(840, 407);
            label8.Name = "label8";
            label8.Size = new Size(164, 28);
            label8.TabIndex = 15;
            label8.Text = "Employee Leave";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtAnnual);
            panel1.Controls.Add(txtSick);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(631, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 164);
            panel1.TabIndex = 16;
            // 
            // RequestLeave
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1016, 444);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(txtReason);
            Controls.Add(comboLeaveType);
            Controls.Add(label4);
            Controls.Add(datePickerEnd);
            Controls.Add(datePickerStart);
            Controls.Add(btnSubmit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RequestLeave";
            Text = "Request Leave";
            Load += RequestLeave_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSubmit;
        private DateTimePicker datePickerStart;
        private DateTimePicker datePickerEnd;
        private Label label4;
        private ComboBox comboLeaveType;
        private Label label5;
        private Label label6;
        private TextBox txtAnnual;
        private TextBox txtSick;
        private Label label7;
        private TextBox txtReason;
        private Label label8;
        private Panel panel1;
    }
}