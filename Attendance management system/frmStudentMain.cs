using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;

namespace Attendance_management_system
{
    public partial class frmStudentMain : Form
    {
        public frmStudentMain()
        {
            InitializeComponent();
            btndashboard.Focus();
            btndashboard.Select();
        }

        string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";

        frmdashboard dashboard = null;
        frmstudent student = null;
        frmStudentAttendance StudentAtd = null;
       
        private void DashboardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmStudentMain_Load(object sender, EventArgs e)
        {
            StudentloginMain();

            btndashboard.Focus();
            btndashboard.Select();

            frmdashboard dashboard = new frmdashboard();
            dashboard.TopLevel = false;
            dashboard.Dock = DockStyle.Fill;
            dashboard.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(dashboard);
            dashboard.Show();
        }

        public void StudentloginMain()
        {
            StudentAtd = new frmStudentAttendance();

            StudentName.Text = Student_Name.SName;

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string query = "SELECT STUDENTID FROM StudentLogin WHERE USERNAME = @Username";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", Student_Name.SName);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string studentID = reader["STUDENTID"].ToString();
                            StudentID.Text = studentID;

                           // StudentAtd.SetStudentID(studentID);
                        }
                        else
                        {
                            System.Windows.MessageBox.Show("Username not found in the database.");
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.ToString());
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click_1(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
        }

        private void btnattendance_Click(object sender, EventArgs e)
        {
            SidebarAttendance.Visible = true;

            SidebarDashboard.Visible = false;
            SidebarStudents.Visible = false;
            SidebarLogout.Visible = false;

            StudentAtd = new frmStudentAttendance();

            if (student != null)
            {
                student.Close();
                student = null;
            }

            StudentAtd.TopLevel = false;
            StudentAtd.Dock = DockStyle.Fill;
            StudentAtd.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(StudentAtd);
            StudentAtd.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            /*SidebarStudents.Visible = true;

            SidebarDashboard.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarLogout.Visible = false;

            student = new frmstudent();

            if (StudentAtd != null)
            {
                StudentAtd.Close();
                StudentAtd = null;
              
            }

            student.TopLevel = false;
            student.Dock = DockStyle.Fill;
            student.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(student);
            student.Show();*/
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            SidebarDashboard.Visible = true;

            SidebarStudents.Visible = false;
            SidebarAttendance.Visible = false;
            SidebarLogout.Visible = false;


            dashboard = new frmdashboard();

            if (student != null && StudentAtd != null)
            {
                StudentAtd.Close();
                student.Close();
                student = null;
                StudentAtd = null;
            }

            dashboard.TopLevel = false;
            dashboard.Dock = DockStyle.Fill;
            dashboard.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStudentMain_Activated(object sender, EventArgs e)
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
