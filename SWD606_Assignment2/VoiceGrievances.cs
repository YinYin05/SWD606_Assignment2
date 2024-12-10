using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWD606_Assignment2
{
    public partial class VoiceGrievances : Form
    {
        public VoiceGrievances()
        {
            //initalizing form coponents
            InitializeComponent();
        }

        private void SendBTN_Click(object sender, EventArgs e)
        {
            // Defining a pre-designated email address (recipient)
            string recipientEmail = "reca.management2024@gmail.com";

            // Create a new MailMessage object with the sender, recipient, subject, and body
            using (MailMessage mail = new("reca.employee@gmail.com", recipientEmail, subjectBox.Text, messageBox.Text))
            // Create an SmtpClient object to handle email sending via Gmail's SMTP server
            using (SmtpClient smtp = new("smtp.gmail.com", 587)) // "smtp.gmail.com" is Gmail's SMTP server and port 587 is for TLS
            {
                // Disable default credentials and specify custom credentials (email and app password)
                smtp.UseDefaultCredentials = false;
                // Use a NetworkCredential object for authentication (app-specific password used here for Gmail)
                smtp.Credentials = new NetworkCredential("reca.employee@gmail.com", "nmhtcnefqcguxijs");
                // Enable SSL/TLS encryption for secure email communication
                smtp.EnableSsl = true;
                // Send the email using the configured MailMessage and SmtpClient
                smtp.Send(mail);
                // Provide feedback to the user
                MessageBox.Show("We will return back to you shortly.", "Email sent successfully to management!");

                subjectBox.Text = string.Empty;
                messageBox.Text = string.Empty;
            }
        }

        private void VoiceGrievances_Load(object sender, EventArgs e)
        {

        }
    }
}