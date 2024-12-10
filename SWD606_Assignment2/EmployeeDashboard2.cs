using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SWD606_Assignment2
{
    public partial class EmployeeDashboard2 : Form
    {
        string FirstName;
        SqlConnection connection;
        public EmployeeDashboard2()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        //sql extration
        void OpenConnection()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["databaseConnect"].ConnectionString;
            connection = new SqlConnection(connectionstring);
            connection.Open();
        }

        //retriving information from database
        private void GetInfo()
        {
            FirstName = UserSession.Instance.FirstName;
            labelFN.Text = "Hello " + FirstName + "!";

            // Role-specific behavior
            string role = UserSession.Instance.Role;

            if (role == "Manager")
            {
                // Enable and show the manager-specific button
                btnLeaveApprovals.Enabled = true;
                btnLeaveApprovals.Visible = true;
            }
            else if (role == "Employee")
            {
                // Disable and hide the manager-specific button
                btnLeaveApprovals.Enabled = false;
                btnLeaveApprovals.Visible = false;
            }
        }
        private void openchildform(Form childform)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel2.Controls.Add(childform);
            panel2.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }
        private void EmployeeDashboard2_Load(object sender, EventArgs e)
        {
            GetInfo();
        }

        private void PayrollBTN_Click(object sender, EventArgs e)
        {
            openchildform(new SalaryDetails());
        }

        private void RequestLeaveButton_Click(object sender, EventArgs e)
        {
            openchildform(new RequestLeave());
        }

        private void VoiceGrievancesButton_Click(object sender, EventArgs e)
        {
            openchildform(new VoiceGrievances());
        }

        private void OffBoardingButton_Click(object sender, EventArgs e)
        {
            openchildform(new OffBoarding());
        }



        private void btnLeaveApprovals_Click(object sender, EventArgs e)
        {
            // Create an instance of the LeaveManagement form
            LeaveApprovals leaveApprovals = new LeaveApprovals();

            // Show the form
            leaveApprovals.Show();
        }

        private void labelFN_Click(object sender, EventArgs e)
        {

        }

        /*  private void pictureBox1_Click(object sender, EventArgs e)
          {
              Form1 form = new Form1();
              this.Close();
              form.Show();
          }
        */
        /* private void pictureBox1_Click_1(object sender, EventArgs e)
         {
             Form1 form = new Form1();
             this.Close();
             form.Show();
         }
        */

      /*  private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.Show();
        }
      */

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserSession.Instance.ClearSession();
            Form1 form = new Form1();
            this.Close();
            form.Show();
        }
    }
}
