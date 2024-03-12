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
    public partial class frmnewlogin : Form
    {
        public frmnewlogin()
        {
            InitializeComponent();
            txtusername.Select();
            txtpassword.UseSystemPasswordChar = true;
        }

        frmsuccess frmsuccess = new frmsuccess();
        frmerror frmerror = new frmerror();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginpanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            string Username = txtusername.Text;
            string Password = txtpassword.Text;

            while (true)
            {
                if (Username == "" && Password == "")
                {
                    MessageBox.Show("Please enter Username & Password");
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
                else
                {
                    // 1. address of SQL server and database
                    string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";

                    // 2. establishing connection
                    SqlConnection conn = new SqlConnection(ConnectionString);


                    // 3. Open connection
                    conn.Open();

                    try
                    {
                        // 4. prepare query

                        string Attendance_Managment_Login_server = "SELECT * FROM Attendance_Managment_Login_server WHERE USERNAME = '" + txtusername.Text + "' AND PASSWORD = '" + txtpassword.Text + "'";

                        // 5. execute query

                        SqlDataAdapter sda = new SqlDataAdapter(Attendance_Managment_Login_server, conn);

                        DataTable data = new DataTable();

                        sda.Fill(data);

                        if (data.Rows.Count > 0)
                        {
                            Username = txtusername.Text.Trim();
                            Password = txtpassword.Text.Trim();

                            frmsuccess.Show();
                            Administrator_Name.Name = Username;
                            break;

                        }

                        else
                        {
                            frmerror.Show();
                            break;
                        }
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
                } 
            }
        }

        private void signuplink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmnewsignup f2 = new frmnewsignup();
            f2.Show();
            this.Hide(); 
        }

        private void eyebuttonhide_Click(object sender, EventArgs e)
        {
            
        }

        private void eyebuttonshow_Click(object sender, EventArgs e)
        {
            
        }

        private void eyebuttonshow_Click_1(object sender, EventArgs e)
        {
            eyebuttonshow.Visible = true;
            eyebuttonshow.Focus();
            eyebuttonhide.Focus();
            txtpassword.UseSystemPasswordChar = false;
            txtpassword.PasswordChar = '\0';
            eyebuttonshow.Visible = false;
            eyebuttonhide.Visible = true;
            txtpassword.Focus();
        }

        private void eyebuttonhide_Click_1(object sender, EventArgs e)
        {
            eyebuttonhide.Visible = true;
            eyebuttonhide.Focus();
            eyebuttonshow.Focus();
            txtpassword.UseSystemPasswordChar = true;
            txtpassword.PasswordChar = '\0';
            eyebuttonhide.Visible = false;
            eyebuttonshow.Visible = true;
            txtpassword.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void forgetpassword_Click(object sender, EventArgs e)
        {

        }
    }
}
