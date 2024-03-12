using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Attendance_management_system
{
    public partial class frmstudent : Form
    {
        public frmstudent()
        {
            InitializeComponent();
            AttendancePercentBar.Value = 0;
        }

        frmattendance attend;

        string Connection = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";


        public void GetDataForStudent(string tableName)
        {
            float att = 0;
            int studentID = Convert.ToInt32(txtstudentid.Text);

            SqlConnection conn = new SqlConnection(Connection);
            conn.Open();

            try
            {
                string minMaxQuery = $"SELECT MIN(DATE) AS MinDate, MAX(DATE) AS MaxDate FROM {tableName} WHERE [STUDENT ID] = {studentID}";
                SqlCommand minMaxCmd = new SqlCommand(minMaxQuery, conn);
                SqlDataReader minMaxReader = minMaxCmd.ExecuteReader();

                DateTime minDate = DateTime.MinValue;
                DateTime maxDate = DateTime.MinValue;

                if (minMaxReader.Read())
                {
                    if (!minMaxReader.IsDBNull(minMaxReader.GetOrdinal("MinDate")))
                        minDate = minMaxReader.GetDateTime(minMaxReader.GetOrdinal("MinDate"));

                    if (!minMaxReader.IsDBNull(minMaxReader.GetOrdinal("MaxDate")))
                        maxDate = minMaxReader.GetDateTime(minMaxReader.GetOrdinal("MaxDate"));
                }

                minMaxReader.Close();

                string Query = $"SELECT [STUDENT ID], NAME, BATCH, FACULTY, PRESENT, ABSENT, DATE FROM {tableName} WHERE [STUDENT ID] = {studentID} AND DATE BETWEEN '{minDate.ToString("yyyy-MM-dd")}' AND '{maxDate.ToString("yyyy-MM-dd")}' Order By DATE ASC";

                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                AttendanceRecordDataGridView1.DataSource = dt;

                int totalDays = frmattendance.CountDistinctDatesForStudent(tableName, studentID);

                int presentCount = dt.AsEnumerable().Count(row => row.Field<string>("PRESENT") == "Present");

                att = ((float)presentCount / totalDays) * 100.0f;

               // MessageBox.Show($"Attendance of the StudentID {studentID} is {att}% ");

                AttendancePercentBar.Value = Convert.ToInt32(att);
                AttPercent.Text = Convert.ToInt32(att).ToString() + "%";

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

        private void btnenter_Click_4(object sender, EventArgs e)
        {
            try
            {
                if (txtstudentid.Text == "")
                {
                    MessageBox.Show("Please enter Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    int studentID = Convert.ToInt32(txtstudentid.Text);

                    string batch = DetermineBatch(studentID);

                    if (batch == "Java")
                    {
                        GetDataForStudent("AttendanceJavaByDate");
                    }
                    else if (batch == "DotNet")
                    {
                        GetDataForStudent("AttendanceDotNetByDate");
                       
                    }
                    else
                    {
                        MessageBox.Show($"Student with ID {studentID} not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string DetermineBatch(int studentID)
        {
            string batch = string.Empty;

            string connection = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();

                    string batchQuery = $"SELECT COURSE FROM Admission_DotNet_Java WHERE [STUDENT ID] = {studentID}";

                    using (SqlCommand cmd = new SqlCommand(batchQuery, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                batch = reader["COURSE"].ToString();
                            } 
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            return batch;
        }

        private void AttPercent_Click(object sender, EventArgs e)
        {

        }

        private void AttendancePercentBar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void AttendanceRecordDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtstudentid_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
