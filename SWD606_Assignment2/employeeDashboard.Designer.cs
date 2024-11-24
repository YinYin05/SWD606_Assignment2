namespace SWD606_Assignment2
{
    partial class employeeDashboard
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
            Testing = new CheckBox();
            SuspendLayout();
            // 
            // Testing
            // 
            Testing.AutoSize = true;
            Testing.Location = new Point(348, 195);
            Testing.Name = "Testing";
            Testing.Size = new Size(101, 24);
            Testing.TabIndex = 0;
            Testing.Text = "checkBox1";
            Testing.UseVisualStyleBackColor = true;
            // 
            // employeeDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Testing);
            Name = "employeeDashboard";
            Text = "employeeDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox Testing;
    }
}