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
    public partial class NewEmployee : Form
    {
        public NewEmployee()
        {
            InitializeComponent();
        }
        private void NewEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                //using (SqlConnection con = new SqlConnection("Data Source = JP_F15\\SQLEXPRESS; Initial Catalog = SWD606; Integrated Security = True; Encrypt = True;TrustServerCertificate=True"))
                string myConn = ConfigurationManager.ConnectionStrings["databaseConnect"].ConnectionString;

                SqlConnection con = new SqlConnection(myConn);
                {
                    con.Open();

                    // Query to get the maximum ID value from the Employees table
                    string query = "SELECT ISNULL(MAX(ID), 0) + 1 FROM Employees";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Execute the query and retrieve the next ID
                        int nextID = Convert.ToInt32(cmd.ExecuteScalar());

                        // Display the next ID in the txtID textbox
                        txtID.Text = nextID.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching the next ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //using (SqlConnection con = new SqlConnection("Data Source = JP_F15\\SQLEXPRESS; Initial Catalog = SWD606; Integrated Security = True; Encrypt = True;TrustServerCertificate=True"))
                string myConn = ConfigurationManager.ConnectionStrings["databaseConnect"].ConnectionString;

                SqlConnection con = new SqlConnection(myConn);
                {
                    con.Open();

                    // Start a transaction
                    using (SqlTransaction transaction = con.BeginTransaction())
                    {
                        try
                        {
                            // Insert the new employee record
                            string insertQuery = @"
                    INSERT INTO Employees 
                    (FirstName, LastName, Address, Email, Phone, Position, HourlyRate, Password, Role) 
                    VALUES 
                    (@FirstName, @LastName, @Address, @Email, @Phone, @Position, @HourlyRate, @Password, @Role)";

                            SqlCommand cmdInsert = new SqlCommand(insertQuery, con, transaction);

                            // Add parameters for each field                        
                            cmdInsert.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                            cmdInsert.Parameters.AddWithValue("@LastName", txtLastName.Text);
                            cmdInsert.Parameters.AddWithValue("@Address", txtAddress.Text);
                            cmdInsert.Parameters.AddWithValue("@Email", txtEmail.Text);
                            cmdInsert.Parameters.AddWithValue("@Phone", txtPhone.Text);
                            cmdInsert.Parameters.AddWithValue("@Position", txtPosition.Text);
                            cmdInsert.Parameters.AddWithValue("@HourlyRate", Convert.ToDecimal(txtHourlyRate.Text));
                            cmdInsert.Parameters.AddWithValue("@Password", txtPassword.Text); // Make sure passwords are hashed in production
                            cmdInsert.Parameters.AddWithValue("@Role", txtRole.Text);

                            cmdInsert.ExecuteNonQuery();

                            // Commit the transaction
                            transaction.Commit();

                            MessageBox.Show("New employee registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear fields and fetch the next available ID
                            ClearFields(con);
                        }
                        catch
                        {
                            // Rollback the transaction in case of an error
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to clear fields and fetch the next available ID
        private void ClearFields(SqlConnection con)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtPosition.Text = "";
            txtHourlyRate.Text = "";
            txtPassword.Text = "";
            txtRole.Text = "";

            try
            {
                // Fetch the next available ID
                string query = "SELECT ISNULL(MAX(ID), 0) + 1 FROM Employees";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    int nextID = Convert.ToInt32(cmd.ExecuteScalar());
                    txtID.Text = nextID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching the next ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
