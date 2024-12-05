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
    public partial class LeaveApprovals : Form
    {
        private DataTable leaveDataTable; // Holds the leave approvals data
        private bool isAdmin; // Store the admin status
        public LeaveApprovals(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
        }
        public LeaveApprovals()
        {
            InitializeComponent();
        }

        private void LeaveApprovals_Load(object sender, EventArgs e)
        {
            LoadLeaveApprovals();

            // Adding Approve Button Column
            DataGridViewButtonColumn approveButtonColumn = new DataGridViewButtonColumn();
            approveButtonColumn.HeaderText = "Approve";
            approveButtonColumn.Name = "Approve";
            approveButtonColumn.Text = "Approve";
            approveButtonColumn.UseColumnTextForButtonValue = true;
            dgvLeaveApprovals.Columns.Add(approveButtonColumn);

            // Adding Reject Button Column
            DataGridViewButtonColumn rejectButtonColumn = new DataGridViewButtonColumn();
            rejectButtonColumn.HeaderText = "Reject";
            rejectButtonColumn.Name = "Reject";
            rejectButtonColumn.Text = "Reject";
            rejectButtonColumn.UseColumnTextForButtonValue = true;
            dgvLeaveApprovals.Columns.Add(rejectButtonColumn);

            // Attach CellPainting event
            dgvLeaveApprovals.CellPainting += DgvLeaveApprovals_CellPainting;

            // Attach the CellFormatting event
            dgvLeaveApprovals.CellFormatting += DgvLeaveApprovals_CellFormatting;
            // Event handler for button clicks
            dgvLeaveApprovals.CellContentClick += DgvLeaveApprovals_CellContentClick;

            // Add values to search combo box
            cmbSearch.Items.AddRange(new string[] { "ID", "First Name", "Last Name", "Start Date" });
            // Do not set a default selection for cmbSearch
            cmbSearch.SelectedIndex = -1; // No selection by default

            // Add values to sort combo box
            cmbSortBy.Items.AddRange(new string[] { "Start Date", "Leave Type", "Status" });

            // Do not set a default selection for cmbSortBy
            cmbSortBy.SelectedIndex = -1; // No selection by default

            // Attach events
            btnSearch.Click += btnSearch_Click;
            cmbSortBy.SelectedIndexChanged += cmbSortBy_SelectedIndexChanged;

            // Disable buttons if the user is an admin
            if (isAdmin)
            {
                dgvLeaveApprovals.Columns["Approve"].ReadOnly = true;
                dgvLeaveApprovals.Columns["Reject"].ReadOnly = true;

                // Optionally, make the buttons visually disabled
                dgvLeaveApprovals.CellFormatting += (s, e) =>
                {
                    if (e.RowIndex >= 0 &&
                        (e.ColumnIndex == dgvLeaveApprovals.Columns["Approve"].Index ||
                         e.ColumnIndex == dgvLeaveApprovals.Columns["Reject"].Index))
                    {
                        e.CellStyle.BackColor = Color.Gray;
                        e.CellStyle.ForeColor = Color.DarkGray;
                    }
                };
            }
        }

        // Method to load leave requests from the database        
        private void LoadLeaveApprovals()
        {
            try
            {
                // Connection string from config file
                string connectionString = ConfigurationManager.ConnectionStrings["databaseConnect"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // SQL query to select leave requests and include StartDate, EndDate, Reason, etc.
                    string query = @"
                SELECT AID, ID, FirstName, LastName, StartDate, EndDate, LeaveType, Hours, Reason, Status 
                FROM AppliedLeave
                ORDER BY 
                    CASE 
                        WHEN Status = 'Pending' THEN 1 
                        ELSE 2 
                    END, 
                    StartDate ASC"; // Sort by StartDate within the same status

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Data adapter to fill the DataTable
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        leaveDataTable = new DataTable(); // Initialize class-level leaveDataTable
                        dataAdapter.Fill(leaveDataTable);
                        dgvLeaveApprovals.DataSource = leaveDataTable; // Bind DataTable to DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving leave approvals: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Adjust the button click logic
        private void DgvLeaveApprovals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Skip processing if admin is logged in (disable functionality)
            if (isAdmin)
                return;  // Prevent the button click from being processed

            if (e.RowIndex >= 0 && dgvLeaveApprovals.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                string action = dgvLeaveApprovals.Columns[e.ColumnIndex].Name; // Get the column name (Approve or Reject)
                int leaveAID = Convert.ToInt32(dgvLeaveApprovals.Rows[e.RowIndex].Cells["AID"].Value); // Use AID instead of ID
                string leaveType = dgvLeaveApprovals.Rows[e.RowIndex].Cells["LeaveType"].Value.ToString(); // Get the leave type
                int hours = Convert.ToInt32(dgvLeaveApprovals.Rows[e.RowIndex].Cells["Hours"].Value); // Get the requested hours
                int userId = Convert.ToInt32(dgvLeaveApprovals.Rows[e.RowIndex].Cells["ID"].Value); // User ID for leave balance update
                DateTime startDate = Convert.ToDateTime(dgvLeaveApprovals.Rows[e.RowIndex].Cells["StartDate"].Value); // Get the start date
                DateTime endDate = Convert.ToDateTime(dgvLeaveApprovals.Rows[e.RowIndex].Cells["EndDate"].Value); // Get the end date

                // Show confirmation dialog before approving or rejecting
                var confirmResult = MessageBox.Show($"Are you sure you want to {action.ToLower()} this leave request?",
                                                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.No)
                    return; // If user chooses 'No', exit without performing the action

                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["databaseConnect"].ConnectionString;

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        if (action == "Approve")
                        {
                            // Update the status of the leave request
                            string updateRequestQuery = "UPDATE AppliedLeave SET Status = 'Approved' WHERE AID = @AID";
                            using (SqlCommand cmd = new SqlCommand(updateRequestQuery, con))
                            {
                                cmd.Parameters.AddWithValue("@AID", leaveAID);
                                cmd.ExecuteNonQuery();
                            }

                            // Update the balance and used hours
                            UpdateLeaveBalances(con, leaveType, hours, userId);
                        }
                        else if (action == "Reject")
                        {
                            // Update the status of the leave request
                            string updateRequestQuery = "UPDATE AppliedLeave SET Status = 'Rejected' WHERE AID = @AID";
                            using (SqlCommand cmd = new SqlCommand(updateRequestQuery, con))
                            {
                                cmd.Parameters.AddWithValue("@AID", leaveAID);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // Disable the approve/reject buttons once the request is processed
                    dgvLeaveApprovals.Rows[e.RowIndex].Cells["Approve"].ReadOnly = true;
                    dgvLeaveApprovals.Rows[e.RowIndex].Cells["Reject"].ReadOnly = true;

                    // Visually disable the buttons by changing their background color
                    dgvLeaveApprovals.Rows[e.RowIndex].Cells["Approve"].Style.BackColor = Color.Gray;
                    dgvLeaveApprovals.Rows[e.RowIndex].Cells["Reject"].Style.BackColor = Color.Gray;

                    // Ensure the DataGridView is refreshed so that the changes are visible
                    dgvLeaveApprovals.Refresh();

                    MessageBox.Show($"Leave request {action}d successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload the DataGridView
                    LoadLeaveApprovals();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Modify the UpdateLeaveBalances method
        private void UpdateLeaveBalances(SqlConnection con, string leaveType, int hours, int userId)
        {
            string updateBalanceQuery = "";

            if (leaveType == "Sick Leave")
            {
                updateBalanceQuery = @"
        UPDATE Leave 
        SET BalanceSL = BalanceSL - @Hours, 
            UsedSL = UsedSL + @Hours
        WHERE ID = @UserID";
            }
            else if (leaveType == "Annual Leave")
            {
                updateBalanceQuery = @"
        UPDATE Leave 
        SET BalanceAnnual = BalanceAnnual - @Hours, 
            UsedAnnual = UsedAnnual + @Hours
        WHERE ID = @UserID";
            }
            else if (leaveType == "Bereavement Leave")
            {
                updateBalanceQuery = @"
        UPDATE Leave 
        SET Bereavement = Bereavement + @Hours
        WHERE ID = @UserID";
            }
            else if (leaveType == "Holiday")
            {
                updateBalanceQuery = @"
        UPDATE Leave 
        SET Holiday = Holiday + @Hours
        WHERE ID = @UserID";
            }

            using (SqlCommand cmd = new SqlCommand(updateBalanceQuery, con))
            {
                cmd.Parameters.AddWithValue("@Hours", hours);
                cmd.Parameters.AddWithValue("@UserID", userId); // Use the specific user ID for the update
                cmd.ExecuteNonQuery();
            }
        }

        private void DgvLeaveApprovals_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the current cell belongs to the Approve or Reject column
            if (e.RowIndex >= 0)
            {
                if (dgvLeaveApprovals.Columns[e.ColumnIndex].Name == "Approve")
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                    e.CellStyle.ForeColor = Color.Black; // Optional: set text color
                }
                else if (dgvLeaveApprovals.Columns[e.ColumnIndex].Name == "Reject")
                {
                    e.CellStyle.BackColor = Color.LightCoral;
                    e.CellStyle.ForeColor = Color.Black; // Optional: set text color
                }
            }
        }
        private void DgvLeaveApprovals_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLeaveApprovals.Columns.Contains("Approve") && dgvLeaveApprovals.Columns.Contains("Reject"))
            {
                if (e.RowIndex >= 0 && (e.ColumnIndex == dgvLeaveApprovals.Columns["Approve"].Index || e.ColumnIndex == dgvLeaveApprovals.Columns["Reject"].Index))
                {
                    e.Handled = true; // Indicate that the painting is handled
                    e.PaintBackground(e.ClipBounds, true); // Paint the background

                    // Set the button colors
                    Color buttonColor = e.ColumnIndex == dgvLeaveApprovals.Columns["Approve"].Index ? Color.LightGreen : Color.LightCoral;

                    // Draw the button background
                    using (Brush brush = new SolidBrush(buttonColor))
                    {
                        e.Graphics.FillRectangle(brush, e.CellBounds);
                    }

                    // Draw the button text
                    string buttonText = e.ColumnIndex == dgvLeaveApprovals.Columns["Approve"].Index ? "Approve" : "Reject";
                    TextRenderer.DrawText(
                        e.Graphics,
                        buttonText,
                        dgvLeaveApprovals.Font,
                        e.CellBounds,
                        Color.Black, // Text color
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                    // Draw the border manually
                    using (Pen pen = new Pen(dgvLeaveApprovals.GridColor))
                    {
                        e.Graphics.DrawRectangle(pen, new Rectangle(e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Width - 1, e.CellBounds.Height - 1));
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbSearch.SelectedIndex == -1) // No item selected
            {
                MessageBox.Show("Please select a search field.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Exit without performing search
            }

            string searchColumn = cmbSearch.SelectedItem.ToString();
            string searchText = txtSearch.Text.Trim();

            try
            {
                // Convert column name to match database field names
                string columnName = searchColumn switch
                {
                    "ID" => "ID",
                    "First Name" => "FirstName",
                    "Last Name" => "LastName",
                    "Start Date" => "StartDate",
                    _ => throw new ArgumentException("Invalid search column")
                };

                // Determine appropriate filter based on column type
                string filter;

                if (columnName == "ID") // Numeric column
                {
                    if (!int.TryParse(searchText, out _)) // Check if the input is numeric
                    {
                        MessageBox.Show("Please enter a valid numeric value for ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    filter = string.IsNullOrEmpty(searchText) ? "" : $"{columnName} = {searchText}";
                }
                else if (columnName == "StartDate") // Date column
                {
                    if (!DateTime.TryParse(searchText, out _)) // Validate date format
                    {
                        MessageBox.Show("Please enter a valid date in the format YYYY-MM-DD.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    filter = string.IsNullOrEmpty(searchText) ? "" : $"{columnName} = '{searchText}'";
                }
                else // String columns
                {
                    filter = string.IsNullOrEmpty(searchText) ? "" : $"{columnName} LIKE '%{searchText}%'";
                }

                // Apply the filter
                DataView dataView = leaveDataTable.DefaultView;
                dataView.RowFilter = filter;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSortBy.SelectedIndex == -1) // No item selected
            {
                return; // Do nothing
            }

            if (leaveDataTable == null || leaveDataTable.Rows.Count == 0)
            {
                MessageBox.Show("No data available for sorting.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sortColumn = cmbSortBy.SelectedItem.ToString();
            try
            {
                string columnName = sortColumn switch
                {
                    "Start Date" => "StartDate",
                    "Leave Type" => "LeaveType",
                    "Status" => "Status",
                    _ => throw new ArgumentException("Invalid sort column")
                };

                DataView dataView = leaveDataTable.DefaultView;
                dataView.Sort = $"{columnName} ASC";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while sorting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear the search box and reset combo boxes
                txtSearch.Clear();
                cmbSearch.SelectedIndex = -1; // Reset search combo box
                cmbSortBy.SelectedIndex = -1; // Reset sort combo box

                // Reload the original data into the DataGridView
                LoadLeaveApprovals();

                // Reset the focus to the search text box
                txtSearch.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while resetting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

