﻿namespace SWD606_Assignment2
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
            label2 = new Label();
            openFileBTN = new LinkLabel();
            fileNameTXT = new Label();
            openFileDialog = new OpenFileDialog();
            submitBTN = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 26);
            label2.Name = "label2";
            label2.Size = new Size(950, 133);
            label2.TabIndex = 12;
            label2.Text = resources.GetString("label2.Text");
            // 
            // openFileBTN
            // 
            openFileBTN.AutoSize = true;
            openFileBTN.Location = new Point(47, 201);
            openFileBTN.Name = "openFileBTN";
            openFileBTN.Size = new Size(153, 20);
            openFileBTN.TabIndex = 23;
            openFileBTN.TabStop = true;
            openFileBTN.Text = "Attach Resume Letter:";
            openFileBTN.LinkClicked += openFileBTN_LinkClicked;
            // 
            // fileNameTXT
            // 
            fileNameTXT.BorderStyle = BorderStyle.FixedSingle;
            fileNameTXT.FlatStyle = FlatStyle.Flat;
            fileNameTXT.Location = new Point(47, 230);
            fileNameTXT.Name = "fileNameTXT";
            fileNameTXT.Size = new Size(325, 65);
            fileNameTXT.TabIndex = 24;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // submitBTN
            // 
            submitBTN.BackColor = Color.WhiteSmoke;
            submitBTN.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submitBTN.Location = new Point(426, 363);
            submitBTN.Name = "submitBTN";
            submitBTN.Size = new Size(147, 45);
            submitBTN.TabIndex = 25;
            submitBTN.Text = "Send Resignation";
            submitBTN.UseVisualStyleBackColor = false;
            submitBTN.Click += submitBTN_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(783, 389);
            label8.Name = "label8";
            label8.Size = new Size(221, 28);
            label8.TabIndex = 28;
            label8.Text = "Employee Resignation";
            // 
            // OffBoarding
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1016, 444);
            Controls.Add(label8);
            Controls.Add(submitBTN);
            Controls.Add(fileNameTXT);
            Controls.Add(openFileBTN);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OffBoarding";
            Text = "OffBoarding";
            Load += OffBoarding_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private LinkLabel openFileBTN;
        private Label fileNameTXT;
        private OpenFileDialog openFileDialog;
        private Button submitBTN;
        private Label label8;
    }
}