using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MessageBox = System.Windows.Forms.MessageBox;
using System.Windows.Forms;

namespace Attendance_management_system
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtusername.Select();
            txtpassword.UseSystemPasswordChar = true;
        }

        private void eyebuttonhide_Click(object sender, EventArgs e)
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
                    string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(ConnectionString);
                    conn.Open();

                    // read data from Admin database

                    try
                    {
                        string Query = "SELECT * FROM AdminLogin WHERE USERNAME = '" + txtusername.Text + "' AND PASSWORD = '" + txtpassword.Text + "'";
                        string Query1 = "SELECT * FROM StaffLogin WHERE USERNAME = '" + txtusername.Text + "' AND PASSWORD = '" + txtpassword.Text + "'";
                        string Query2 = "SELECT * FROM StudentLogin WHERE USERNAME = '" + txtusername.Text + "' AND PASSWORD = '" + txtpassword.Text + "'";

                        SqlDataAdapter sda = new SqlDataAdapter(Query, conn);

                        DataTable data = new DataTable();

                        sda.Fill(data);

                        if (data.Rows.Count > 0)
                        {
                            Username = txtusername.Text.Trim();
                            Password = txtpassword.Text.Trim();

                            MessageBox.Show("Login Successfull", "Login", MessageBoxButtons.OK);
                            Administrator_Name.Name = Username;

                            //if login successfull it will load the new form i.e Main form

                            frmMain frmMain = new frmMain();
                            frmMain.ShowDialog();
                            this.Close();
                            break;
                        }

                        SqlDataAdapter sda1 = new SqlDataAdapter(Query1, conn);

                        DataTable data1 = new DataTable();

                        sda1.Fill(data1);

                        if (data1.Rows.Count > 0)
                        {
                            Username = txtusername.Text.Trim();
                            Password = txtpassword.Text.Trim();

                            MessageBox.Show("Login Successfully", "Login", MessageBoxButtons.OK);
                            Staff_Name.Name = Username;
                            frmFacultyMain faculty = new frmFacultyMain();
                            faculty.ShowDialog();
                            this.Close();
                            break;
                        }

                        SqlDataAdapter sda2 = new SqlDataAdapter(Query2, conn);

                        DataTable data2 = new DataTable();

                        sda2.Fill(data2);

                        if (data2.Rows.Count > 0)
                        {
                            Username = txtusername.Text.Trim();
                            Password = txtpassword.Text.Trim();

                            MessageBox.Show("Login Successfull", "Login", MessageBoxButtons.OK);
                            Student_Name.SName = Username;
                            frmStudentMain student = new frmStudentMain();
                            student.ShowDialog();
                            this.Close();
                            break;
                        }

                        else
                        {
                            errorIcon.Visible = true;
                            errormessege.Visible = true;
                            break;
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnsignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // this will load signup form 

           frmSignup Signup = new frmSignup();
            Signup.Show();
            this.Hide();
        }

        private void eyebuttonshow_Click(object sender, EventArgs e)
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

        private void forgetpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // this will load the foreget form 

            frmForget forget = new frmForget();
            forget.Show();
            this.Hide();
        }

        private void guna2PictureBox6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            // when key press on textbox the error icons and messege will be disapper
            errorIcon.Visible = false;
            errormessege.Visible = false;
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // when key press on textbox the error icons and messege will be disapper
            errorIcon.Visible = false;
            errormessege.Visible = false;
        }
    }
}
