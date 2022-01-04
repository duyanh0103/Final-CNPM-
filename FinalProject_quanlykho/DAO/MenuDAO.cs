using FinalProject_quanlykho.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_quanlykho.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }

        }

        private MenuDAO() { }

        public List<Menu> GetListMenuByAgent(int id)
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "select p.TENSANPHAM, OI.SOLUONG, P.GIABAN, ok.STATUSPAYMENT,ok.PAYMENT, ok.DELIVERYSTATUS, ok.DATE_OUTPUT ,  P.GIABAN * OI.SOLUONG AS N'ĐƠN GIÁ' from outputinfo oi, outputkho ok, product p where oi.ID_OUTPUT = ok.ID_OUTPUT AND oi.IDSANPHAM = p.IDSANPHAM AND OK.ID_DAILY = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }

    }
}
