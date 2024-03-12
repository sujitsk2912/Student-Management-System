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
    public partial class frmeditadmission : Form
    {
        frmAdmissionRecord admin;
        public frmeditadmission()
        {
            InitializeComponent();
        }

        string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";

        public string Register, StudentID, Name, Course, Phone, Address, Date, Fees;
        private void frmeditadmission_Load(object sender, EventArgs e)
        {
            txtresgister.Text = Register;
            txtstudentid.Text = StudentID;
            txtname.Text = Name;
            txtcourse.Text = Course;
            txtphone.Text = Phone;
            txtaddress.Text = Address;
            txtdate.Text = Date;
            txtfees.Text = Fees;
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            try
            {
                string Query = "UPDATE Admission_DotNet_Java SET FULLNAME = '" + txtname.Text + "', COURSE = '" + txtcourse.Text + "', PHONE = '" + txtphone.Text + "', ADDRESS = '" + txtaddress.Text + "', [ADMISSION DATE] = '" + txtdate.Text + "', FEES = '" + txtfees.Text + "' WHERE [STUDENT ID] = '" + txtstudentid.Text + "'" +
                    "UPDATE AttendanceJavaByDate SET NAME = '" + txtname.Text + "', BATCH = '" + txtcourse.Text + "'" +
                    "UPDATE AttendanceDotNetByDate SET NAME = '" + txtname.Text + "', BATCH = '" + txtcourse.Text + "'";
                
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully","Success",MessageBoxButtons.OK);

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
