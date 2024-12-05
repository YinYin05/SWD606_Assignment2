using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWD606_Assignment2
{
    public partial class employeeDashboard : Form
    {
        string FirstName;
        string Email;
        string Role;
        int id;
        string LeaveStatus;
        string Address;
        string LastName;
        string Phone;
        decimal HourlyRate;

        SqlCommand command;
        SqlConnection connection;

        //declaring forms
        private EmployeeSettingsForm settingsForm_Vrb;
        private ResignationForm resignationForm_Vrb;
        private GrievancesForm grievancesForm_Vrb;
        public LeaveForm leaveForm_Vrb;
        private PayrollForm payrollForm_Vrb;

        public employeeDashboard()
        {
            InitializeComponent();
            pnlNav.Height = PayrollBTN.Height;
            pnlNav.Top = PayrollBTN.Top;
            pnlNav.Left = PayrollBTN.Left;


        }
        private void employeeDashboard_Load(object sender, EventArgs e)
        {
            OpenConnection();
            GetInfo();
        }

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
            labelFN.Text = "Hello " + FirstName;
        }

        //Displaying users name
        private void label1_Click(object sender, EventArgs e)
        {
            GetInfo();
        }

        // ----------- Payroll form ------------
        private void PayrollBTN_Click(object sender, EventArgs e)
        {
            pnlNav.Height = PayrollBTN.Height;
            pnlNav.Top = PayrollBTN.Top;
            pnlNav.Left = PayrollBTN.Left;

            labelTitle.Text = "Payroll";

            // Clear previous controls and dispose of them
            foreach (Control control in PnlFormLoader.Controls)
            {
                control.Dispose();
            }
            PnlFormLoader.Controls.Clear();

            // Check if the form is already created, reuse it
            if (payrollForm_Vrb == null || payrollForm_Vrb.IsDisposed)
            {
                payrollForm_Vrb = new PayrollForm
                {
                    TopLevel = false, // This makes it a child control
                    Dock = DockStyle.Fill,
                    FormBorderStyle = FormBorderStyle.None
                };
            }

            PnlFormLoader.Controls.Add(payrollForm_Vrb);
            payrollForm_Vrb.Show();
        }

        // ---------- Leave Form -------------
        private void LeaveBTN_Click(object sender, EventArgs e)
        {
            pnlNav.Height = LeaveBTN.Height;
            pnlNav.Top = LeaveBTN.Top;
            pnlNav.Left = LeaveBTN.Left;

            labelTitle.Text = "Request Leave";

            // Clear previous controls and dispose of them
            foreach (Control control in PnlFormLoader.Controls)
            {
                control.Dispose();
            }
            PnlFormLoader.Controls.Clear();

            // Check if the form is already created, reuse it
            if (leaveForm_Vrb == null || leaveForm_Vrb.IsDisposed)
            {
                leaveForm_Vrb = new LeaveForm
                {
                    TopLevel = false, // This makes it a child control
                    Dock = DockStyle.Fill,
                    FormBorderStyle = FormBorderStyle.None
                };
            }

            PnlFormLoader.Controls.Add(leaveForm_Vrb);
            leaveForm_Vrb.Show();
        }

        // -------- Grievances Form -----------
        private void grievancesBTN_Click(object sender, EventArgs e)
        {
            pnlNav.Height = grievancesBTN.Height;
            pnlNav.Top = grievancesBTN.Top;
            pnlNav.Left = grievancesBTN.Left;

            labelTitle.Text = "Voice Grievances";

            // Clear previous controls and dispose of them
            foreach (Control control in PnlFormLoader.Controls)
            {
                control.Dispose();
            }
            PnlFormLoader.Controls.Clear();

            // Check if the form is already created, reuse it
            if (grievancesForm_Vrb == null || grievancesForm_Vrb.IsDisposed)
            {
                grievancesForm_Vrb = new GrievancesForm
                {
                    TopLevel = false, // This makes it a child control
                    Dock = DockStyle.Fill,
                    FormBorderStyle = FormBorderStyle.None
                };
            }

            PnlFormLoader.Controls.Add(grievancesForm_Vrb);
            grievancesForm_Vrb.Show();
        }


        // ----------- Resignation Form -------------

        private void resignBTN_Click(object sender, EventArgs e)
        {
            pnlNav.Height = resignBTN.Height;
            pnlNav.Top = resignBTN.Top;
            pnlNav.Left = resignBTN.Left;

            labelTitle.Text = "Resignation";

            // Clear previous controls and dispose of them
            foreach (Control control in PnlFormLoader.Controls)
            {
                control.Dispose();
            }
            PnlFormLoader.Controls.Clear();

            // Check if the form is already created, reuse it
            if (resignationForm_Vrb == null || resignationForm_Vrb.IsDisposed)
            {
                resignationForm_Vrb = new ResignationForm
                {
                    TopLevel = false, // This makes it a child control
                    Dock = DockStyle.Fill,
                    FormBorderStyle = FormBorderStyle.None
                };
            }

            PnlFormLoader.Controls.Add(resignationForm_Vrb);
            resignationForm_Vrb.Show();
        }

        // ----------- User Information Form --------------

        private void infoBTN_Click(object sender, EventArgs e)
        {
            pnlNav.Height = infoBTN.Height;
            pnlNav.Top = infoBTN.Top;
            pnlNav.Left = infoBTN.Left;

            labelTitle.Text = "Account Information";

            // Clear previous controls and dispose of them
            foreach (Control control in PnlFormLoader.Controls)
            {
                control.Dispose();
            }
            PnlFormLoader.Controls.Clear();

            // Check if the form is already created, reuse it
            if (settingsForm_Vrb == null || settingsForm_Vrb.IsDisposed)
            {
                settingsForm_Vrb = new EmployeeSettingsForm
                {
                    TopLevel = false, // This makes it a child control
                    Dock = DockStyle.Fill,
                    FormBorderStyle = FormBorderStyle.None
                };
            }

            PnlFormLoader.Controls.Add(settingsForm_Vrb);
            settingsForm_Vrb.Show();
        }

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
