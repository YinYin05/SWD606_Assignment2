using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;

namespace SWD606_Assignment2
{
    public partial class UpdateEmployee : Form
    {
        private int employeeID;

        // Constructor for the UpdateEmployee form
        public UpdateEmployee(int id, string firstName, string lastName, string address, string email, string phone, string position, decimal hourlyRate, string password, string role)
        {
            InitializeComponent();

            // Initialize form fields with passed data
            employeeID = id;
            txtID.Text = id.ToString();
            txtID.ReadOnly = true; // Prevent editing of ID field

            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
            txtAddress.Text = address;
            txtEmail.Text = email;
            txtPhone.Text = phone;
            txtPosition.Text = position;
            txtHourlyRate.Text = hourlyRate.ToString("F2");
            txtPassword.Text = password;
            txtRole.Text = role;
        }

        // Save button click event to update employee details in the database
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPosition.Text) ||
                string.IsNullOrWhiteSpace(txtRole.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtHourlyRate.Text.Trim(), out decimal hourlyRate))
            {
                MessageBox.Show("Hourly Rate must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Database connection and update query
                using (SqlConnection con = new SqlConnection("Data Source=JP_F15\\SQLEXPRESS;Initial Catalog=SWD606;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    string query = @"UPDATE Employees 
                                     SET FirstName = @FirstName, LastName = @LastName, Address = @Address, 
                                         Email = @Email, Phone = @Phone, Position = @Position, 
                                         HourlyRate = @HourlyRate, Password = @Password, Role = @Role
                                     WHERE ID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters to the SQL query
                        cmd.Parameters.AddWithValue("@ID", employeeID);
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Position", txtPosition.Text.Trim());
                        cmd.Parameters.AddWithValue("@HourlyRate", hourlyRate);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@Role", txtRole.Text.Trim());

                        // Execute the query and check if the update was successful
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update employee details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

