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

namespace FinalProject_quanlykho
{
    public partial class frmPhieuXuat : Form
    {
        public frmPhieuXuat()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source = (local)\SQLEXPRESS; Initial Catalog = quanlykho; Integrated Security = True ");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
