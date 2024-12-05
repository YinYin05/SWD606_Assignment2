using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace SWD606_Assignment2
{
    public partial class LeaveManagement : Form
    {
        public LeaveManagement()
        {
            InitializeComponent();
            LoadLeaveData();
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
                    DataTable leaveTable = new DataTable();
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
    }
}
