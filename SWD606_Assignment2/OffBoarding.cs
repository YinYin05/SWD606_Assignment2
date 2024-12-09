using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Net;

namespace SWD606_Assignment2
{
    public partial class OffBoarding : Form
    {
        string FirtName;
    
        public OffBoarding()
        {
            InitializeComponent();
        }

      
        private void openFileBTN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the file selection dialog to allow the user to choose files
            openFileDialog.ShowDialog();
            // Loop through each file selected in the Open File Dialog
            foreach (var fileName in openFileDialog.FileNames)
                // Display the file path in the text box (fileNameTXT) for each selected file
                fileNameTXT.Text = fileName;

        }



        private void OffBoarding_Load(object sender, EventArgs e)
        {

        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            try
            {
                // Defining a pre-designated email address (recipient)
                string recipientEmail = "reca.management2024@gmail.com";

                // Define the email's subject and body (can be hardcoded or dynamic)
                string subject = "Resignation";
                string body = "This is a a resignation letter:";

                // Create the MailMessage object with sender, recipient, subject, and body
                using (MailMessage mail = new("reca.employee@gmail.com", recipientEmail, subject, body))
                using (SmtpClient smtp = new("smtp.gmail.com", 587)) // Gmail's SMTP server and port for TLS
                {
                    // Loop through each file selected in the Open File Dialog
                    foreach (var fileName in openFileDialog.FileNames)
                        // Check if the file exists on the specified path
                        if (File.Exists(fileName))
                            // Add the file as an attachment to the email
                            mail.Attachments.Add(new Attachment(fileName));


                    // Set the SMTP credentials and enable SSL encryption
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("reca.employee@gmail.com", "nmhtcnefqcguxijs"); // App password
                    smtp.EnableSsl = true;

                    // Send the email
                    smtp.Send(mail);

                    // Provide feedback to the user
                    MessageBox.Show("Email sent successfully to the predefined recipient!", "Success");
                }
            }
            catch (Exception ex)
            {
                // Handle errors and show an appropriate error message
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }
    }
}