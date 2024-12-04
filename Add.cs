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

namespace Contactless_Attendance_System
{
    public partial class Add : UserControl
    {
        public Add()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=CHARISSERAMIREZ\SQLEXPRESS;Initial Catalog=CAS;Integrated Security=True");
        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || txtClass.Text == string.Empty || txtStudentn.Text == string.Empty)
            {
                MessageBox.Show("Fill up all Fields", "Required All Fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                con.Open();
                string Insert = "Insert into Add (Name, StudentNumber, Class) values ('" + txtName.Text + "', " +
                    "'" + txtStudentn.Text + "', '" + txtClass.Text + "')";
                SqlCommand cmd = new SqlCommand(Insert, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Attendance Succesfully");
                con.Close();
                txtClass.Clear();
                txtStudentn.Clear();
                txtName.Clear();
            }
        }
    }
}