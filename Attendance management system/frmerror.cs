using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_management_system
{
    public partial class frmerror : Form
    {
        public frmerror()
        {
            InitializeComponent();
        }

        private void btnretry_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
