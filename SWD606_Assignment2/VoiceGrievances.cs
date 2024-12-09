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
            InitializeComponent();
        }

        private void SendBTN_Click(object sender, EventArgs e)
        {
            try
            {
                // User Inputs
                string to = emailBox.Text;
                string subject = subjectBox.Text;
                string body = messageBox.Text;

                // Outlook Setup
                string email = "RECAS.Staff@outlook.com";
                string appPassword = "PasswordTest123@"; // Replace with an app-specific password
                string host = "smtp-mail.outlook.com";
                int port = 587;

                using (MailMessage mail = new MailMessage(email, to, subject, body))
                {
                    using (SmtpClient smtp = new SmtpClient(host, port))
                    {
                        smtp.UseDefaultCredentials = false;
                        smtp.EnableSsl = true; // Enable secure connection (TLS)
                        smtp.Credentials = new NetworkCredential(email, appPassword);

                        smtp.Send(mail);
                        MessageBox.Show("Email Sent!", "Success");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

    }
}