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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml.Linq;

namespace Contactless_Attendance_System.CAS.Forms
{
    public partial class Attendance : UserControl
    {

        public Attendance()
        {
            InitializeComponent();
        }
        DateTime currentDate = DateTime.Now;


        SqlConnection con = new SqlConnection(@"Data Source=CHARISSERAMIREZ\SQLEXPRESS;Initial Catalog=CAS;Integrated Security=True");
 
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string formattedDate = currentDate.ToString("yyyy-MM-dd");
            if (txtName.Text == string.Empty || txtClass.Text == string.Empty || txtStudentn.Text == string.Empty)
            {
                con.Open();
                MessageBox.Show("Fill up all Fields", "Required All Fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                string Insert = "Insert into tblAttendance (studentNumber, Class, Name, Date, subjectName, Status) values ('" + txtStudentn.Text + "', " +
                     "'" + txtClass.Text + "', '" + txtName.Text + "', '" + formattedDate + "', '" + txtSubjname.Text + "', '" + cmbStatus.Text + "' )";
                SqlCommand cmd = new SqlCommand(Insert, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Attendance Succesfully");
                con.Close();
                txtClass.Clear();
                txtStudentn.Clear();
                txtSubjname.Clear();
                txtName.Clear();
            }
        }
    }
}
