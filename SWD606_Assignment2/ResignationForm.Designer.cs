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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 19);
            label1.Name = "label1";
            label1.Size = new Size(384, 50);
            label1.TabIndex = 0;
            label1.Text = "Employee Resignation";
            // 
            // label2
            // 
            label2.Location = new Point(55, 88);
            label2.Name = "label2";
            label2.Size = new Size(823, 186);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 274);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 2;
            label3.Text = "Employee ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 322);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 3;
            label4.Text = "Employee Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 386);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(591, 27);
            textBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(129, 363);
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
            // ResignationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 430);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResignationForm";
            Text = "ResignationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private Button button1;
    }
}