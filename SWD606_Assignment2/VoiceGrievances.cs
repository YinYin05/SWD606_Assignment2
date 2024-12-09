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
            using(MailMessage mail = new("reca.employee@gmail.com", emailBox.Text, subjectBox.Text, messageBox.Text))
            using (SmtpClient smtp = new("smtp.gmail.com", 587))
            {
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("reca.employee@gmail.com", "nmhtcnefqcguxijs");
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
        }

    }
}