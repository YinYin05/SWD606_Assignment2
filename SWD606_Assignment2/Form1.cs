using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection.Metadata;
using System.Security.Cryptography.Xml;
using System;
using System.Configuration;

namespace SWD606_Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both email and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            try
            {
                //using (SqlConnection con = new SqlConnection("Data Source = JP_F15\\SQLEXPRESS; Initial Catalog = SWD606; Integrated Security = True; Encrypt = True;TrustServerCertificate=True"))
                string myConn = ConfigurationManager.ConnectionStrings["databaseConnect"].ConnectionString;
                
                SqlConnection con = new SqlConnection(myConn);
                
                {
                    con.Open();

                    // Query to check the email and password, and get employee details
                    string query = "SELECT ID, FirstName, LastName, Email, Role FROM Employees WHERE Email = @Email AND Password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve the employee details
                                int ID = Convert.ToInt32(reader["ID"]);
                                string FirstName = reader["FirstName"].ToString();
                                string LastName = reader["LastName"].ToString();
                                string Email = reader["Email"].ToString();
                                string Role = reader["Role"].ToString();

                                // Set the user data in the UserSession singleton
                                UserSession.Instance.SetUserData(ID, FirstName, LastName, Email, Role);

                                // Navigate based on role
                                if (Role == "Admin")
                                    {
                                        adminDashboard adminDashboard = new adminDashboard();
                                        adminDashboard.Show();
                                    }
                                    else if (Role == "Employee")
                                    {
                                        /*employeeDashboard employeeDashboard = new employeeDashboard();
                                        employeeDashboard.Show();*/
                                        EmployeeDashboard2 employeeDashboard2 = new EmployeeDashboard2();
                                        employeeDashboard2.Show();
                                    }
                                    else if (Role == "Manager")
                                    {
                                        // For Manager, load EmployeeDashboard2 with additional features
                                        EmployeeDashboard2 employeeDashboard2 = new EmployeeDashboard2();
                                        employeeDashboard2.Show();
                                    }

                                else
                                    {
                                    MessageBox.Show("Unknown role. Please contact the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                this.Hide(); // Hide the login form
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtEmail.Focus();
                            }
                        }
                    }
                }            
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    public class UserSession
    {
        private static UserSession _instance;

        // Properties to hold user details
        public int ID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Role { get; private set; }

        // Private constructor to prevent instantiation from outside
        private UserSession() { }

        // Method to get the singleton instance
        public static UserSession Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserSession();
                }
                return _instance;
            }
        }

        // Method to set user data upon successful login
        public void SetUserData(int id, string firstName, string lastName, string email, string role)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Role = role;
        }

        // Method to clear session data (e.g., on logout)
        public void ClearSession()
        {
            _instance = null;
        }
    }
}
