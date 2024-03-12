using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Collections.Specialized.BitVector32;
using System.Security.Cryptography;
using Microsoft.Win32;
using System.Net;

namespace Attendance_management_system
{
    public partial class frmattendance : Form
    {
        public string Faculty;
        public frmattendance()
        {
            InitializeComponent();

        }

        string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            if (txtbatch.Text == "Java")
            {
                GetDataFromJava();
            }

            if (txtbatch.Text == "DotNet")
            {
                GetDataFromDotNet();
            }

            btnsave.Enabled = true;
        }

        private void GetDataFromJava()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            try
            {
                string Query = "SELECT [STUDENT ID],FULLNAME,COURSE FROM Admission_DotNet_Java where COURSE = 'Java' ORDER BY [STUDENT ID] ASC ";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                AttendanceDataGridView.DataSource = dt;
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

        private void GetDataFromDotNet()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            try
            {
                string Query = "SELECT [STUDENT ID],FULLNAME,COURSE FROM Admission_DotNet_Java where COURSE = 'DotNet' ORDER BY [STUDENT ID] ASC";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                AttendanceDataGridView.DataSource = dt;


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


        private bool IsDuplicateEntry(string tableName, int studentID, string date)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = $"SELECT COUNT(*) FROM {tableName} WHERE [STUDENT ID] = {studentID} AND DATE = '{date}'";
                using (SqlCommand comm = new SqlCommand(query, conn))
                {
                    int count = Convert.ToInt32(comm.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public static int CountDistinctDatesForStudent(string tableName, int studentID)
        {
            string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";

            int totalDays = 0;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string Query = $"SELECT COUNT(DISTINCT DATE) FROM {tableName} WHERE [STUDENT ID] = @StudentID";

                using (SqlCommand comm = new SqlCommand(Query, conn))
                {
                    comm.Parameters.AddWithValue("@StudentID", studentID);

                    object result = comm.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        totalDays = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show($"No distinct dates found for StudentID {studentID}");
                    }
                }
            }

            return totalDays;
        }


        private void btnsave_Click_1(object sender, EventArgs e)
        {
            string Date = txtdate.Text;
            string Faculty = txtfacultyname.Text;

            string tableName = "";


            if (txtbatch.Text == "Java")
            {
                tableName = "AttendanceJavaByDate";
            }
            else if (txtbatch.Text == "DotNet")
            {
                tableName = "AttendanceDotNetByDate";
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        conn.Open();

                        bool attendanceMarkedSuccessfully = true;

                        for (int i = 0; i < AttendanceDataGridView.Rows.Count; i++)
                        {
                            int studentID = Convert.ToInt32(AttendanceDataGridView.Rows[i].Cells["HeaderID"].Value);

                            int distinctDateCount = CountDistinctDatesForStudent(tableName, studentID);

                            if (!IsDuplicateEntry(tableName, studentID, Date))
                            {
                                string Query = $"INSERT INTO {tableName} ([STUDENT ID], NAME, BATCH, FACULTY, PRESENT, ABSENT, DATE ) VALUES ('" +
                                    AttendanceDataGridView.Rows[i].Cells["HeaderID"].Value + "', '" +
                                    AttendanceDataGridView.Rows[i].Cells["HeaderName"].Value + "', '" +
                                    AttendanceDataGridView.Rows[i].Cells["HeaderBatch"].Value + "', '" +
                                    Faculty + "', '" +
                                    AttendanceDataGridView.Rows[i].Cells["HeaderPresent"].Value + "', '" +
                                    AttendanceDataGridView.Rows[i].Cells["HeaderAbsent"].Value + "', '" +
                                    Date + "');";

                                comm.CommandText = Query;
                                comm.ExecuteNonQuery();

                            }
                            else
                            {
                                attendanceMarkedSuccessfully = false;
                                MessageBox.Show("Already Attendance Marked for some students. Please check Attendance Record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }

                        if (attendanceMarkedSuccessfully)
                        {
                            MessageBox.Show("Attendance Marked Successfully..", "Success", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
            btnsave.Enabled = false;
        }


        private void frmattendance_Load(object sender, EventArgs e)
        {
            btnsave.Enabled = false;
            txtdate.Text = DateTime.Now.ToString();

            SqlConnection conn = new SqlConnection(ConnectionString);

            try
            {
                conn.Open();

                string query = "SELECT [FACULTY NAME] FROM Faculty_Registration";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string facultyName = reader["FACULTY NAME"].ToString();
                            txtfacultyname.Items.Add(facultyName);
                        }

                        if (txtfacultyname.Items.Count > 0)
                        {
                            txtfacultyname.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtbatch_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);

            try
            {
                conn.Open();
                string Query = "Select [FACULTY NAME] from Faculty_Registration where BATCH = '" + txtbatch.SelectedItem + "' ";
                SqlCommand cmd = new SqlCommand(Query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                string Batch = txtbatch.SelectedItem.ToString();

                while (reader.Read())
                {
                    string FacultyName = reader["FACULTY NAME"].ToString();

                    if (txtbatch.SelectedItem == Batch)
                    {
                        txtfacultyname.SelectedItem = FacultyName.ToString();
                    }
                    else if (txtbatch.SelectedItem == Batch)
                    {
                        txtfacultyname.SelectedItem = FacultyName.ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }


        private void txtfacultyname_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);

            try
            {
                conn.Open();
                string Query = "Select BATCH from Faculty_Registration where [FACULTY NAME] = '" + txtfacultyname.SelectedItem + "' ";
                SqlCommand cmd = new SqlCommand(Query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                string FacultyName = txtfacultyname.SelectedItem.ToString();

                while (reader.Read())
                {
                    string Batch = reader["BATCH"].ToString();

                    if (txtfacultyname.SelectedItem == FacultyName)
                    {
                        txtbatch.SelectedItem = Batch.ToString();
                    }
                    else if (txtfacultyname.SelectedItem == FacultyName)
                    {
                        txtbatch.SelectedItem = Batch.ToString();
                    }
                }
            }
            catch (SqlException ex)
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
