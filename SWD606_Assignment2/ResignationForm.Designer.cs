namespace SWD606_Assignment2
{
    partial class ResignationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResignationForm));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            idLabel = new Label();
            EFLLabel = new Label();
            sendBTN = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Location = new Point(12, 19);
            label2.Name = "label2";
            label2.Size = new Size(691, 135);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(255, 164);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "Employee ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(255, 211);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 3;
            label4.Text = "Employee Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 333);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(591, 27);
            textBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 310);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 5;
            label5.Text = "Signature";
            // 
            // button1
            // 
            button1.Location = new Point(389, 452);
            button1.Name = "button1";
            button1.Size = new Size(152, 41);
            button1.TabIndex = 6;
            button1.Text = "Submit Resignation";
            button1.UseVisualStyleBackColor = true;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(373, 164);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(50, 20);
            idLabel.TabIndex = 7;
            idLabel.Text = "label1";
            // 
            // EFLLabel
            // 
            EFLLabel.AutoSize = true;
            EFLLabel.Location = new Point(391, 211);
            EFLLabel.Name = "EFLLabel";
            EFLLabel.Size = new Size(50, 20);
            EFLLabel.TabIndex = 8;
            EFLLabel.Text = "label6";
            EFLLabel.Click += EFLLabel_Click;
            // 
            // sendBTN
            // 
            sendBTN.Location = new Point(271, 389);
            sendBTN.Name = "sendBTN";
            sendBTN.Size = new Size(152, 29);
            sendBTN.TabIndex = 9;
            sendBTN.Text = "Send Resignation";
            sendBTN.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 256);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 10;
            label1.Text = "Last working day:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(319, 256);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // ResignationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 444);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(sendBTN);
            Controls.Add(EFLLabel);
            Controls.Add(idLabel);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResignationForm";
            Text = "ResignationForm";
            Load += ResignationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private Button button1;
        private Label idLabel;
        private Label EFLLabel;
        private Button sendBTN;
        private Label label1;
        private DateTimePicker dateTimePicker1;
    }
}