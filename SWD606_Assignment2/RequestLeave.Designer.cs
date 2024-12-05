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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 26);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Reason";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 257);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 2;
            label2.Text = "Start date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 321);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 3;
            label3.Text = "End date";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(333, 362);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // datePickerStart
            // 
            datePickerStart.Checked = false;
            datePickerStart.CustomFormat = "";
            datePickerStart.Location = new Point(173, 257);
            datePickerStart.Name = "datePickerStart";
            datePickerStart.Size = new Size(250, 27);
            datePickerStart.TabIndex = 5;
            // 
            // datePickerEnd
            // 
            datePickerEnd.Location = new Point(173, 321);
            datePickerEnd.Name = "datePickerEnd";
            datePickerEnd.Size = new Size(250, 27);
            datePickerEnd.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 208);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 7;
            label4.Text = "Leave Type";
            // 
            // comboLeaveType
            // 
            comboLeaveType.FormattingEnabled = true;
            comboLeaveType.Location = new Point(171, 206);
            comboLeaveType.Name = "comboLeaveType";
            comboLeaveType.Size = new Size(252, 28);
            comboLeaveType.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 92);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 9;
            label5.Text = "Leave Credits Balance";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 124);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 10;
            label6.Text = "Annual Leave";
            // 
            // txtAnnual
            // 
            txtAnnual.Enabled = false;
            txtAnnual.Location = new Point(182, 121);
            txtAnnual.Name = "txtAnnual";
            txtAnnual.Size = new Size(125, 27);
            txtAnnual.TabIndex = 11;
            // 
            // txtSick
            // 
            txtSick.Enabled = false;
            txtSick.Location = new Point(182, 154);
            txtSick.Name = "txtSick";
            txtSick.Size = new Size(125, 27);
            txtSick.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 157);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 12;
            label7.Text = "Sick Leave";
            // 
            // txtReason
            // 
            txtReason.Location = new Point(152, 28);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(406, 27);
            txtReason.TabIndex = 14;
            // 
            // RequestLeave
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtReason);
            Controls.Add(txtSick);
            Controls.Add(label7);
            Controls.Add(txtAnnual);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboLeaveType);
            Controls.Add(label4);
            Controls.Add(datePickerEnd);
            Controls.Add(datePickerStart);
            Controls.Add(btnSubmit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RequestLeave";
            Text = "Request Leave";
            Load += RequestLeave_Load;
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
    }
}