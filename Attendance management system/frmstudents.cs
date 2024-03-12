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
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Attendance_management_system
{
    public partial class frmstudents : Form
    {
        public frmstudents()
        {
            InitializeComponent();
        }

        public int StudentID;
        string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";
        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            string StudentID = txtstudentid.Text;
            string Firstname = txtfirstname.Text;
            string Lastname = txtlastname.Text;
            string Class = txtclass.Text;
            string Section = txtsection.Text;

          // Create a connection for Uploading the data into SQL data base

                string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                string Query = "INSERT INTO [student data (8A)] ([STUDENT ID], FIRSTNAME, LASTNAME, CLASS, SECTION) VALUES ('" + StudentID + "','" + Firstname + "','" + Lastname + "','" + Class + "', '"+ Section +"')";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Student Data Uploaded");

            // this commands clear the all text boxes after data uploaded......

            txtfirstname.Clear();
            txtstudentid.Clear();
            txtlastname.Clear();
            txtfirstname.Focus();

            GetStudentsRecord(); // call this function to show data into datagridview instantly........

        }

        private void frmstudents_Load(object sender, EventArgs e)
        {

        }

        private void GetStudentsRecord()
        {
            // GetStudentsRecord method is Isert Data into tables on the click of Submit button
            // 
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from [student data (8A)]", conn);
            DataTable dt = new DataTable();
            conn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();

            StudentsRecordDataGridView.DataSource = dt;
        }

        private void txtsection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentsRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentID = Convert.ToInt32(StudentsRecordDataGridView.Rows[0].Cells[0].Value.ToString());
            txtfirstname.Text = StudentsRecordDataGridView.Rows[0].Cells[1].Value.ToString();
            txtlastname.Text = StudentsRecordDataGridView.Rows[0].Cells[2].Value.ToString();
            txtclass.Text = StudentsRecordDataGridView.Rows[0].Cells[3].Value.ToString();
            txtsection.Text = StudentsRecordDataGridView.Rows[0].Cells[4].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string Firstname = txtfirstname.Text;
            string Lastname = txtlastname.Text;
            string Class = txtclass.Text;
            string Section = txtsection.Text;

            if (StudentID > 0)
            {

                SqlConnection conn = new SqlConnection(ConnectionString);

                string Query = "UPDATE [student data (8A)] SET FIRSTNAME = Firstname, LASTNAME = Lastname, CLASS = Class , SECTION = Section WHERE [STUDENT ID] = StudentID ";
                SqlCommand cmd = new SqlCommand(Query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Student Data Updated","Success",MessageBoxButtons.OK);

                // this commands clear the all text boxes after data uploaded......


                GetStudentsRecord();

                txtfirstname.Clear();
                txtstudentid.Clear();
                txtlastname.Clear();
                txtfirstname.Focus();

            }

        }

        private void frmstudents_Load_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton5_Click_1(object sender, EventArgs e)
        {

        }

        private void attendancepanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
