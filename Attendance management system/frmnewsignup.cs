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
    public partial class frmnewsignup : Form
    {
        public frmnewsignup()
        {
            InitializeComponent();
        }

        frmactcreate frmactcreate = new frmactcreate();
        private void btnsignup_Click(object sender, EventArgs e)
        {
            string Username = txtusername.Text;
            string Email = txtemail.Text;
            string Password = txtpassword.Text;

            while (true)
            {
                if (Username == "" && Email == "" && Password == "")
                {
                    MessageBox.Show("Please fill all fields");
                    break;
                }
                else if (Username == "")
                {
                    MessageBox.Show("Please enter Username");
                    break;
                }
                else if (Password == "")
                {
                    MessageBox.Show("Please enter Password");
                    break;
                }
                else if (Email == "")
                {
                    MessageBox.Show("Please enter Email");
                    break;
                }
                else
                {
                
                    string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";

                    // 2. establishing connection
                    SqlConnection conn = new SqlConnection(ConnectionString);


                    // 3. Open connection
                    conn.Open();

                    try
                    {
                        // 4. prepare query

                        string Query = "INSERT INTO Attendance_Managment_Login_server (USERNAME, EMAIL, PASSWORD) VALUES ('" + Username + "','" + Email + "','" + Password + "')";

                        // 5. execute query

                        SqlCommand cmd = new SqlCommand(Query, conn);
                        cmd.ExecuteNonQuery();

                        frmactcreate.Show();
                        return;
                        //  MessageBox.Show("Sign Up successfull, please Login Now...");

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        // 6.close connection
                        conn.Close();
                    }
                    
                    // --------------------------------------------
                }
            }
        }

        private void signuplink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmnewlogin Login = new frmnewlogin();
            Login.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
