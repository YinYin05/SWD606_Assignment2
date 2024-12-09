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
    public partial class PayrollTable : Form
    {
        private DataTable currentData = new DataTable();

        public PayrollTable()
        {
            InitializeComponent();
        }
        private void PayrollTable_Load(object sender, EventArgs e)
        {
            LoadPayrollData();

            // Subscribe to the CellClick event (Ensure this is hooked up)
            dataGridView1.CellClick += dataGridView1_CellClick;

            // Subscribe to the CellPainting event
            dataGridView1.CellPainting += DataGridView1_CellPainting;
        }

        private void LoadPayrollData(bool loadSchemaOnly = false)
        {
            try
            {
                DataTable dt = GetPayrollSchema();

                if (!loadSchemaOnly)
                {
                    //using (SqlConnection con = new SqlConnection("Data Source=JP_F15\\SQLEXPRESS;Initial Catalog=SWD606;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                    string myConn = ConfigurationManager.ConnectionStrings["databaseConnect"].ConnectionString;

                    SqlConnection con = new SqlConnection(myConn);
                    {
                        con.Open();

                        string query = "SELECT [PID], [ID], [FirstName], [LastName], [Date], [TimeIN], [TimeOUT], [WorkHours], [Leave], [HourlyRate], [Total] FROM Payroll";

                        using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }

                currentData = dt; // Store the loaded data
                dataGridView1.DataSource = currentData;

                AddEditAndDeleteColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddEditAndDeleteColumns()
        {
            if (!dataGridView1.Columns.Contains("Edit"))
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

            if (!dataGridView1.Columns.Contains("Delete"))
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

            dataGridView1.Columns["Edit"].DisplayIndex = dataGridView1.Columns.Count - 2;
            dataGridView1.Columns["Delete"].DisplayIndex = dataGridView1.Columns.Count - 1;
        }

        private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a valid button column
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                if (columnName == "Edit")
                {
                    // Retrieve the data from the selected row
                    int payrollID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["PID"].Value);
                    int employeeID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                    string firstName = dataGridView1.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                    string lastName = dataGridView1.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                    DateTime date = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["Date"].Value);
                    string timeIn = dataGridView1.Rows[e.RowIndex].Cells["TimeIN"].Value.ToString();
                    string timeOut = dataGridView1.Rows[e.RowIndex].Cells["TimeOUT"].Value.ToString();
                    string workHours = dataGridView1.Rows[e.RowIndex].Cells["WorkHours"].Value.ToString();
                    string leave = dataGridView1.Rows[e.RowIndex].Cells["Leave"].Value.ToString();
                    string hourlyRate = dataGridView1.Rows[e.RowIndex].Cells["HourlyRate"].Value.ToString();
                    string total = dataGridView1.Rows[e.RowIndex].Cells["Total"].Value.ToString();

                    // Open the UpdatePayroll form and pass the data
                    UpdatePayroll updateForm = new UpdatePayroll(payrollID, employeeID, firstName, lastName, date, timeIn, timeOut, workHours, leave, hourlyRate, total);
                    updateForm.ShowDialog();

                    // Reload data after closing the UpdatePayroll form
                    LoadPayrollData();
                }
                else if (columnName == "Delete")
                {
                    string payrollID = dataGridView1.Rows[e.RowIndex].Cells["PID"].Value.ToString();

                    // Confirm before deleting
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete Payroll ID: {payrollID}?",
                                                          "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        DeletePayroll(payrollID);

                        // Remove the row after the operation is done
                        if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                        {
                            dataGridView1.Rows.RemoveAt(e.RowIndex);
                        }

                        // Optionally, refresh the data from the database to ensure consistency
                        LoadPayrollData();
                    }
                }
            }
        }

        private void DeletePayroll(string payrollID)
        {
            try
            {
                //using (SqlConnection con = new SqlConnection("Data Source = JP_F15\\SQLEXPRESS; Initial Catalog = SWD606; Integrated Security = True; Encrypt = True; TrustServerCertificate=True"))
                string myConn = ConfigurationManager.ConnectionStrings["databaseConnect"].ConnectionString;

                SqlConnection con = new SqlConnection(myConn);
                {
                    con.Open();

                    string query = "DELETE FROM Payroll WHERE PID = @PID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@PID", payrollID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Payroll record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the payroll record. Payroll ID may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the payroll record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = txtSearch.Text.Trim();

                if (string.IsNullOrEmpty(searchValue))
                {
                    LoadPayrollData(); // Reload all data
                    return;
                }

                if (!int.TryParse(searchValue, out int searchID))
                {
                    MessageBox.Show("Please enter a valid numeric ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataView dv = currentData.DefaultView;
                dv.RowFilter = $"ID = {searchID}"; // Filter the stored data
                currentData = dv.ToTable(); // Update currentData with search results
                dataGridView1.DataSource = currentData;

                AddEditAndDeleteColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate = dateTimePickerFrom.Value.Date;
                DateTime toDate = dateTimePickerTo.Value.Date;

                if (toDate < fromDate)
                {
                    MessageBox.Show("The 'To' date must be equal to or later than the 'From' date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataView dv = currentData.DefaultView;
                dv.RowFilter = $"Date >= #{fromDate:yyyy-MM-dd}# AND Date <= #{toDate:yyyy-MM-dd}#";
                dataGridView1.DataSource = dv.ToTable();

                AddEditAndDeleteColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while filtering: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable GetPayrollSchema()
        {
            DataTable schemaTable = new DataTable();

            schemaTable.Columns.Add("PID", typeof(int));
            schemaTable.Columns.Add("ID", typeof(int));
            schemaTable.Columns.Add("FirstName", typeof(string));
            schemaTable.Columns.Add("LastName", typeof(string));
            schemaTable.Columns.Add("Date", typeof(DateTime));
            schemaTable.Columns.Add("TimeIN", typeof(string));
            schemaTable.Columns.Add("TimeOUT", typeof(string));
            schemaTable.Columns.Add("WorkHours", typeof(decimal));
            schemaTable.Columns.Add("Leave", typeof(decimal));
            schemaTable.Columns.Add("HourlyRate", typeof(decimal));
            schemaTable.Columns.Add("Total", typeof(decimal));

            return schemaTable;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadPayrollData();
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            // Reset the DateTimePickers to the current date
            dateTimePickerFrom.Value = DateTime.Now;
            dateTimePickerTo.Value = DateTime.Now;

            LoadPayrollData();

            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
