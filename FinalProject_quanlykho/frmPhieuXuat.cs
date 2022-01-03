using FinalProject_quanlykho.DAO;
using FinalProject_quanlykho.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
            LoadAgents();
        }

        void LoadAgents()
        {
            List<Agents> agentsList = AgentsDAO.Instance.LoadAgentsList();
            dgvAgents.DataSource = agentsList;

        }

        void showOutput(int id)
        {
            float totalPrice = 0;
            //List<OutputInfo> listOutputInfo = OutputInfoDAO.Instance.GetListOutputInfo(OutputKhoDAO.Instance.GetUnPaymentOutputByAgentID(id));
            List<DTO.Menu> listOutputInfo = MenuDAO.Instance.GetListMenuByAgent(id);
            dgvReceipt.DataSource = listOutputInfo;

            for (int i = 0; i < dgvReceipt.Rows.Count; i++)
            {
                totalPrice += float.Parse(dgvReceipt.Rows[i].Cells["TotalPrice"].Value.ToString());
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTongTien.Text = totalPrice.ToString("c",culture);
        }
        private void cellClickAgents(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dgvAgents.RowCount)
            {
                return;
            }
            DataGridViewRow row = dgvAgents.Rows[index];
            int id_daily = (int)row.Cells[0].Value;

            //int id_daiLy = (sender as Agents).ID_DAILY;
            showOutput(id_daily);


            String name = Convert.ToString(row.Cells[1].Value);
            String address = Convert.ToString(row.Cells[2].Value);
            String email = Convert.ToString(row.Cells[3].Value);
            string contact = Convert.ToString(row.Cells[4].Value);

            txtAgentName.Text = name;
            txtEmail.Text = email;
            txtContact.Text = contact;
            txtAddress.Text = address;
        }
    }
}
