using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWD606_Assignment2
{
    public partial class AccountInformation : Form
    {
        SqlConnection connection;

        public AccountInformation()
        {
            InitializeComponent();
        }

        private void AccountInformation_Load(object sender, EventArgs e)
        {
            labelName.Text = "Name: " + UserSession.Instance.FirstName + " " + UserSession.Instance.LastName;
            labelEmail.Text = "Email: " + UserSession.Instance.Email;

        }
    }
}
