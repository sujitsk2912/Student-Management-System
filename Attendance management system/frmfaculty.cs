using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_management_system
{
    public partial class frmfaculty : Form
    {
        public frmfaculty()
        {
            InitializeComponent();
            txtfacultyid.Select();
        }

        string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";

        public void ClearMethod()
        {
            txtfacultyid.Clear();
            txtname.Clear();
            txtbatch.ResetText();
            txtaddress.Clear();
            txtemail.Clear();
            txtphone.Clear();
            txtfacultyid.Focus();
        }
        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            string FacultyId = txtfacultyid.Text;
            string FacultyName = txtname.Text;
            string Batch = txtbatch.Text;
            string Address = txtaddress.Text;
            string Email = txtemail.Text;
            string Phone = txtphone.Text;

            if (FacultyId != "" && FacultyName != "" && Batch != "" && Address != "" && Email != "" && Phone != "")
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                try
                {
                    string Query = "INSERT INTO Faculty_Registration ([FACULTY ID],[FACULTY NAME],BATCH, ADDRESS, EMAIL, PHONE) VALUES ('" + txtfacultyid.Text + "','" + txtname.Text + "','" + txtbatch.Text + "','" + txtaddress.Text + "','" + txtemail.Text + "','" + txtphone.Text + "')";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Faculty Registerd Successfully");
                    ClearMethod();
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
            else
            {
                MessageBox.Show("Please fill all data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmfaculty_Load(object sender, EventArgs e)
        {
            GetDataFromDataBase();
        }

      

        private void GetDataFromDataBase()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            try
            {
                string Query = "SELECT * FROM Faculty_Registration";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                FacultyRecordDataGridView.DataSource = dt;
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

        private void frmfaculty_Activated(object sender, EventArgs e)
        {
            GetDataFromDataBase();
        }


        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            if (txtfacultyid.Text != "" && txtname.Text != "" && txtbatch.Text != "" && txtaddress.Text != "" && txtemail.Text != "" && txtphone.Text != "")
            {
                try
                {
                    string Query = "UPDATE Faculty_Registration SET [FACULTY NAME] = '" + txtname.Text + "', BATCH = '" + txtbatch.Text + "', ADDRESS = '" + txtaddress.Text + "', EMAIL = '" + txtemail.Text + "', PHONE = '" + txtphone.Text + "' WHERE [FACULTY ID] = '" + txtfacultyid.Text + "'";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Successfully","Delete",MessageBoxButtons.OK);
                    GetDataFromDataBase();
                    ClearMethod();
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

            else
            {
                MessageBox.Show("Please select data to be Updated","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            if (txtfacultyid.Text != "" && txtname.Text != "" && txtbatch.Text != "" && txtaddress.Text != "" && txtemail.Text != "" && txtphone.Text != "")
            {
                try
                {
                    string Query = "DELETE FROM Faculty_Registration WHERE [FACULTY ID] = '" + txtfacultyid.Text + "'";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Deleted Successfully","Delete",MessageBoxButtons.OK);
                    GetDataFromDataBase();
                    ClearMethod();
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

            else
            {
                MessageBox.Show("Please select data to be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            ClearMethod();
        }

     
        
        private void FacultyRecordDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtfacultyid.Text = FacultyRecordDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            txtname.Text = FacultyRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtbatch.Text = FacultyRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtaddress.Text = FacultyRecordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtemail.Text = FacultyRecordDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            txtphone.Text = FacultyRecordDataGridView.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
