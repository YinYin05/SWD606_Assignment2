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
    public partial class RequestLeave : Form
    {
        public RequestLeave()
        {
            InitializeComponent();
        }

        // To store the logged-in user ID and name
        string FirstName = UserSession.Instance.FirstName;
        string LastName = UserSession.Instance.LastName;
        int UserID = UserSession.Instance.ID;

        private void RequestLeave_Load(object sender, EventArgs e)
        {
            comboLeaveType.Items.Add("Sick Leave");
            comboLeaveType.Items.Add("Annual Leave");
            comboLeaveType.Items.Add("Bereavement Leave");
            comboLeaveType.Items.Add("Holiday");

            // Optionally set the current date for the leave request
            datePickerStart.Value = DateTime.Now;
            datePickerEnd.Value = DateTime.Now;

            // Load leave balances from the database
            LoadLeaveBalances();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate ComboBox and DateTimePickers
            if (comboLeaveType.SelectedItem == null)
            {
                MessageBox.Show("Please select a leave type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (datePickerStart.Value.Date > datePickerEnd.Value.Date)
            {
                MessageBox.Show("Start date cannot be later than end date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if Reason is provided
            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                MessageBox.Show("Please provide a reason for your leave request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Calculate hours: (difference in days) * 8 hours per day
            int hours = (datePickerEnd.Value.Date - datePickerStart.Value.Date).Days * 8;

            // If the selected dates are the same, it's 1 day leave, so set hours to 8
            if (datePickerStart.Value.Date == datePickerEnd.Value.Date)
            {
                hours = 8;
            }

            // Get the leave type
            string leaveType = comboLeaveType.SelectedItem.ToString();

            // Check the leave balance if the leave type is Annual or Sick Leave
            if (leaveType == "Annual Leave" || leaveType == "Sick Leave")
            {
                int balance = GetLeaveBalance(leaveType);

                if (balance < hours)
                {
                    MessageBox.Show($"Insufficient {leaveType} balance. You only have {balance} hours available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Set the status to "Pending"
            string status = "Pending";

            // Insert the leave request into the database
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["databaseConnect"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Updated SQL query with new column names
                    string query = "INSERT INTO AppliedLeave (ID, FirstName, LastName, StartDate, EndDate, LeaveType, Hours, Reason, Status) " +
                                   "VALUES (@ID, @FirstName, @LastName, @StartDate, @EndDate, @LeaveType, @Hours, @Reason, @Status)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", UserID);  // Pass UserID as ID
                        cmd.Parameters.AddWithValue("@FirstName", FirstName);
                        cmd.Parameters.AddWithValue("@LastName", LastName);
                        cmd.Parameters.AddWithValue("@StartDate", datePickerStart.Value.Date);  // Using the start date
                        cmd.Parameters.AddWithValue("@EndDate", datePickerEnd.Value.Date);
                        cmd.Parameters.AddWithValue("@LeaveType", leaveType);
                        cmd.Parameters.AddWithValue("@Hours", hours);
                        cmd.Parameters.AddWithValue("@Reason", txtReason.Text);
                        cmd.Parameters.AddWithValue("@Status", status);

                        cmd.ExecuteNonQuery(); // Execute the query

                        MessageBox.Show("Leave request submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Reset DateTimePickers to current date after successful submission
                datePickerStart.Value = DateTime.Now;
                datePickerEnd.Value = DateTime.Now;
                comboLeaveType.SelectedItem = null;  // Deselect the leave type
                txtReason.Clear();  // Clear the reason text box
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while submitting the leave request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to get the available balance for Annual or Sick leave
        private int GetLeaveBalance(string leaveType)
        {
            int balance = 0;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["databaseConnect"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // SQL query to retrieve leave balances for the logged-in user
                    string query = "SELECT [BalanceAnnual], [BalanceSL] FROM [Leave] WHERE [ID] = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", UserID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (leaveType == "Annual Leave")
                                {
                                    balance = Convert.ToInt32(reader["BalanceAnnual"]);
                                }
                                else if (leaveType == "Sick Leave")
                                {
                                    balance = Convert.ToInt32(reader["BalanceSL"]);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Leave balance not found for this employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return 0;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving leave balance: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return balance;
        }

        // Method to load the leave balances for Annual and Sick Leave
        private void LoadLeaveBalances()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["databaseConnect"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // SQL query to retrieve leave balances for the logged-in user
                    string query = "SELECT [BalanceAnnual], [BalanceSL] FROM [Leave] WHERE [ID] = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", UserID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve balance values for Annual and Sick leave
                                int annualBalance = Convert.ToInt32(reader["BalanceAnnual"]);
                                int sickBalance = Convert.ToInt32(reader["BalanceSL"]);

                                // Display the balance in the textboxes
                                txtAnnual.Text = annualBalance.ToString();
                                txtSick.Text = sickBalance.ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving leave balances: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}