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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Attendance_management_system
{
    public partial class frmForget : Form
    {
        public frmForget()
        {
            InitializeComponent();
            txtemail.Select();
        }

        string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";

      
        private void btnsignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // it will open signup form

            frmSignup Signup = new frmSignup();
            Signup.Show();
            this.Hide();
        }

        private void btnsignin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // it will open login form

            frmLogin Login = new frmLogin();
            Login.Show();
            this.Hide();
        }

    

        private void btnminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            
            bool userFound = false;  // Flag variable to track if the user is found

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    // Check Student Login
                    string studentQuery = "SELECT USERNAME, PASSWORD FROM StudentLogin WHERE EMAIL = @Email";
                    userFound |= CheckAndShowLoginData(conn, studentQuery, email);

                    // Check Staff Login
                    string staffQuery = "SELECT USERNAME, PASSWORD FROM StaffLogin WHERE EMAIL = @Email";
                    userFound |= CheckAndShowLoginData(conn, staffQuery, email);

                    // Check Admin Login
                    string adminQuery = "SELECT USERNAME, PASSWORD FROM AdminLogin WHERE EMAIL = @Email";
                    userFound |= CheckAndShowLoginData(conn, adminQuery, email);
                }

                if (!userFound)
                {
                    MessageBox.Show("User not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CheckAndShowLoginData(SqlConnection conn, string query, string email)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.SelectCommand.Parameters.AddWithValue("@Email", email);

                DataTable data = new DataTable();
                sda.Fill(data);

                if (data.Rows.Count > 0)
                {
                    string username = data.Rows[0]["USERNAME"].ToString();
                    string password = data.Rows[0]["PASSWORD"].ToString();

                    MessageBox.Show($"Username: {username}\nPassword: {password}");
                    return true;  // User found in this table
                }

                return false;  // User not found in this table
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;  // Assume user not found in case of an exception
            }
        }
    }
}
