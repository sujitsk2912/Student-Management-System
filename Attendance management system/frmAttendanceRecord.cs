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
using System.Xml.Linq;

namespace Attendance_management_system
{
    public partial class frmAttendanceRecord : Form
    {
        public frmAttendanceRecord()
        {
            InitializeComponent();
        }

        string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";

      
        public void GetDataFromDotNet()
        {
            string Date = txtdate.Text;

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            try
            {
                string Query = "SELECT [STUDENT ID], NAME, BATCH, FACULTY, PRESENT, ABSENT, DATE FROM AttendanceDotNetByDate WHERE DATE = '" + Date + "'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                AttendanceRecordDataGridView.DataSource = dt;
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

        public void GetDataFromJava()
        {
            string Date = txtdate.Text;

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            try
            {
                string Query = "SELECT [STUDENT ID], NAME, BATCH, FACULTY, PRESENT, ABSENT, DATE FROM AttendanceJavaByDate WHERE DATE = '" + Date + "'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                AttendanceRecordDataGridView.DataSource = dt;
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

        private void frmAttendanceRecord_Activated(object sender, EventArgs e)
        {
            txtdate.Text = DateTime.Now.ToString();

            if (txtbatch.Text == "Java")
            {
                GetDataFromJava();
            }

            if (txtbatch.Text == "DotNet")
            {
                GetDataFromDotNet();
            }
        }

       

        private void frmAttendanceRecord_Load(object sender, EventArgs e)
        {
            txtdate.Text = DateTime.Now.ToString();
        }

      
        private void btnsearchrecord_Click(object sender, EventArgs e)
        {
            if (txtbatch.Text == "Java")
            {
                GetDataFromJava();
            }

            if (txtbatch.Text == "DotNet")
            {
                GetDataFromDotNet();
            }
        }

       

        private void AttendanceRecordDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int InvoiceImage = 0;

            if (e.ColumnIndex == InvoiceImage && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = AttendanceRecordDataGridView.SelectedRows[0];

                frmedit frmedit = new frmedit();

                frmedit.StudentID = selectedRow.Cells["HeaderID"].Value.ToString();
                frmedit.name = selectedRow.Cells["HeaderName"].Value.ToString();
                frmedit.Batch = selectedRow.Cells["HeaderBatch"].Value.ToString();
                frmedit.Present = selectedRow.Cells["HeaderPresent"].Value.ToString();
                frmedit.Absent = selectedRow.Cells["HeaderAbsent"].Value.ToString();
                frmedit.Date = selectedRow.Cells["HeaderDate"].Value.ToString();

                frmedit.Show();
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            if (txtbatch.Text == "Java")
            {
                GetDataFromJava();
            }

            if (txtbatch.Text == "DotNet")
            {
                GetDataFromDotNet();
            }
        }
    }

}
