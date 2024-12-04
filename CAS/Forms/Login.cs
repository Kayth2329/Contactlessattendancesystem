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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pbShow_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pbShow, "Show Password");

        }

        private void pbHide_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pbHide, "Hide Password");
        }

        private void pbShow_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            pbShow.Hide();
            pbHide.Show();
        }

        private void pbHide_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            pbShow.Show();
            pbHide.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pbHide.Hide();
        }

        private void pbClose_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pbClose, "Close");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Please input your Username and Password");

            }
            else
            {
                FormMain formmain = new FormMain();
                formmain.Username = txtName.Text;
                txtName.Clear();
                txtPassword.Clear() ;
                pbHide_Click(sender, e);
                txtName.Focus();
                formmain.Show();
                this.Hide();

            }
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
