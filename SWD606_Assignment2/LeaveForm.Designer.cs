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
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 44);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Details";
            // 
            // button1
            // 
            button1.Location = new Point(328, 75);
            button1.Name = "button1";
            button1.Size = new Size(284, 26);
            button1.TabIndex = 1;
            button1.Text = "Reason";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(357, 120);
            button2.Name = "button2";
            button2.Size = new Size(229, 36);
            button2.TabIndex = 2;
            button2.Text = "View Balanaces:";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 234);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 3;
            label2.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 272);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 4;
            label3.Text = "Start";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 305);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 5;
            label4.Text = "End";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(449, 353);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(79, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "All Day";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(367, 261);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(367, 305);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(419, 434);
            button3.Name = "button3";
            button3.Size = new Size(167, 29);
            button3.TabIndex = 10;
            button3.Text = "Apply Leave";
            button3.UseVisualStyleBackColor = true;
            // 
            // LeaveForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 430);
            Controls.Add(button3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LeaveForm";
            Text = "LeaveForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button3;
    }
}