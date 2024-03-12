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
using System.Net.NetworkInformation;

namespace Attendance_management_system
{
    public partial class frmresults : Form
    {
        public frmresults()
        {
            InitializeComponent();
        }

        public void Variable_Declration()
        {
            
            string Date = txtdate.Text;
          //  string Subject = txtsubjects.Text;
            string RollNo = txtrollno.Text;

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click_1(object sender, EventArgs e)
        {
            string Date = txtdate.Text;
          //  string Subject = txtsubjects.Text;
            string RollNo = txtrollno.Text;

            string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
           // string Query = "INSERT INTO Student_Result (Subjects) VALUES ('" + Subject + "')";
           // SqlCommand cmd = new SqlCommand(Query, conn);
           // cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Uploaded Successfully","Success",MessageBoxButtons.OK);
        }

        private void frmresults_Activated(object sender, EventArgs e)
        {
            txtdate.Text = DateTime.Now.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
