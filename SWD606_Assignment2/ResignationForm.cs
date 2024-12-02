using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SWD606_Assignment2
{
    public partial class ResignationForm : Form
    {
        private SqlCommand command;
        private SqlConnection connection;
        private string FirstName;
        private string LastName;
        private int ID;

        public ResignationForm()
        {
            InitializeComponent();
        }

        private void OpenConnection()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["databaseConnect"].ConnectionString;
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open the database connection: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void ResignationForm_Load(object sender, EventArgs e)
        {
            OpenConnection();
        }

        private void GetInfo()
        {
            try
            {
                // Retrieve user data from UserSession
                if (UserSession.Instance == null)
                {
                    MessageBox.Show("User session is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ID = UserSession.Instance.ID;
                FirstName = UserSession.Instance.FirstName;
                //LastName = UserSession.Instance.LastName;

                // Update labels with data from UserSession
                idLabel.Text = ID.ToString(); // Convert int to string
                EFLLabel.Text = $"{FirstName}";

                // Validate data from the database
                FetchDataFromDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FetchDataFromDatabase()
        {
            try
            {
                string query = "SELECT FirstName, LastName FROM Employees WHERE ID = @ID;";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", ID);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        FirstName = reader["FirstName"].ToString();
                        LastName = reader["LastName"].ToString();

                        // Update labels with fetched data
                        EFLLabel.Text = $"{FirstName} - {LastName}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to fetch data from the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResignationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close the database connection when the form is closed
            CloseConnection();
        }

        private void EFLLabel_Click(object sender, EventArgs e)
        {
            GetInfo();
        }
    }
}
