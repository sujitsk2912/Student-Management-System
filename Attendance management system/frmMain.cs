using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Attendance_management_system
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            btndashboard.Focus();
            btndashboard.Select();
        }

        bool AttendanceCollapse;

        frmdashboard dashboard = null;
        frmstudent student = null;
        frmfaculty faculty = null;
        frmnewlogin login = null;
        frmnewsignup signup = null;
        frmattendance attendance = null;
        frmAttendanceRecord attendanceRecord = null;
        frmadmission admission = null;
        frmAdmissionRecord admissionRecord = null;
        frmresults results = null;


        private void btnstudent_Click(object sender, EventArgs e)
        {
            student = new frmstudent();

            if (admissionRecord != null && attendanceRecord != null && attendance != null && faculty != null && admission != null && results != null)
            {
                attendance.Close();
                faculty.Close();
                admission.Close();
                results.Close();
                attendanceRecord.Close();
                admissionRecord.Close();
                admissionRecord = null;
                attendanceRecord = null;
                results = null;
                attendance = null;
                admission = null;
                faculty = null;
            }

            student.TopLevel = false;
            student.Dock = DockStyle.Fill;
            student.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(student);
            student.Show();
        }

  

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            results = new frmresults();

            if (admissionRecord != null && attendanceRecord != null && attendance != null && student != null && admission != null && faculty != null)
            {
                attendance.Close();
                student.Close();
                admission.Close();
                faculty.Close();
                attendanceRecord.Close();
                admissionRecord.Close();
                admissionRecord = null;
                attendanceRecord = null;
                attendance = null;
                admission = null;
                student = null;
                faculty = null;
            }

            results.TopLevel = false;
            results.Dock = DockStyle.Fill;
            results.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(results);
            results.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            sidebartransition.Start();
        }

        bool sidebarExpand = true;
        private void sidebartransition_Tick(object sender, EventArgs e)
        {/*
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 70)
                {
                    sidebarExpand = false;
                    sidebartransition.Stop();
                    *//* panel3.Width = sidebar.Width;
                     btnsetting.Width = sidebar.Width;
                     btnlogin.Width = sidebar.Width;
                     btnadmin.Width = sidebar.Width;
                     btnabout.Width = sidebar.Width;*//*
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 230)
                {
                    sidebarExpand = true;
                    sidebartransition.Stop();
                    *//* panel3.Width = sidebar.Width;
                     btnsetting.Width = sidebar.Width;
                     btnlogin.Width = sidebar.Width;
                     btnadmin.Width = sidebar.Width;
                     btnabout.Width = sidebar.Width;*//*
                }
            }*/
        }
    

        private void frmMain_Load(object sender, EventArgs e)
        {
            btndashboard.Focus();
            btndashboard.Select();

            frmdashboard dashboard = new frmdashboard();
            dashboard.TopLevel = false;
            dashboard.Dock = DockStyle.Fill;
            dashboard.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(dashboard);
            dashboard.Show();

            // this show Administator name Here

            AdminName.Text = Administrator_Name.Name;

        }


        private void bunifuPictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            login = new frmnewlogin();

            DialogResult result = MessageBox.Show("Do you want to Log Out? ", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                login.Show();
                this.Hide();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            login = new frmnewlogin();

            DialogResult result = MessageBox.Show("Do you want to Log Out? ", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                login.Show();
                this.Hide();
            }
        }


        private void btnfaculty_Click_2(object sender, EventArgs e)
        {
            SidebarFaculty.Visible = true;

            SidebarDashboard.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAdmission.Visible = false;
            SidebarAdmissionRecord.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;

            faculty = new frmfaculty();

            if (admissionRecord != null && attendanceRecord != null && results != null && student != null && attendance != null && admission != null)
            {
                student.Close();
                attendance.Close();
                admission.Close();
                results.Close();
                attendanceRecord.Close();
                admissionRecord.Close();
                admissionRecord = null;
                attendanceRecord = null;
                results = null;
                student = null;
                admission = null;
                attendance = null;
            }

            faculty.TopLevel = false;
            faculty.Dock = DockStyle.Fill;
            faculty.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(faculty);
            faculty.Show();
        }

        private void btnadmission_Click_2(object sender, EventArgs e)
        {
            SidebarAdmission.Visible = true;

            SidebarDashboard.Visible = false;
            SidebarFaculty.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAdmissionRecord.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;

            admission = new frmadmission();

            if (admissionRecord != null && attendanceRecord != null && results != null && student != null && faculty != null && attendance != null)
            {
                student.Close();
                faculty.Close();
                attendance.Close();
                results.Close();
                attendanceRecord.Close();
                admissionRecord.Close();
                admissionRecord = null;
                attendanceRecord = null;
                results = null;
                faculty = null;
                attendance = null;
                student = null;
            }

            admission.TopLevel = false;
            admission.Dock = DockStyle.Fill;
            admission.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(admission);
            admission.Show();
        }


        private void btnstudent_Click_2(object sender, EventArgs e)
        {
            SidebarStudents.Visible = true;

            SidebarDashboard.Visible = false;
            SidebarFaculty.Visible = false;
            SidebarAdmission.Visible = false;
            SidebarAdmissionRecord.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;

            student = new frmstudent();

            if (admissionRecord != null && attendanceRecord != null && results != null && attendance != null && faculty != null && admission != null)
            {
                attendance.Close();
                faculty.Close();
                admission.Close();
                results.Close();
                attendanceRecord.Close();
                admissionRecord.Close();
                admissionRecord = null;
                attendanceRecord = null;
                results = null;
                attendance = null;
                admission = null;
                faculty = null;
            }

            student.TopLevel = false;
            student.Dock = DockStyle.Fill;
            student.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(student);
            student.Show();
        }

        private void btnlogout_Click_2(object sender, EventArgs e)
        {
            SidebarLogout.Visible = true;

            SidebarFaculty.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAdmission.Visible = false;
            SidebarAdmissionRecord.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarDashboard.Visible = false;
            SidebarResults.Visible = false;


            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
        }


        private void btnadmissionRecord_Click_2(object sender, EventArgs e)
        {
            SidebarAdmissionRecord.Visible = true;

            SidebarDashboard.Visible = false;
            SidebarFaculty.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAdmission.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;

            admissionRecord = new frmAdmissionRecord();

            if (attendanceRecord != null && student != null && attendance != null && faculty != null && admission != null && results != null)
            {
                attendance.Close();
                faculty.Close();
                admission.Close();
                results.Close();
                student.Close();
                attendanceRecord.Close();
                attendanceRecord = null;
                student = null;
                results = null;
                attendance = null;
                admission = null;
                faculty = null;
            }

            admissionRecord.TopLevel = false;
            admissionRecord.Dock = DockStyle.Fill;
            admissionRecord.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(admissionRecord);
            admissionRecord.Show();
        }

        private void btnattendance_Click_3(object sender, EventArgs e)
        {
            SidebarAttendance.Visible = true;

            SidebarDashboard.Visible = false;
            SidebarFaculty.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAdmission.Visible = false;
            SidebarAdmissionRecord.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;

            attendance = new frmattendance();

            if (admissionRecord != null && attendanceRecord != null && results != null && student != null && faculty != null && admission != null)
            {
                student.Close();
                faculty.Close();
                admission.Close();
                results.Close();
                attendanceRecord.Close();
                admissionRecord.Close();
                admissionRecord = null;
                attendanceRecord = null;
                results = null;
                student = null;
                admission = null;
                faculty = null;
            }

            attendance.TopLevel = false;
            attendance.Dock = DockStyle.Fill;
            attendance.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(attendance);
            attendance.Show();

        }

        private void btnattendanceRecord_Click_3(object sender, EventArgs e)
        {
            SidebarAttendanceRecord.Visible = true;

            SidebarDashboard.Visible = false;
            SidebarFaculty.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAdmission.Visible = false;
            SidebarAdmissionRecord.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;

            attendanceRecord = new frmAttendanceRecord();

            if (admissionRecord != null && student != null && attendance != null && faculty != null && admission != null && results != null)
            {
                attendance.Close();
                faculty.Close();
                admission.Close();
                results.Close();
                student.Close();
                admissionRecord.Close();
                admissionRecord = null;
                student = null;
                results = null;
                attendance = null;
                admission = null;
                faculty = null;
            }

            attendanceRecord.TopLevel = false;
            attendanceRecord.Dock = DockStyle.Fill;
            attendanceRecord.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(attendanceRecord);
            attendanceRecord.Show();
        }

        private void btnresults_Click_2(object sender, EventArgs e)
        {
            SidebarResults.Visible = true;

            SidebarFaculty.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAdmission.Visible = false;
            SidebarAdmissionRecord.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarDashboard.Visible = false;
            SidebarLogout.Visible = false;
        }

        private void btndashboard_Click_2(object sender, EventArgs e)
        {
            SidebarDashboard.Visible = true;

            SidebarFaculty.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAdmission.Visible = false;
            SidebarAdmissionRecord.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;


            dashboard = new frmdashboard();

            if (admissionRecord != null && attendanceRecord != null && student != null && attendance != null && faculty != null && admission != null && results != null)
            {
                attendance.Close();
                faculty.Close();
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
                faculty = null;
            }

            dashboard.TopLevel = false;
            dashboard.Dock = DockStyle.Fill;
            dashboard.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void btndashboard1_Click(object sender, EventArgs e)
        {
            SidebarDashboard.Visible = true;

            SidebarFaculty.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAdmission.Visible = false;
            SidebarAdmissionRecord.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;


            dashboard = new frmdashboard();

            if (admissionRecord != null && attendanceRecord != null && student != null && attendance != null && faculty != null && admission != null && results != null)
            {
                attendance.Close();
                faculty.Close();
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
                faculty = null;
            }

            dashboard.TopLevel = false;
            dashboard.Dock = DockStyle.Fill;
            dashboard.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void btnfaculty1_Click(object sender, EventArgs e)
        {
            SidebarFaculty.Visible = true;

            SidebarDashboard.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAdmission.Visible = false;
            SidebarAdmissionRecord.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;

            faculty = new frmfaculty();

            if (admissionRecord != null && attendanceRecord != null && results != null && student != null && attendance != null && admission != null)
            {
                student.Close();
                attendance.Close();
                admission.Close();
                results.Close();
                attendanceRecord.Close();
                admissionRecord.Close();
                admissionRecord = null;
                attendanceRecord = null;
                results = null;
                student = null;
                admission = null;
                attendance = null;
            }

            faculty.TopLevel = false;
            faculty.Dock = DockStyle.Fill;
            faculty.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(faculty);
            faculty.Show();
        }

        private void btnstudent1_Click(object sender, EventArgs e)
        {
            SidebarStudents.Visible = true;

            SidebarDashboard.Visible = false;
            SidebarFaculty.Visible = false;
            SidebarAdmission.Visible = false;
            SidebarAdmissionRecord.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;

            student = new frmstudent();

            if (admissionRecord != null && attendanceRecord != null && results != null && attendance != null && faculty != null && admission != null)
            {
                attendance.Close();
                faculty.Close();
                admission.Close();
                results.Close();
                attendanceRecord.Close();
                admissionRecord.Close();
                admissionRecord = null;
                attendanceRecord = null;
                results = null;
                attendance = null;
                admission = null;
                faculty = null;
            }

            student.TopLevel = false;
            student.Dock = DockStyle.Fill;
            student.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(student);
            student.Show();
        }

        private void btnadmission1_Click(object sender, EventArgs e)
        {
            SidebarAdmission.Visible = true;

            SidebarDashboard.Visible = false;
            SidebarFaculty.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAdmissionRecord.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;

            admission = new frmadmission();

            if (admissionRecord != null && attendanceRecord != null && results != null && student != null && faculty != null && attendance != null)
            {
                student.Close();
                faculty.Close();
                attendance.Close();
                results.Close();
                attendanceRecord.Close();
                admissionRecord.Close();
                admissionRecord = null;
                attendanceRecord = null;
                results = null;
                faculty = null;
                attendance = null;
                student = null;
            }

            admission.TopLevel = false;
            admission.Dock = DockStyle.Fill;
            admission.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(admission);
            admission.Show();
        }

        private void btnadmissionRecord1_Click(object sender, EventArgs e)
        {
            SidebarAdmissionRecord.Visible = true;

            SidebarDashboard.Visible = false;
            SidebarFaculty.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAdmission.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;

            admissionRecord = new frmAdmissionRecord();

            if (attendanceRecord != null && student != null && attendance != null && faculty != null && admission != null && results != null)
            {
                attendance.Close();
                faculty.Close();
                admission.Close();
                results.Close();
                student.Close();
                attendanceRecord.Close();
                attendanceRecord = null;
                student = null;
                results = null;
                attendance = null;
                admission = null;
                faculty = null;
            }

            admissionRecord.TopLevel = false;
            admissionRecord.Dock = DockStyle.Fill;
            admissionRecord.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(admissionRecord);
            admissionRecord.Show();
        }

        private void btnattendance1_Click(object sender, EventArgs e)
        {
            SidebarAttendance.Visible = true;

            SidebarDashboard.Visible = false;
            SidebarFaculty.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAdmission.Visible = false;
            SidebarAdmissionRecord.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;

            attendance = new frmattendance();

            if (admissionRecord != null && attendanceRecord != null && results != null && student != null && faculty != null && admission != null)
            {
                student.Close();
                faculty.Close();
                admission.Close();
                results.Close();
                attendanceRecord.Close();
                admissionRecord.Close();
                admissionRecord = null;
                attendanceRecord = null;
                results = null;
                student = null;
                admission = null;
                faculty = null;
            }

            attendance.TopLevel = false;
            attendance.Dock = DockStyle.Fill;
            attendance.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(attendance);
            attendance.Show();
        }

        private void btnattendanceRecord1_Click(object sender, EventArgs e)
        {
            SidebarAttendanceRecord.Visible = true;

            SidebarDashboard.Visible = false;
            SidebarFaculty.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAdmission.Visible = false;
            SidebarAdmissionRecord.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;

            attendanceRecord = new frmAttendanceRecord();

            if (admissionRecord != null && student != null && attendance != null && faculty != null && admission != null && results != null)
            {
                attendance.Close();
                faculty.Close();
                admission.Close();
                results.Close();
                student.Close();
                admissionRecord.Close();
                admissionRecord = null;
                student = null;
                results = null;
                attendance = null;
                admission = null;
                faculty = null;
            }

            attendanceRecord.TopLevel = false;
            attendanceRecord.Dock = DockStyle.Fill;
            attendanceRecord.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(attendanceRecord);
            attendanceRecord.Show();
        }

        private void btnresults1_Click(object sender, EventArgs e)
        {
            SidebarResults.Visible = true;

            SidebarFaculty.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAdmission.Visible = false;
            SidebarAdmissionRecord.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarDashboard.Visible = false;
            SidebarLogout.Visible = false;
        }

        private void btnlogout1_Click(object sender, EventArgs e)
        {
            SidebarLogout.Visible = true;

            SidebarFaculty.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAdmission.Visible = false;
            SidebarAdmissionRecord.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarDashboard.Visible = false;
            SidebarResults.Visible = false;


            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
        }


        private void btndashboard1_Click_1(object sender, EventArgs e)
        {
            SidebarDashboard.Visible = true;

            SidebarFaculty.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAdmission.Visible = false;
            SidebarAdmissionRecord.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;


            dashboard = new frmdashboard();

            if (admissionRecord != null && attendanceRecord != null && student != null && attendance != null && faculty != null && admission != null && results != null)
            {
                attendance.Close();
                faculty.Close();
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
                faculty = null;
            }

            dashboard.TopLevel = false;
            dashboard.Dock = DockStyle.Fill;
            dashboard.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void btnfaculty1_Click_1(object sender, EventArgs e)
        {
            SidebarFaculty.Visible = true;

            SidebarDashboard.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAdmission.Visible = false;
            SidebarAdmissionRecord.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;

            faculty = new frmfaculty();

            if (admissionRecord != null && attendanceRecord != null && results != null && student != null && attendance != null && admission != null)
            {
                student.Close();
                attendance.Close();
                admission.Close();
                results.Close();
                attendanceRecord.Close();
                admissionRecord.Close();
                admissionRecord = null;
                attendanceRecord = null;
                results = null;
                student = null;
                admission = null;
                attendance = null;
            }
            
            faculty.TopLevel = false;
            faculty.Dock = DockStyle.Fill;
            faculty.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(faculty);
            faculty.Show();
        }

        private void btnstudent1_Click_1(object sender, EventArgs e)
        {
            SidebarStudents.Visible = true;

            SidebarDashboard.Visible = false;
            SidebarFaculty.Visible = false;
            SidebarAdmission.Visible = false;
            SidebarAdmissionRecord.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;

            student = new frmstudent();

            if (admissionRecord != null && attendanceRecord != null && results != null && attendance != null && faculty != null && admission != null)
            {
                attendance.Close();
                faculty.Close();
                admission.Close();
                results.Close();
                attendanceRecord.Close();
                admissionRecord.Close();
                admissionRecord = null;
                attendanceRecord = null;
                results = null;
                attendance = null;
                admission = null;
                faculty = null;
            }

            student.TopLevel = false;
            student.Dock = DockStyle.Fill;
            student.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(student);
            student.Show();
        }

        private void btnadmission1_Click_1(object sender, EventArgs e)
        {
            SidebarAdmission.Visible = true;

            SidebarDashboard.Visible = false;
            SidebarFaculty.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAdmissionRecord.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;

            admission = new frmadmission();

            if (admissionRecord != null && attendanceRecord != null && results != null && student != null && faculty != null && attendance != null)
            {
                student.Close();
                faculty.Close();
                attendance.Close();
                results.Close();
                attendanceRecord.Close();
                admissionRecord.Close();
                admissionRecord = null;
                attendanceRecord = null;
                results = null;
                faculty = null;
                attendance = null;
                student = null;
            }

            admission.TopLevel = false;
            admission.Dock = DockStyle.Fill;
            admission.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(admission);
            admission.Show();
        }

        private void btnadmissionRecord1_Click_1(object sender, EventArgs e)
        {
            SidebarAdmissionRecord.Visible = true;

            SidebarDashboard.Visible = false;
            SidebarFaculty.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAdmission.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;

            admissionRecord = new frmAdmissionRecord();

            if (attendanceRecord != null && student != null && attendance != null && faculty != null && admission != null && results != null)
            {
                attendance.Close();
                faculty.Close();
                admission.Close();
                results.Close();
                student.Close();
                attendanceRecord.Close();
                attendanceRecord = null;
                student = null;
                results = null;
                attendance = null;
                admission = null;
                faculty = null;
            }

            admissionRecord.TopLevel = false;
            admissionRecord.Dock = DockStyle.Fill;
            admissionRecord.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(admissionRecord);
            admissionRecord.Show();
        }

        private void btnattendance1_Click_1(object sender, EventArgs e)
        {
            SidebarAttendance.Visible = true;

            SidebarDashboard.Visible = false;
            SidebarFaculty.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAdmission.Visible = false;
            SidebarAdmissionRecord.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;

            attendance = new frmattendance();

            if (admissionRecord != null && attendanceRecord != null && results != null && student != null && faculty != null && admission != null)
            {
                student.Close();
                faculty.Close();
                admission.Close();
                results.Close();
                attendanceRecord.Close();
                admissionRecord.Close();
                admissionRecord = null;
                attendanceRecord = null;
                results = null;
                student = null;
                admission = null;
                faculty = null;
            }

            attendance.TopLevel = false;
            attendance.Dock = DockStyle.Fill;
            attendance.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(attendance);
            attendance.Show();
        }

        private void btnattendanceRecord1_Click_1(object sender, EventArgs e)
        {
            SidebarAttendanceRecord.Visible = true;

            SidebarDashboard.Visible = false;
            SidebarFaculty.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAdmission.Visible = false;
            SidebarAdmissionRecord.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarResults.Visible = false;
            SidebarLogout.Visible = false;

            attendanceRecord = new frmAttendanceRecord();

            if (admissionRecord != null && student != null && attendance != null && faculty != null && admission != null && results != null)
            {
                attendance.Close();
                faculty.Close();
                admission.Close();
                results.Close();
                student.Close();
                admissionRecord.Close();
                admissionRecord = null;
                student = null;
                results = null;
                attendance = null;
                admission = null;
                faculty = null;
            }

            attendanceRecord.TopLevel = false;
            attendanceRecord.Dock = DockStyle.Fill;
            attendanceRecord.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(attendanceRecord);
            attendanceRecord.Show();
        }

        private void btnresults1_Click_1(object sender, EventArgs e)
        {
            SidebarResults.Visible = true;

            SidebarFaculty.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAdmission.Visible = false;
            SidebarAdmissionRecord.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarDashboard.Visible = false;
            SidebarLogout.Visible = false;
        }

        private void btnlogout1_Click_1(object sender, EventArgs e)
        {
            SidebarLogout.Visible = true;

            SidebarFaculty.Visible = false;
            SidebarStudents.Visible = false;
            SidebarAdmission.Visible = false;
            SidebarAdmissionRecord.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarAttendanceRecord.Visible = false;
            SidebarDashboard.Visible = false;
            SidebarResults.Visible = false;


            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick_2(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("G");
        }
    }
}
