using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_quanlykho
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            
            frmPhieuNhap phieuNhap = new frmPhieuNhap();
            phieuNhap.Show();
            
        }

        private void btnPhieuXuat_Click(object sender, EventArgs e)
        {
            frmPhieuXuat phieuXuat = new frmPhieuXuat();
            phieuXuat.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmSanPham sanpham = new frmSanPham();
            sanpham.Show();
        }
    }
}
