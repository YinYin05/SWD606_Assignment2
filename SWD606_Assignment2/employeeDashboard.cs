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
        string leavestatus;
        string address;
        string lastname;
        string phone;
        decimal hourlyrate;

        SqlConnection connection;
        SqlCommand command;

        public employeeDashboard()
        {
            InitializeComponent();
        }
        //employees can use the system to check their leave status,
        //view salary details, yearly holiday list, and for voicing grievances or resigning.
        private void employeeDashboard_Load(object sender, EventArgs e)
        {
            OpenConnection();
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
            labelFirstName.Text = "First name: " + firstname;

            email = UserSession.Instance.Email;
            labelEmail.Text = "Email: " + email;

            role = UserSession.Instance.Role;
            labelRole.Text = "Role: " + role;

            id = UserSession.Instance.ID;
            labelId.Text = "Id: " + id.ToString();

            //leave status not yet implemented
            //leavestatus = UserSession.Instance.LeaveStatus;
            //labelLeaveStatus.Text = "Leave status: " + leavestatus;

            string query = "Select Address from Employees where ID = " + id;
            command = new SqlCommand(query, connection);
            address = (string)command.ExecuteScalar();
            labelAddress.Text = "Address: " + address;

            query = "Select LastName from Employees where ID = " + id;
            command = new SqlCommand (query, connection);
            lastname = (string)command.ExecuteScalar();
            labelLastName.Text = "Last name: " + lastname;

            query = "Select Phone from Employees where ID = " + id;
            command = new SqlCommand(query, connection);
            phone = (string)command.ExecuteScalar();
            labelPhone.Text = "Phone: " + phone;

            query = "Select HourlyRate from Employees where ID = " + id;
            command = new SqlCommand(query, connection);
            hourlyrate = (decimal)command.ExecuteScalar();
            labelHourlyRate.Text = "Hourly rate: " + hourlyrate;
        }

        private void buttonComplain_Click(object sender, EventArgs e)
        {
            
        }
    }
}
