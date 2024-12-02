namespace SWD606_Assignment2
{
    partial class LeaveForm
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
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 43);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Details";
            // 
            // button1
            // 
            button1.Location = new Point(230, 74);
            button1.Name = "button1";
            button1.Size = new Size(284, 26);
            button1.TabIndex = 1;
            button1.Text = "Reason";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 121);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 3;
            label2.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 159);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 4;
            label3.Text = "Start";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 192);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 5;
            label4.Text = "End";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(394, 240);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(79, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "All Day";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(312, 148);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(312, 192);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(32, 293);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 10);
            label5.Name = "label5";
            label5.Size = new Size(145, 20);
            label5.TabIndex = 0;
            label5.Text = "Remaining Balances:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 40);
            label6.Name = "label6";
            label6.Size = new Size(87, 17);
            label6.TabIndex = 1;
            label6.Text = "Annual Leave:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(0, 79);
            label7.Name = "label7";
            label7.Size = new Size(70, 17);
            label7.TabIndex = 2;
            label7.Text = "Sick Leave:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(102, 40);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 3;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(101, 77);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 4;
            label9.Text = "label9";
            // 
            // button2
            // 
            button2.Location = new Point(423, 333);
            button2.Name = "button2";
            button2.Size = new Size(159, 29);
            button2.TabIndex = 11;
            button2.Text = "Submit Request";
            button2.UseVisualStyleBackColor = true;
            // 
            // LeaveForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 430);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LeaveForm";
            Text = "LeaveForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label9;
        private Label label8;
        private Button button2;
    }
}