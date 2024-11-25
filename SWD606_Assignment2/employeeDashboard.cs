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
    public partial class employeeDashboard : Form
    {
        string firstname;
        string email;
        string role;
        int id;
        SqlConnection connection;
        SqlCommand command;
        public employeeDashboard()
        {
            InitializeComponent();
        }

        private void employeeDashboard_Load(object sender, EventArgs e)
        {

            GetInfo();
        }
        void OpenConnection()
        {
            connection = new SqlConnection(@"Data Source=ASDFGHJKL123\SQLEXPRESS;Initial Catalog=SWD606;Integrated Security=True;TrustServerCertificate=True");
            connection.Open();
        }
        private void GetInfo()
        {
            firstname = UserSession.Instance.FirstName;
            labelFirstName.Text = firstname;

            email = UserSession.Instance.Email;
            labelEmail.Text = email;

            role = UserSession.Instance.Role;
            labelRole.Text = role;

            id = UserSession.Instance.ID;
            labelId.Text = id.ToString();
        }
    }
}
