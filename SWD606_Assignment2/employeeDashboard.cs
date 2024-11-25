using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        string FirstName;
        string Email;
        string Role;
        int id;
        string LeaveStatus;
        string Address;
        string LastName;
        string Phone;
        decimal HourlyRate;

        SqlCommand command;
        SqlConnection connection;
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
            string connectionstring = ConfigurationManager.ConnectionStrings["databaseConnect"].ConnectionString;
            connection = new SqlConnection(connectionstring);
            connection.Open();
        }
        private void GetInfo()
        {
            FirstName = UserSession.Instance.FirstName;
            labelFirstName.Text = "First name: " + FirstName;

            Email = UserSession.Instance.Email;
            labelEmail.Text = "Email: " + Email;

            Role = UserSession.Instance.Role;
            labelRole.Text = "Role: " + Role;

            id = UserSession.Instance.ID;
            labelId.Text = "Id: " + id.ToString();

            //leave status not yet implemented
            //leavestatus = UserSession.Instance.LeaveStatus;
            //labelLeaveStatus.Text = "Leave status: " + leavestatus;
           string query = "Select Address from Employees where ID = " + id;
            command = new SqlCommand(query, connection);
            Address = (string)command.ExecuteScalar();
            labelAddress.Text = "Address: " + Address;

            query = "Select LastName from Employees where ID = " + id;
            command = new SqlCommand (query, connection);
            LastName = (string)command.ExecuteScalar();
            labelLastName.Text = "Last name: " + LastName;

            query = "Select Phone from Employees where ID = " + id;
            command = new SqlCommand(query, connection);
            Phone = (string)command.ExecuteScalar();
            labelPhone.Text = "Phone: " + Phone;

            query = "Select HourlyRate from Employees where ID = " + id;
            command = new SqlCommand(query, connection);
            HourlyRate = (decimal)command.ExecuteScalar();
            labelHourlyRate.Text = "Hourly rate: " + HourlyRate;
        }
        private void buttonComplain_Click(object sender, EventArgs e)
        {
            
        }
    }
}
