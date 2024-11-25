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

namespace SWD606_Assignment2
{
    public partial class btnAddNewEmployee : Form
    {

        public btnAddNewEmployee()
        {
            InitializeComponent();
        }

        private void EmployeesTable_Load(object sender, EventArgs e)
        {
            LoadEmployeesData();
            // Subscribe to the CellPainting event
            dataGridView1.CellPainting += dataGridView1_CellPainting;
        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Check if the cell is in the "Edit" or "Delete" button columns
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
                {
                    // Fill the background with light green
                    e.Graphics.FillRectangle(new SolidBrush(Color.LightGreen), e.CellBounds);

                    // Draw the button border (light green with a dark border)
                    using (Pen borderPen = new Pen(Color.Black, 2))
                    {
                        e.Graphics.DrawRectangle(borderPen, e.CellBounds);
                    }

                    // Draw the button text with black color and center alignment
                    TextRenderer.DrawText(e.Graphics, e.FormattedValue.ToString(), e.CellStyle.Font,
                                          e.CellBounds, Color.Black, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                    e.Handled = true;  // Prevent default rendering
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    // Fill the background with light red
                    e.Graphics.FillRectangle(new SolidBrush(Color.LightCoral), e.CellBounds);

                    // Draw the button border (light red with a dark border)
                    using (Pen borderPen = new Pen(Color.Black, 2))
                    {
                        e.Graphics.DrawRectangle(borderPen, e.CellBounds);
                    }

                    // Draw the button text with black color and center alignment
                    TextRenderer.DrawText(e.Graphics, e.FormattedValue.ToString(), e.CellStyle.Font,
                                          e.CellBounds, Color.Black, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                    e.Handled = true;  // Prevent default rendering
                }
            }
        }
        private void LoadEmployeesData()
        {
            try
            {
                // connection string server
                using (SqlConnection con = new SqlConnection("Data Source = JP_F15\\SQLEXPRESS; Initial Catalog = SWD606; Integrated Security = True; Encrypt = True;TrustServerCertificate=True"))
                {
                    con.Open();

                    // SQL query to fetch all records from Employees table
                    string query = "SELECT * FROM Employees";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Bind the data to the DataGridView
                        dataGridView1.DataSource = dt;

                        // Add Edit button column if not already present
                        if (dataGridView1.Columns["Edit"] == null)
                        {
                            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
                            {
                                Name = "Edit",
                                HeaderText = "Edit",
                                Text = "Edit",
                                UseColumnTextForButtonValue = true
                            };
                            dataGridView1.Columns.Add(btnEdit);
                        }

                        // Add Delete button column if not already present
                        if (dataGridView1.Columns["Delete"] == null)
                        {
                            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn
                            {
                                Name = "Delete",
                                HeaderText = "Delete",
                                Text = "Delete",
                                UseColumnTextForButtonValue = true
                            };
                            dataGridView1.Columns.Add(btnDelete);
                        }

                        // Set DataGridView properties
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.ReadOnly = true; // Set entire grid as read-only initially
                        dataGridView1.AllowUserToAddRows = false;
                        dataGridView1.AllowUserToDeleteRows = false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Show an error message if the database operation fails
                MessageBox.Show($"Failed to load data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a valid button column
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                if (columnName == "Edit")
                {
                    // Retrieve employee data
                    int employeeID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                    string firstName = dataGridView1.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                    string lastName = dataGridView1.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                    string address = dataGridView1.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                    string email = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                    string phone = dataGridView1.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                    string position = dataGridView1.Rows[e.RowIndex].Cells["Position"].Value.ToString();
                    decimal hourlyRate = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["HourlyRate"].Value);
                    string password = dataGridView1.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                    string role = dataGridView1.Rows[e.RowIndex].Cells["Role"].Value.ToString();

                    // Pass data to UpdateEmployee form
                    UpdateEmployee updateForm = new UpdateEmployee(employeeID, firstName, lastName, address, email, phone, position, hourlyRate, password, role);
                    updateForm.ShowDialog();

                    // Reload data after closing the UpdateEmployee form
                    LoadEmployeesData();
                }

                else if (columnName == "Delete")
                {
                    string employeeID = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                    // Confirm before deleting
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete Employee ID: {employeeID}?",
                                                          "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        DeleteEmployee(employeeID); // Call a method to delete the record

                        // Remove the row after the operation is done.
                        // First, store the row index, then delete the row from the collection
                        int rowIndex = e.RowIndex;

                        // Ensure that the row index is still valid after the delete operation
                        if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
                        {
                            dataGridView1.Rows.RemoveAt(rowIndex);
                        }

                        // Optionally, refresh the data from the database to ensure consistency
                        LoadEmployeesData();
                    }
                }
            }
        }

        private void DeleteEmployee(string employeeID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source = JP_F15\\SQLEXPRESS; Initial Catalog = SWD606; Integrated Security = True; Encrypt = True;TrustServerCertificate=True"))
                {
                    con.Open();

                    string query = "DELETE FROM Employees WHERE ID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", employeeID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the employee. Employee ID may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                // Refresh the DataGridView after deletion
                LoadEmployeesData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the input from the search textbox
            string searchText = txtSearch.Text.Trim();

            // Check if the input is a valid integer
            if (int.TryParse(searchText, out int searchValue))
            {
                // Proceed with searching using the integer value
                SearchEmployeeById(searchValue);
            }
            else
            {
                // Inform the user that the input is not a valid integer
                MessageBox.Show("Please enter a valid integer to search.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Method to perform the search and update DataGridView
        private void SearchEmployeeById(int employeeId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source = JP_F15\\SQLEXPRESS; Initial Catalog = SWD606; Integrated Security = True; Encrypt = True;TrustServerCertificate=True"))
                {
                    con.Open();

                    // SQL query to search for the employee by ID
                    string query = "SELECT * FROM Employees WHERE ID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", employeeId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                // Display the filtered data
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {
                                // Inform the user if no match is found
                                MessageBox.Show("No employee found with that ID.", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadEmployeesData();
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            // Create an instance of the NewEmployee form
            NewEmployee newEmployeeForm = new NewEmployee();
            newEmployeeForm.Show();
        }
    }
}
