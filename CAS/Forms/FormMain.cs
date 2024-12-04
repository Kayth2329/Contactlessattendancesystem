using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contactless_Attendance_System.CAS.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            timerDateandtime.Start();
        }
        public string Username;

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Username;
        }

        private void timerDateandtime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lblDatetime.Text = now.ToString("F");
        }

        private void MovesidePanel (Control button)
        {
            slidePanel.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 180);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you want to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                timerDateandtime.Stop();
                Close();
            }
            else
            {
                
            }
        }

        private void btnAddclass_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            MovesidePanel(btnAttendance);
            attendance1.Visible = true;
            report1.Visible = false;
           
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            MovesidePanel(btnReport);
            report1.Visible = true;
            attendance1.Visible = false;
        }

        private void MovesidePanel(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            report1.Visible = false;
            attendance1.Visible = false;
        }
    }
}
