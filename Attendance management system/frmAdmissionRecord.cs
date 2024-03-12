using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Linq;

namespace Attendance_management_system
{
    public partial class frmAdmissionRecord : Form
    {
        public frmAdmissionRecord()
        {
            InitializeComponent();
           
        }

        string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";

        int StudentID;
      

        private void btnreset_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            if (AdmissionRecordDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = AdmissionRecordDataGridView.SelectedRows[0];

                /*  if (txtstudentid.Text != "" || txtname.Text != "")
                  {*/
                DialogResult result = MessageBox.Show("Do you want to delete this record? ", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string Query = "DELETE FROM Admission_DotNet_Java WHERE [STUDENT ID] = '" + txtstudentid.Text + "' or FULLNAME = '" + txtname.Text + "' " +
                            "DELETE FROM AttendanceDotNetByDate WHERE [STUDENT ID] = '" + txtstudentid.Text + "' or NAME = '" + txtname.Text + "'" +
                            "DELETE FROM AttendanceJavaByDate WHERE [STUDENT ID] = '" + txtstudentid.Text + "' or NAME = '" + txtname.Text + "'";

                        SqlCommand cmd = new SqlCommand(Query, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Deleted Successfully", "Delete");
                        txtstudentid.Clear();
                        txtname.Clear();
                        txtname.Focus();

                        GetDataFromDataBase();
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

      

        public void SearchByName()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            try
            {
                string Query = "SELECT [REG NO.], [STUDENT ID], FULLNAME, COURSE, PHONE, ADDRESS, [ADMISSION DATE], FEES FROM Admission_DotNet_Java WHERE FULLNAME = '" + txtname.Text + "' ORDER BY [REG NO.], [STUDENT ID], FULLNAME, COURSE, PHONE, ADDRESS, [ADMISSION DATE], FEES";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                AdmissionRecordDataGridView.DataSource = dt;
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

        public void SearchByID()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            try
            {
                string Query = "SELECT [REG NO.], [STUDENT ID], FULLNAME, COURSE, PHONE, ADDRESS, [ADMISSION DATE], FEES FROM Admission_DotNet_Java WHERE [STUDENT ID] = '" + txtstudentid.Text + "' ORDER BY [REG NO.], [STUDENT ID], FULLNAME, COURSE, PHONE, ADDRESS, [ADMISSION DATE], FEES";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                AdmissionRecordDataGridView.DataSource = dt;
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
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            GetDataFromDataBase();
        }


        public void GetDataFromDataBase()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            try
            {
                string Query = "SELECT [REG NO.], [STUDENT ID], FULLNAME, COURSE, PHONE, ADDRESS, [ADMISSION DATE], FEES FROM Admission_DotNet_Java ORDER BY [STUDENT ID] ASC";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                AdmissionRecordDataGridView.DataSource = dt;
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

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (AdmissionRecordDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = AdmissionRecordDataGridView.SelectedRows[0];

                frmeditadmission admin = new frmeditadmission();

                admin.Register = selectedRow.Cells["HeaderRegister"].Value.ToString();
                admin.StudentID = selectedRow.Cells["HeaderID"].Value.ToString();
                admin.Name = selectedRow.Cells["HeaderName"].Value.ToString();
                admin.Course = selectedRow.Cells["HeaderCourse"].Value.ToString();
                admin.Phone = selectedRow.Cells["HeaderPhone"].Value.ToString();
                admin.Address = selectedRow.Cells["HeaderAddress"].Value.ToString();
                admin.Date = selectedRow.Cells["HeaderDate"].Value.ToString();
                admin.Fees = selectedRow.Cells["HeaderFees"].Value.ToString();

                admin.Show();
            }

            else
            {
                MessageBox.Show("Please select record to Edit", "Select Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void frmAdmissionRecord_Activated(object sender, EventArgs e)
        {
            GetDataFromDataBase();
        }

        private void frmAdmissionRecord_Load(object sender, EventArgs e)
        {
            txtname.Focus();
        }


        private void AdmissionRecordDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int InvoiceImage = 0;
            if (e.ColumnIndex == InvoiceImage && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = AdmissionRecordDataGridView.SelectedRows[0];

                frminvoice invoice = new frminvoice();

                invoice.Reciept = selectedRow.Cells["HeaderRegister"].Value.ToString();
                invoice.StudentId = selectedRow.Cells["HeaderID"].Value.ToString();
                invoice.Name = selectedRow.Cells["HeaderName"].Value.ToString();
                invoice.Course = selectedRow.Cells["HeaderCourse"].Value.ToString();
                invoice.Phone = selectedRow.Cells["HeaderPhone"].Value.ToString();
                invoice.Address = selectedRow.Cells["HeaderAddress"].Value.ToString();
                invoice.Date = selectedRow.Cells["HeaderDate"].Value.ToString();
                invoice.Fees = selectedRow.Cells["HeaderFees"].Value.ToString();

                invoice.Show();
            }
        }

        private void AdmissionRecordDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtstudentid.Text = AdmissionRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtname.Text = AdmissionRecordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnsearchName_Click_3(object sender, EventArgs e)
        {
            SearchByName();
        }

        private void btnsearchID_Click_1(object sender, EventArgs e)
        {
            SearchByID();
        }
    }
}