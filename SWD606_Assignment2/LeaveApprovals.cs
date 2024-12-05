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
        }
        // Method to load leave requests from the database
        // Adjust the SQL query to include AID
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
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with data
                        dataAdapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dgvLeaveApprovals.DataSource = dataTable;
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
            if (e.RowIndex >= 0 && dgvLeaveApprovals.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                string action = dgvLeaveApprovals.Columns[e.ColumnIndex].Name; // Get the column name (Approve or Reject)
                int leaveAID = Convert.ToInt32(dgvLeaveApprovals.Rows[e.RowIndex].Cells["AID"].Value); // Use AID instead of ID
                string leaveType = dgvLeaveApprovals.Rows[e.RowIndex].Cells["LeaveType"].Value.ToString(); // Get the leave type
                int hours = Convert.ToInt32(dgvLeaveApprovals.Rows[e.RowIndex].Cells["Hours"].Value); // Get the requested hours
                int userId = Convert.ToInt32(dgvLeaveApprovals.Rows[e.RowIndex].Cells["ID"].Value); // User ID for leave balance update
                DateTime startDate = Convert.ToDateTime(dgvLeaveApprovals.Rows[e.RowIndex].Cells["StartDate"].Value); // Get the start date
                DateTime endDate = Convert.ToDateTime(dgvLeaveApprovals.Rows[e.RowIndex].Cells["EndDate"].Value); // Get the end date

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
}

