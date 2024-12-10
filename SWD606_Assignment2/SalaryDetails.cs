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
    public partial class SalaryDetails : Form
    {
        SqlConnection connection;
        SqlCommand command;
        int ID = UserSession.Instance.ID;
        public SalaryDetails()
        {
            InitializeComponent();
        }

        private void SalaryDetails_Load(object sender, EventArgs e)
        {
            OpenConnection();

        }
        void OpenConnection()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["databaseConnect"].ConnectionString;
            connection = new SqlConnection(connectionstring);
            connection.Open();
            GetInfo();
        }
        void GetInfo()
        {
            string query = $"SELECT * FROM Payroll WHERE ID = '{ID}'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView1.DataSource = data;
/*            try
            {
                string query = $"SELECT FirstName FROM Payroll WHERE ID = '{ID}' AND Date = '{dateTimePicker1.Value}'";
                command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                string firstName = (string)command.ExecuteScalar();
                labelFirstName.Text = firstName;

                query = $"SELECT LastName FROM Payroll WHERE ID = '{ID}' AND Date = '{dateTimePicker1.Value}'";
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                reader.Close();
                string lastName = (string)command.ExecuteScalar();
                labelLastName.Text = lastName;

                query = $"SELECT Date FROM Payroll WHERE ID = '{ID}' AND Date = '{dateTimePicker1.Value}'";
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                reader.Close();
                DateTime dateTime = (DateTime)command.ExecuteScalar();
                labelDate.Text = dateTime.ToString("MM/dd/yyyy");

                query = $"SELECT TimeIN FROM Payroll WHERE ID = '{ID}' AND Date = '{dateTimePicker1.Value}'";
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                reader.Close();
                TimeSpan timeIn = (TimeSpan)command.ExecuteScalar();
                labelTimeIn.Text = timeIn.ToString();

                query = $"SELECT TimeOUT FROM Payroll WHERE ID = '{ID}' AND Date = '{dateTimePicker1.Value}'";
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                reader.Close();
                TimeSpan timeOUT = (TimeSpan)command.ExecuteScalar();
                labelTimeOut.Text = timeOUT.ToString();

                query = $"SELECT WorkHours FROM Payroll WHERE ID = '{ID}' AND Date = '{dateTimePicker1.Value}'";
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                reader.Close();
                Decimal workHours = (Decimal)command.ExecuteScalar();
                labelWorkHours.Text = workHours.ToString();

                query = $"SELECT Leave FROM Payroll WHERE ID = '{ID}' AND Date = '{dateTimePicker1.Value}'";
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                reader.Close();
                Decimal leave = (Decimal)command.ExecuteScalar();
                labelLeave.Text = leave.ToString();

                query = $"SELECT HourlyRate FROM Payroll WHERE ID = '{ID}' AND Date = '{dateTimePicker1.Value}'";
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                reader.Close();
                Decimal hourlyRate = (Decimal)command.ExecuteScalar();
                labelHourlyRate.Text = timeIn.ToString();

                query = $"SELECT Total FROM Payroll WHERE ID = '{ID}' AND Date = '{dateTimePicker1.Value}'";
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                reader.Close();
                Decimal total = (Decimal)command.ExecuteScalar();
                labelTotal.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No records on this date" + ex);
            }
            finally
            {

            }
          */
        
        }
    }
}
