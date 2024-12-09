using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SWD606_Assignment2
{
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
            // Ensure textboxes are disabled by default
            SetTextBoxStates(false);

            // Set initial button states
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
        }
        private void SetTextBoxStates(bool isEditable)
        {
            txtCompany.Enabled = isEditable;
            txtCompany.ReadOnly = !isEditable;

            txtAddress.Enabled = isEditable;
            txtAddress.ReadOnly = !isEditable;

            txtEmail.Enabled = isEditable;
            txtEmail.ReadOnly = !isEditable;

            txtPhoneNumber.Enabled = isEditable;
            txtPhoneNumber.ReadOnly = !isEditable;
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadCompanyDetails();
        }

        private void LoadCompanyDetails()
        {
            try
            {
                //using (SqlConnection con = new SqlConnection("Data Source = JP_F15\\SQLEXPRESS; Initial Catalog = SWD606; Integrated Security = True; Encrypt = True;TrustServerCertificate=True"))
                string myConn = ConfigurationManager.ConnectionStrings["databaseConnect"].ConnectionString;

                SqlConnection con = new SqlConnection(myConn);
                {
                    con.Open();

                    // Query to fetch company details
                    string query = "SELECT CompanyName, Address, Email, PhoneNumber FROM Company";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Set the textboxes with the company details
                                txtCompany.Text = reader["CompanyName"].ToString();
                                txtAddress.Text = reader["Address"].ToString();
                                txtEmail.Text = reader["Email"].ToString();
                                txtPhoneNumber.Text = reader["PhoneNumber"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No company details found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching company details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Enable editing and enable the Save button
            SetTextBoxStates(true);
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            txtCompany.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtCompany.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("All fields are required. Please fill in all fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                //using (SqlConnection con = new SqlConnection("Data Source=JP_F15\\SQLEXPRESS;Initial Catalog=SWD606;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                string myConn = ConfigurationManager.ConnectionStrings["databaseConnect"].ConnectionString;

                SqlConnection con = new SqlConnection(myConn);
                {
                    con.Open();

                    // Query to update company details
                    string query = "UPDATE Company SET CompanyName = @CompanyName, Address = @Address, Email = @Email, PhoneNumber = @PhoneNumber";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CompanyName", txtCompany.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to save details. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                // Disable textboxes and Save button, enable Edit button
                SetTextBoxStates(false);
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Ask the admin for confirmation
            var confirmResult = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Close the current form (admin dashboard)
                this.Close();

                // Show the login form
                Form1 loginForm = new Form1();
                loginForm.Show();
            }
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            // Create an instance of the EmployeesTable form
            EmployeesTable employeesTable = new EmployeesTable();

            // Show the EmployeesTable form
            employeesTable.Show();
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            // Create an instance of the PayrollTable form
            PayrollTable payrollForm = new PayrollTable();

            // Show the form
            payrollForm.Show();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            // Create an instance of the LeaveManagement form
            LeaveManagement leaveForm = new LeaveManagement();

            // Show the form
            leaveForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
