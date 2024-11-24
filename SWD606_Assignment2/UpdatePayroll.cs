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
    public partial class UpdatePayroll : Form
    {
        private int payrollID;
        private int employeeID;
        public UpdatePayroll(int payrollID, int employeeID, string firstName, string lastName, DateTime date, string timeIn, string timeOut, string workHours, string leave, string hourlyRate, string total)
        {
            InitializeComponent();
            this.payrollID = payrollID; // Store the payroll ID
            this.employeeID = employeeID; // Store the employee ID

            // Populate the textboxes with the passed data
            txtID.Text = employeeID.ToString();
            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
            txtDate.Text = date.ToString("yyyy-MM-dd");
            txtTimeIn.Text = timeIn;
            txtTimeOut.Text = timeOut;
            txtWorkHours.Text = workHours;
            txtLeave.Text = leave;
            txtHourlyRate.Text = hourlyRate;
            txtTotal.Text = total;

            // Initial calculation on load
            CalculateWorkHoursAndTotal();
        }
        private void txtTimeIn_TextChanged(object sender, EventArgs e)
        {
            // Validate and format time as hh:mm:ss
            if (txtTimeIn.Text.Length == 5 && !txtTimeIn.Text.Contains(":00"))
            {
                txtTimeIn.Text += ":00";  // Append :00 if it's in hh:mm format
                txtTimeIn.SelectionStart = txtTimeIn.Text.Length;  // Keep cursor at the end
            }
            CalculateWorkHoursAndTotal();
        }
        private void txtTimeOut_TextChanged(object sender, EventArgs e)
        {
            // Validate and format time as hh:mm:ss
            if (txtTimeOut.Text.Length == 5 && !txtTimeOut.Text.Contains(":00"))
            {
                txtTimeOut.Text += ":00";  // Append :00 if it's in hh:mm format
                txtTimeOut.SelectionStart = txtTimeOut.Text.Length;  // Keep cursor at the end
            }
            CalculateWorkHoursAndTotal();
        }
        private void CalculateWorkHoursAndTotal()
        {
            // Validate the input values for TimeIN and TimeOUT
            if (DateTime.TryParse(txtTimeIn.Text, out DateTime timeIn) &&
                DateTime.TryParse(txtTimeOut.Text, out DateTime timeOut))
            {
                // Calculate the difference between TimeIN and TimeOUT (WorkHours)
                TimeSpan workDuration = timeOut - timeIn;
                double workHours = workDuration.TotalHours;

                // Set WorkHours in the appropriate TextBox
                txtWorkHours.Text = workHours.ToString("0.##");

                // Calculate the Total (WorkHours * HourlyRate)
                if (double.TryParse(txtHourlyRate.Text, out double hourlyRate))
                {
                    double total = workHours * hourlyRate;

                    // Set the Total in the appropriate TextBox
                    txtTotal.Text = total.ToString("0.##");
                }
            }
            else
            {
                // Handle invalid input or reset the fields if needed
                txtWorkHours.Text = "0";
                txtTotal.Text = "0";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=JP_F15\\SQLEXPRESS;Initial Catalog=SWD606;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    string query = "UPDATE Payroll SET FirstName = @FirstName, LastName = @LastName, Date = @Date, TimeIN = @TimeIN, TimeOUT = @TimeOUT, " +
                                   "WorkHours = @WorkHours, Leave = @Leave, HourlyRate = @HourlyRate, Total = @Total WHERE PID = @PID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@Date", DateTime.Parse(txtDate.Text));
                        cmd.Parameters.AddWithValue("@TimeIN", txtTimeIn.Text);
                        cmd.Parameters.AddWithValue("@TimeOUT", txtTimeOut.Text);
                        cmd.Parameters.AddWithValue("@WorkHours", txtWorkHours.Text);
                        cmd.Parameters.AddWithValue("@Leave", txtLeave.Text);
                        cmd.Parameters.AddWithValue("@HourlyRate", txtHourlyRate.Text);
                        cmd.Parameters.AddWithValue("@Total", txtTotal.Text);
                        cmd.Parameters.AddWithValue("@PID", payrollID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Payroll record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Close the form after saving
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the payroll record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the payroll record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
