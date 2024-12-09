namespace SWD606_Assignment2
{
    partial class VoiceGrievances
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
            SendBTN = new Button();
            label1 = new Label();
            messageBox = new TextBox();
            subjectBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // SendBTN
            // 
            SendBTN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SendBTN.Location = new Point(490, 377);
            SendBTN.Name = "SendBTN";
            SendBTN.Size = new Size(95, 35);
            SendBTN.TabIndex = 0;
            SendBTN.Text = "Send Email";
            SendBTN.UseVisualStyleBackColor = true;
            SendBTN.Click += SendBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(294, 206);
            label1.Name = "label1";
            label1.Size = new Size(107, 17);
            label1.TabIndex = 2;
            label1.Text = "Message Box:";
            // 
            // messageBox
            // 
            messageBox.Location = new Point(294, 229);
            messageBox.Multiline = true;
            messageBox.Name = "messageBox";
            messageBox.Size = new Size(496, 113);
            messageBox.TabIndex = 3;
            messageBox.Tag = "";
            messageBox.Text = "\r\n\r\n  ";
            // 
            // subjectBox
            // 
            subjectBox.Location = new Point(294, 155);
            subjectBox.Name = "subjectBox";
            subjectBox.Size = new Size(261, 27);
            subjectBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(294, 132);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 5;
            label2.Text = "Subject:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(294, 48);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 7;
            label3.Text = "To:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(791, 397);
            label4.Name = "label4";
            label4.Size = new Size(213, 28);
            label4.TabIndex = 9;
            label4.Text = "Employee Greivances";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(294, 77);
            label5.Name = "label5";
            label5.Size = new Size(244, 20);
            label5.TabIndex = 10;
            label5.Text = "reca.management2024@gmail.com";
            // 
            // VoiceGrievances
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1016, 444);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(subjectBox);
            Controls.Add(messageBox);
            Controls.Add(label1);
            Controls.Add(SendBTN);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VoiceGrievances";
            Text = " ";
            Load += VoiceGrievances_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SendBTN;
        private Label label1;
        private TextBox messageBox;
        private TextBox subjectBox;
        private Label label2;
        //private MaskedTextBox managerEmailBox;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}