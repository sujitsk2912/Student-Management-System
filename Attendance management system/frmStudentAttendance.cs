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
    public partial class frmStudentAttendance : Form
    {
        public frmStudentAttendance()
        {
            InitializeComponent();
        }

        string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";

 
        private void StudentPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        public void GetDataForStudent(string tableName)
        {
            float att = 0;
            int studentID =Convert.ToInt32(StudentID.Text);

            SqlConnection conn = new SqlConnection(ConnectionString);
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

                string Query = $"SELECT [STUDENT ID], NAME, BATCH, FACULTY, PRESENT, ABSENT, DATE FROM {tableName} WHERE [STUDENT ID] = {studentID} AND DATE BETWEEN '{minDate.ToString("yyyy-MM-dd")}' AND '{maxDate.ToString("yyyy-MM-dd")}' ORDER BY DATE ASC";

                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                AttendanceRecordDataGridView1.DataSource = dt;


                int totalDays = frmattendance.CountDistinctDatesForStudent(tableName, studentID);

                int presentCount = dt.AsEnumerable().Count(row => row.Field<string>("PRESENT") == "Present");

                att = ((float)presentCount / totalDays) * 100.0f;

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

        public void BatchDetails()
        {
            try
            {
                int studentID = Convert.ToInt32(StudentID.Text);

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmStudentAttendance_Load(object sender, EventArgs e)
        {
            
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

        public void StudentloginMain()
        {
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

     

        private void frmStudentAttendance_Load_1(object sender, EventArgs e)
        {
            StudentloginMain();
            BatchDetails();
        }
    }
}
