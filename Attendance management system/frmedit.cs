using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Attendance_management_system
{
    public partial class frmedit : Form
    {

        public string StudentID, name, Batch, Date, Present, Absent;

        public frmedit()
        {
            InitializeComponent();

        }

        string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";


       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            StudentID = txtstudentid.Text;
            name = txtname.Text;
            Batch = txtbatch.Text;
            Date = txtdate.Text;

            if (btnPresent.Checked)
            {
                Present = "Present";
                Absent = "";
            }
            if (btnAbsent.Checked)
            {
                Absent = "Absent";
                Present = "";
            }

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            
            try
            {
                if (Batch == "Java")
                {
                    // Clear old data first
                    string clearOldDataQuery = "UPDATE AttendanceJavaByDate SET ABSENT = NULL WHERE [STUDENT ID] = @StudentID AND ABSENT IS NOT NULL";
                    SqlCommand clearCmd = new SqlCommand(clearOldDataQuery, conn);
                    clearCmd.Parameters.AddWithValue("@StudentID", StudentID);
                    clearCmd.ExecuteNonQuery();

                    // Update with new data
                    string updateQuery = "UPDATE AttendanceJavaByDate SET PRESENT = @Present, ABSENT = @Absent WHERE [STUDENT ID] = @StudentID AND DATE = '"+ Date +"'";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@Present", Present);
                    updateCmd.Parameters.AddWithValue("@Absent", Absent);
                    updateCmd.Parameters.AddWithValue("@StudentID", StudentID);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Attendance Updated Successfully...","Success",MessageBoxButtons.OK);
                }

                if (Batch == "DotNet")
                {
                    // Clear old data first
                    string clearOldDataQuery = "UPDATE AttendanceDotNetByDate SET ABSENT = NULL WHERE [STUDENT ID] = @StudentID AND ABSENT IS NOT NULL";
                    SqlCommand clearCmd = new SqlCommand(clearOldDataQuery, conn);
                    clearCmd.Parameters.AddWithValue("@StudentID", StudentID);
                    clearCmd.ExecuteNonQuery();

                    // Update with new data
                    string updateQuery = "UPDATE AttendanceDotNetByDate SET PRESENT = @Present, ABSENT = @Absent WHERE [STUDENT ID] = @StudentID AND DATE = '"+ Date +"'";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@Present", Present);
                    updateCmd.Parameters.AddWithValue("@Absent", Absent);
                    updateCmd.Parameters.AddWithValue("@StudentID", StudentID);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Attendance Updated Successfully...","Success",MessageBoxButtons.OK);
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

       
    

        private void frmedit_Load(object sender, EventArgs e)
        {
            txtstudentid.Text = StudentID;
            txtname.Text = name;
            txtbatch.Text = Batch;
            txtdate.Text = Date;
            btnPresent.Checked = (Present == "Present");
            btnAbsent.Checked = (Absent == "Absent");
        }

    
    }
}
