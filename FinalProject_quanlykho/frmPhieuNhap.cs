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
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source = (local)\SQLEXPRESS; Initial Catalog = quanlykho; Integrated Security = True ");
        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlykhoDataSet.INPUTINFO' table. You can move, or remove it, as needed.
            this.iNPUTINFOTableAdapter.Fill(this.quanlykhoDataSet.INPUTINFO);

            var dap = new SqlDataAdapter("SELECT * FROM inputkho", conn);
            var table = new DataTable();
            dap.Fill(table);

            cbPhieuNhap.DisplayMember = "nameinput";
            cbPhieuNhap.ValueMember = "id_input";
            cbPhieuNhap.DataSource = table;

            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", cbPhieuNhap.DataSource, "id_input");

            txtTenPhieu.DataBindings.Clear();
            txtTenPhieu.DataBindings.Add("Text", cbPhieuNhap.DataSource, "nameinput");

        }

        private void cbPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            String id_input = Convert.ToString(cbPhieuNhap.SelectedValue);
            var dap = new SqlDataAdapter("SELECT * FROM inputinfo where id_input = "+id_input+" ", conn);
            var table = new DataTable();
            dap.Fill(table);
            dgvInputInfo.DataSource = table;

            txtMaDonHang.DataBindings.Clear();
            txtMaDonHang.DataBindings.Add("Text", dgvInputInfo.DataSource, "ID_INPUTINFO");

            txtID_Product.DataBindings.Clear();
            txtID_Product.DataBindings.Add("Text", dgvInputInfo.DataSource, "IDSANPHAM");

            txtNameProduct.DataBindings.Clear();
            txtNameProduct.DataBindings.Add("Text", dgvInputInfo.DataSource, "TENSANPHAM");

            //txtID_input.DataBindings.Clear();
            //txtID_input.DataBindings.Add("Text", dgvInputInfo.DataSource, "ID_INPUT");

            nudCount.DataBindings.Clear();
            nudCount.DataBindings.Add("Text", dgvInputInfo.DataSource, "SOLUONG");

            txtGiaNhap.DataBindings.Clear();
            txtGiaNhap.DataBindings.Add("Text", dgvInputInfo.DataSource, "GIANHAP");

            txtGiaBan.DataBindings.Clear();
            txtGiaBan.DataBindings.Add("Text", dgvInputInfo.DataSource, "GIABAN");

            importDatePicker.DataBindings.Clear();
            importDatePicker.DataBindings.Add("Text", dgvInputInfo.DataSource, "DATE_INPUT");
        }


        Boolean addReceipt = false;

        private void btnAddReceipt_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtTenPhieu.Text = "";
            txtTenPhieu.Focus();
            addReceipt = true;
        }

        private void btnUpdateReciept_Click(object sender, EventArgs e)
        {
            if (addReceipt == true)
            {
                conn.Open();
                var command = new SqlCommand("Insert into INPUTKHO(NAMEINPUT) values(N'" + txtTenPhieu.Text + "') ", conn);
                command.ExecuteNonQuery();
                conn.Close();
                frmPhieuNhap_Load(sender, e);
                addReceipt = false;

            }
            else
            {
                conn.Open();
                var command = new SqlCommand("update INPUTKHO set NAMEINPUT = N'" 
                    + txtTenPhieu.Text + "'where id_input =  "+Convert.ToString(cbPhieuNhap.SelectedValue)+" ", conn);
                command.ExecuteNonQuery();
                conn.Close();
                frmPhieuNhap_Load(sender, e);
                
            }
        }

        private void btnDeleteReceipt_Click(object sender, EventArgs e)
        {
            conn.Open();
            var command = new SqlCommand("delete from INPUTKHO where id_input =  " + Convert.ToString(cbPhieuNhap.SelectedValue) + " ", conn);
            command.ExecuteNonQuery();
            conn.Close();
            frmPhieuNhap_Load(sender, e);
            
        }
        Boolean addGoods = false;
        private void btnThemHang_Click(object sender, EventArgs e)
        {
            txtMaDonHang.Text = "";
            txtMaDonHang.Focus();
            txtID_Product.Text = "";
            txtNameProduct.Text = "";
            nudCount.Text = "";
           // txtID_input.Text = "";
            txtGiaNhap.Text = "";
            txtGiaBan.Text = "";
            importDatePicker.Text = "";
            addGoods = true;
        }

        private void btnSuaHang_Click(object sender, EventArgs e)
        {
            if (addGoods == true)
            {
                conn.Open();
                var command = new SqlCommand("Insert into INPUTINFO(IDSANPHAM,TENSANPHAM,SOLUONG,DATE_INPUT,GIANHAP,GIABAN,ID_INPUT) " +
                    "values(N'" + txtID_Product.Text + "',N'" + txtNameProduct.Text + "','" + nudCount.Value + "','"+importDatePicker.CustomFormat+ "','"+txtGiaNhap.Text+ "','"+txtGiaBan.Text+ "','"+Convert.ToInt32(cbPhieuNhap.SelectedValue)+ "') ", conn);
                command.ExecuteNonQuery();
                conn.Close();
                frmPhieuNhap_Load(sender, e);
                addGoods = false;
                
            }
            else
            {
                conn.Open();
                var command = new SqlCommand("update INPUTINFO set " +
                    "IDSANPHAM = N'"+ txtID_Product.Text + "',TENSANPHAM=N'" + txtNameProduct.Text+ "',SOLUONG='" +nudCount.Value+ "',DATE_INPUT='"+importDatePicker.CustomFormat+"',GIANHAP='"+txtGiaNhap.Text+"',GIABAN='"+txtGiaBan.Text+"' where id_input =  " + Convert.ToString(txtMaDonHang.Text) + " ", conn);
                command.ExecuteNonQuery();
                conn.Close();
                frmPhieuNhap_Load(sender, e);
              
            }

        }

        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            conn.Open();
            var command = new SqlCommand("delete from INPUTINFO where ID_INPUTINFO =  " + Convert.ToInt32(txtMaDonHang.Text) + " ", conn);
            command.ExecuteNonQuery();
            conn.Close();
            frmPhieuNhap_Load(sender, e);

        }
    }
}
