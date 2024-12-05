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
    public partial class LeaveManagement : Form
    {
        // Example static variable to hold user session role (this is just a placeholder)
        public static string CurrentUserRole = "Admin"; 

        private DataTable leaveTable; // Store the data locally for filtering and resetting
        public LeaveManagement()
        {
            InitializeComponent();
            LoadLeaveData();
            InitializeSearchComboBox();
        }

        private void LoadLeaveData()
        {
            try
            {
                // Get the connection string from App.config
                string myConn = ConfigurationManager.ConnectionStrings["databaseConnect"].ConnectionString;

                using (SqlConnection con = new SqlConnection(myConn))
                {
                    con.Open();

                    // Query to fetch data from the Leave table
                    string query = @"SELECT ID, FirstName, LastName, AnnualLeave, SickLeave, 
                                            UsedAnnual, UsedSL, BalanceAnnual, BalanceSL, Holiday, Bereavement 
                                     FROM Leave";

                    // Use SqlDataAdapter to fill the data
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    leaveTable = new DataTable(); // Initialize the DataTable
                    adapter.Fill(leaveTable);

                    // Bind the data to the DataGridView
                    dataGridView1.DataSource = leaveTable;
                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show($"Error loading leave data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchColumn = cmbSearch.SelectedItem?.ToString();
                string searchText = txtSearch.Text.Trim();

                if (string.IsNullOrEmpty(searchColumn) || string.IsNullOrEmpty(searchText))
                {
                    MessageBox.Show("Please select a search column and enter search text.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Convert column name to database column names
                string columnName = searchColumn switch
                {
                    "ID" => "ID",
                    "First Name" => "FirstName",
                    "Last Name" => "LastName",
                    _ => throw new ArgumentException("Invalid search column")
                };

                // Apply search filter
                string filter = columnName == "ID"
                    ? $"{columnName} = {searchText}" // For numeric ID
                    : $"{columnName} LIKE '%{searchText}%'"; // For string-based columns

                DataView dataView = leaveTable.DefaultView;
                dataView.RowFilter = filter; // Apply the filter
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear the search box and reset combo boxes
                txtSearch.Clear();
                cmbSearch.SelectedIndex = -1; // Reset search combo box

                // Reset the data view to show all rows
                DataView dataView = leaveTable.DefaultView;
                dataView.RowFilter = string.Empty;

                // Reset the focus to the search text box
                txtSearch.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while resetting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InitializeSearchComboBox()
        {
            // Add the search options to the combo box
            cmbSearch.Items.AddRange(new string[] { "ID", "First Name", "Last Name" });
            cmbSearch.SelectedIndex = -1; // Ensure no selection by default
        }

        private bool CheckIfAdmin()
        {
            // Replace with your session or role-checking logic
            return CurrentUserRole == "Admin"; // Check if the user is an admin
        }

        private void btnLeaveApprovals_Click(object sender, EventArgs e)
        {
            // Pass a flag indicating whether the user is an admin to the LeaveApprovals form
            bool isAdmin = CheckIfAdmin(); //

            LeaveApprovals leaveApprovalsForm = new LeaveApprovals(isAdmin);
            leaveApprovalsForm.Show();
        }
    }
}