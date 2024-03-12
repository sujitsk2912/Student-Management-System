using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Attendance_management_system
{
    public partial class frminvoice : Form
    {
        public string Reciept, StudentId, Phone, Fees , Name, Course, Address, Date;
        public frminvoice()
        {
            InitializeComponent();
        }

        frminvoice Invoice = null;
        private void Print(Panel BodyPanel)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void collegename_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void btnprint_Click(object sender, EventArgs e)
        {
           
        }


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
           
        }


        private void btnprint_Click_1(object sender, EventArgs e)
        {
            // Specify the desired width and height for the captured image
            int desiredWidth = 1070;
            int desiredHeight = 648;

      

            // Capture the content of the form as an image with the specified size
            Bitmap bmp = new Bitmap(desiredWidth, desiredHeight);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, desiredWidth, desiredHeight));

            // Capture the PictureBox image if available
            if (pictureBox1.Image != null)
            {
                int pictureBoxWidth = pictureBox1.Width;
                int pictureBoxHeight = pictureBox1.Height;

                // Calculate the position of the PictureBox on the form
                int pictureBoxX = 136;
                int pictureBoxY = 76;

                // Create a Bitmap for the PictureBox image
                Bitmap bmpPictureBox = new Bitmap(pictureBoxWidth, pictureBoxHeight);

                // Create a Graphics object for the PictureBox Bitmap
                using (Graphics gPictureBox = Graphics.FromImage(bmpPictureBox))
                {
                    // Draw the PictureBox image onto the Bitmap
                    gPictureBox.DrawImage(pictureBox1.Image, new Rectangle(0, 0, pictureBoxWidth, pictureBoxHeight));
                }

                // Combine the form image and PictureBox image
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    // Draw the PictureBox image at the specified position on the form image
                    g.DrawImage(bmpPictureBox, new Rectangle(pictureBoxX, pictureBoxY, pictureBoxWidth, pictureBoxHeight));
                }
            }

            // Create a PrintDocument
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                // Set a higher resolution (e.g., 300 DPI)
                ev.Graphics.PageUnit = GraphicsUnit.Display;
                ev.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                ev.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                ev.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                ev.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

                // Calculate the scaling factors for width and height
                float scaleWidth = (float)ev.PageBounds.Width / bmp.Width;
                float scaleHeight = (float)ev.PageBounds.Height / bmp.Height;

                // Choose the smaller scaling factor to maintain aspect ratio
                float scale = Math.Min(scaleWidth, scaleHeight);

                // Calculate the position on the page considering the scaling factor
                float x = (ev.PageBounds.Width - bmp.Width * scale) / 2;
                float y = 0; // Set to 0 to position at the top of the page

                // Create a scaled rectangle based on the scaling factor and position
                RectangleF scaledRect = new RectangleF(x, y, bmp.Width * scale, bmp.Height * scale);

                // Draw the captured image on the print document
                ev.Graphics.DrawImage(bmp, scaledRect);
            };

            // Show print dialog
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void collegename_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void frminvoice_Load(object sender, EventArgs e)
        {
            txtregister.Text = Reciept;
            txtstudentid.Text = StudentId;
            txtname.Text = Name;
            txtcourse.Text = Course;
            txtphone.Text = Phone;
            txtaddress.Text = Address;
            txtdate.Text = Date;
            txtfees.Text = Fees;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logotext_Click(object sender, EventArgs e)
        {

        }


    }
}
