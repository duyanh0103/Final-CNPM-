using FinalProject_quanlykho.DAO;
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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
            LoadListProduct();
        }
        void LoadListProduct()
        {
            string query = "exec dbo.productProc_getProductByDisplayName @tensanpham";

            dgvProductInfo.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { "Calcium Corbiere" });
        }


    }
}
