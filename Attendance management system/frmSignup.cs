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
    public partial class frmSignup : Form
    {
        public frmSignup()
        {
            InitializeComponent();
            txtusername.Select();
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string email = txtemail.Text;
            string password = txtpassword.Text;

            try
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please fill all fields");
                    return;
                }

                string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    // Check if the user already exists
                    string checkQuery = "SELECT COUNT(*) FROM Attendance_Managment_Login_server WHERE EMAIL = @Email";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        int existingUserCount = (int)checkCmd.ExecuteScalar();

                        if (existingUserCount > 0)
                        {
                            MessageBox.Show("User already exists. Please choose a different email.", "Sign Up", MessageBoxButtons.OK);
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO Attendance_Managment_Login_server (USERNAME, EMAIL, PASSWORD) VALUES (@Username, @Email, @Password)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Sign Up Successful, please Sign in Now", "Sign Up", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

      

        private void btnsignin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // it will load login form 

            frmLogin Login = new frmLogin();
            Login.Show();
            this.Hide();
        }

   

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
