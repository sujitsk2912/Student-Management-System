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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.Win32;
using System.Net;
using System.Security.Cryptography;

namespace Attendance_management_system
{
    public partial class frmadmission : Form
    {
        public frmadmission()
        {
            InitializeComponent();
            txtname.Select();
        }

      frmMain main;
       frmadmission admin;

        string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";
      
        public void frmadmission_Load(object sender, EventArgs e)
        {
            txtDOB.Text = DateTime.Now.ToString();
            txtDOA.Text = DateTime.Now.ToString();

            AutoIDNumber();
        }


        public void AutoIDNumber()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                int set1 = 0;
                int set2 = 0;
        
                string query = "SELECT MAX([REG NO.]), MAX([STUDENT ID]) FROM Admission_DotNet_Java";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            set1 = reader.IsDBNull(0) ? 0 : Convert.ToInt32(reader[0]);
                            set2 = reader.IsDBNull(1) ? 0 : Convert.ToInt32(reader[1]);
                        }
                    }

                    set1++;
                    set2++;

                    txtresgister.Text = (set1).ToString();
                    txtstudentid.Text = (set2).ToString();
                    conn.Close();
                }
            }
        }


        public void Clear()
        {
            txtname.Clear();
            txtphone.Clear();
            txtparent.Clear();
            txtaddress.Clear();
            txtDOB.Text = DateTime.Now.ToString();
            txtDOA.Text = DateTime.Now.ToString();
            btnMale.Checked = false;
            btnfemale.Checked = false;
            txtfees.Clear();
            txtname.Focus();
        }
     

        public void GenerateInvoice()
        {
            string Register = txtresgister.Text;
            string StudentId = txtstudentid.Text;
            string Name = txtname.Text;
            string Phone = txtphone.Text;
            string Parent = txtparent.Text;
            string Address = txtaddress.Text;
            string DOB = txtDOB.Text;
            string Gender = null;
            string DOA = txtDOA.Text;
            string Course = txtcourse.Text;
            string Fees = txtfees.Text;
            string Duration = txtduration.Text;

            if (Register == "" || StudentId == "" || Name == "" || Fees == "" || (btnMale.Checked == false && btnfemale.Checked == false))
            {
                MessageBox.Show("Please fill all data");
            }

            else
            {
                frminvoice invoice = new frminvoice();

                invoice.Reciept = txtresgister.Text;
                invoice.StudentId = txtstudentid.Text;
                invoice.Name = txtname.Text;
                invoice.Course = txtcourse.Text;
                invoice.Phone = txtphone.Text;
                invoice.Address = txtaddress.Text;
                invoice.Date = txtDOA.Text;
                invoice.Fees = txtfees.Text;
                invoice.ShowDialog();
            }
        }

        private void frmadmission_Activated(object sender, EventArgs e)
        {
            txtDOB.Text = DateTime.Now.ToString();
            txtDOA.Text = DateTime.Now.ToString();
        }


        private void btnsubmit_Click(object sender, EventArgs e)
        {
            // VARIABLE DECLARATION ..................

            string Register = txtresgister.Text;
            string StudentId = txtstudentid.Text;
            string Name = txtname.Text;
            string Phone = txtphone.Text;
            string Parent = txtparent.Text;
            string Address = txtaddress.Text;
            string DOB = txtDOB.Text;
            string Gender = null;
            string DOA = txtDOA.Text;
            string Course = txtcourse.Text;
            string Fees = txtfees.Text;
            string Duration = txtduration.Text;

            if (Register == "" || StudentId == "" || Name == "" || Fees == "" || (btnMale.Checked == false && btnfemale.Checked == false))
            {
                MessageBox.Show("Please fill all data");
            }

            else
            {
                if (btnMale.Checked)
                {
                    Gender = "Male";
                }
                else if (btnfemale.Checked)
                {
                    Gender = "Female";
                }

                //  ----------------------------------------------

                //  CONNCTING TO SQL DATABASE

                //  ----------------------------------------------


                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                try
                {
                    string Query = "INSERT INTO Admission_DotNet_Java ([REG NO.],[STUDENT ID], FULLNAME, PHONE, [PARENTS PHONE], ADDRESS, DOB, GENDER, [ADMISSION DATE], COURSE, FEES, DURATION ) VALUES ('" + Register + "','" + StudentId + "','" + Name + "','" + Phone + "','" + Parent + "','" + Address + "','" + DOB + "','" + Gender + "','" + DOA + "','" + Course + "','" +  Fees + "','" + Duration + "')";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();

                    DialogResult result = MessageBox.Show("Do you want to Generate Invoice?", "Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        GenerateInvoice();
                    }
                    MessageBox.Show("Data Submited Successfully","Success");
                    Clear();
                    AutoIDNumber();
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
}
