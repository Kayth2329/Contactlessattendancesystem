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

namespace Contactless_Attendance_System.CAS.Forms
{
    public partial class Report : UserControl
    {
        public Report()
        {
            InitializeComponent();
        }



        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=CHARISSERAMIREZ\SQLEXPRESS;Initial Catalog=CAS;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblAttendance ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvAttendance.DataSource = dt;
            }
        }
        Bitmap bmp;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            int height = dgvAttendance.Height;
            dgvAttendance.Height = dgvAttendance.RowCount * dgvAttendance.RowTemplate.Height * 2;
            bmp = new Bitmap (dgvAttendance.Width, dgvAttendance.Height);
            dgvAttendance.DrawToBitmap(bmp, new Rectangle(0, 0, dgvAttendance.Width, dgvAttendance.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dgvAttendance.Height = height;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filterText = txtFilter.Text;
            FilterDataGridView(filterText);
        }


        private void FilterDataGridView(string filterText)
        {
            
            DataView dataView = ((DataTable)dgvAttendance.DataSource).DefaultView;
            dataView.RowFilter = $"studentNumber LIKE '%{filterText}%' OR Class LIKE '%{filterText}%' OR Name LIKE '%{filterText}%' " +
                $"OR subjectName LIKE '%{filterText}%'";
            dgvAttendance.ClearSelection();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string filterText = txtFilter.Text;
            FilterDataGridView(filterText);
        }
    }
}
