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
    public partial class AddClass : UserControl
    {
        public AddClass()
        {
            InitializeComponent();
        }


        private void IntegerType (KeyPressEventArgs e)
        {
            if(!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back))) e.Handled = true;
        }
        public void ClearTextBox()
        {
            txtName.Clear();
            txtStudentnum.Clear();
            txtClass.Clear();
            txtSubjname.Clear();
        }

        private void btnAddclass_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == string.Empty || txtStudentnum.Text.Trim() == string.Empty || txtSubjname.Text.Trim() == string.Empty || txtClass.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Fill out all fields", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            else
            {
                
            }
        }
    }
}
