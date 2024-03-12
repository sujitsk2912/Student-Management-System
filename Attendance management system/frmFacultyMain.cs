using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_management_system
{
    public partial class frmFacultyMain : Form
    {
        public frmFacultyMain()
        {
            InitializeComponent();
            btndashboard.Focus();
            btndashboard.Select();
        }

        frmdashboard dashboard = null;
        frmstudent student = null;
        frmattendance attendance = null;
        frmAttendanceRecord attendanceRecord = null;
        frmadmission admission = null;
        frmAdmissionRecord admissionRecord = null;
        frmresults results = null;

        string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";

      
        private void btndashboard_Click(object sender, EventArgs e)
        {
            SidebarDashboard.Visible = true;

            SidebarStudents.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;


            dashboard = new frmdashboard();

            if (admissionRecord != null && attendanceRecord != null && student != null && attendance != null && admission != null && results != null)
            {
                attendance.Close();
                admission.Close();
                results.Close();
                student.Close();
                attendanceRecord.Close();
                admissionRecord.Close();
                admissionRecord = null;
                attendanceRecord = null;
                student = null;
                results = null;
                attendance = null;
                admission = null;
            }

            dashboard.TopLevel = false;
            dashboard.Dock = DockStyle.Fill;
            dashboard.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(dashboard);
            dashboard.Show();
        }

     

        private void btnstudent_Click(object sender, EventArgs e)
        {
            SidebarStudents.Visible = true;

            SidebarDashboard.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;

            student = new frmstudent();

            if (admissionRecord != null && attendanceRecord != null && results != null && attendance != null && admission != null)
            {
                attendance.Close();
                admission.Close();
                results.Close();
                attendanceRecord.Close();
                admissionRecord.Close();
                admissionRecord = null;
                attendanceRecord = null;
                results = null;
                attendance = null;
                admission = null;
            }

            student.TopLevel = false;
            student.Dock = DockStyle.Fill;
            student.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(student);
            student.Show();
        }

        private void btnattendance_Click(object sender, EventArgs e)
        {
            SidebarAttendance.Visible = true;

            SidebarDashboard.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;

            attendance = new frmattendance();

            if (admissionRecord != null && attendanceRecord != null && results != null && student != null && admission != null)
            {
                student.Close();
                admission.Close();
                results.Close();
                attendanceRecord.Close();
                admissionRecord.Close();
                admissionRecord = null;
                attendanceRecord = null;
                results = null;
                student = null;
                admission = null;
            }

            attendance.TopLevel = false;
            attendance.Dock = DockStyle.Fill;
            attendance.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(attendance);
            attendance.Show();
        }

        private void btnattendanceRecord_Click(object sender, EventArgs e)
        {
            SidebarAttendanceRecord.Visible = true;

            SidebarDashboard.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;

            attendanceRecord = new frmAttendanceRecord();

            if (admissionRecord != null && student != null && attendance != null && admission != null && results != null)
            {
                attendance.Close();
                admission.Close();
                results.Close();
                student.Close();
                admissionRecord.Close();
                admissionRecord = null;
                student = null;
                results = null;
                attendance = null;
                admission = null;
            }

            attendanceRecord.TopLevel = false;
            attendanceRecord.Dock = DockStyle.Fill;
            attendanceRecord.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(attendanceRecord);
            attendanceRecord.Show();
        }

        private void btnresults_Click(object sender, EventArgs e)
        {
            SidebarResults.Visible = true;

            SidebarStudents.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarDashboard.Visible = false;
            SidebarLogout.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            SidebarLogout.Visible = true;

            SidebarStudents.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarDashboard.Visible = false;
            SidebarResults.Visible = false;


            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
        }

      

        private void frmFacultyMain_Load(object sender, EventArgs e)
        {
            btndashboard.Focus();
            btndashboard.Select();

            frmdashboard dashboard = new frmdashboard();
            dashboard.TopLevel = false;
            dashboard.Dock = DockStyle.Fill;
            dashboard.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(dashboard);
            dashboard.Show();

            DisplayStaffData();
        }

        public void DisplayStaffData()
        {
            StaffName.Text = Staff_Name.Name;

            FacutyID.Text = Staff_ID.FID;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "SELECT FACULTYID FROM StaffLogin WHERE USERNAME = @Username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", Staff_Name.Name);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string facultyIDFromDB = reader["FACULTYID"].ToString();
                        FacutyID.Text = facultyIDFromDB;
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Username not found in the database.");
                    }

                    reader.Close();
                }
            }
        }

        private void frmFacultyMain_Activated(object sender, EventArgs e)
        {
           timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("d");
            labelTime.Text = DateTime.Now.ToString("T");
        }
    }
}
