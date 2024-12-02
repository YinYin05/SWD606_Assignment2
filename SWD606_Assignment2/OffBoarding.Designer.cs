namespace SWD606_Assignment2
{
    partial class OffBoarding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OffBoarding));
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            sendBTN = new Button();
            EFLLabel = new Label();
            idLabel = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(362, 263);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 263);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 20;
            label1.Text = "Last working day:";
            // 
            // sendBTN
            // 
            sendBTN.Location = new Point(314, 396);
            sendBTN.Name = "sendBTN";
            sendBTN.Size = new Size(152, 29);
            sendBTN.TabIndex = 19;
            sendBTN.Text = "Send Resignation";
            sendBTN.UseVisualStyleBackColor = true;
            // 
            // EFLLabel
            // 
            EFLLabel.AutoSize = true;
            EFLLabel.Location = new Point(434, 218);
            EFLLabel.Name = "EFLLabel";
            EFLLabel.Size = new Size(50, 20);
            EFLLabel.TabIndex = 18;
            EFLLabel.Text = "label6";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(416, 171);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(50, 20);
            idLabel.TabIndex = 17;
            idLabel.Text = "label1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(112, 317);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 16;
            label5.Text = "Signature";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 340);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(591, 27);
            textBox1.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(298, 218);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 14;
            label4.Text = "Employee Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(298, 171);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 13;
            label3.Text = "Employee ID:";
            // 
            // label2
            // 
            label2.Location = new Point(55, 26);
            label2.Name = "label2";
            label2.Size = new Size(691, 135);
            label2.TabIndex = 12;
            label2.Text = resources.GetString("label2.Text");
            // 
            // OffBoarding
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(sendBTN);
            Controls.Add(EFLLabel);
            Controls.Add(idLabel);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "OffBoarding";
            Text = "OffBoarding";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Button sendBTN;
        private Label EFLLabel;
        private Label idLabel;
        private Label label5;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}