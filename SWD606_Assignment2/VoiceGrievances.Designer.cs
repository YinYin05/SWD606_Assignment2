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
            emailBox = new TextBox();
            SuspendLayout();
            // 
            // Send
            // 
            SendBTN.Location = new Point(344, 382);
            SendBTN.Name = "Send";
            SendBTN.Size = new Size(94, 29);
            SendBTN.TabIndex = 0;
            SendBTN.Text = "Send Email";
            SendBTN.UseVisualStyleBackColor = true;
            SendBTN.Click += SendBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 205);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 2;
            label1.Text = "Message Box:";
            // 
            // messageBox
            // 
            messageBox.Location = new Point(147, 228);
            messageBox.Multiline = true;
            messageBox.Name = "messageBox";
            messageBox.Size = new Size(496, 113);
            messageBox.TabIndex = 3;
            // 
            // subjectBox
            // 
            subjectBox.Location = new Point(147, 154);
            subjectBox.Name = "subjectBox";
            subjectBox.Size = new Size(261, 27);
            subjectBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 131);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 5;
            label2.Text = "Subject:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 47);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 7;
            label3.Text = "To:";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(147, 70);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(261, 27);
            emailBox.TabIndex = 8;
            // 
            // VoiceGrievances
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(emailBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(subjectBox);
            Controls.Add(messageBox);
            Controls.Add(label1);
            Controls.Add(SendBTN);
            Name = "VoiceGrievances";
            Text = "VoiceGrievances";
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
        private TextBox emailBox;
    }
}