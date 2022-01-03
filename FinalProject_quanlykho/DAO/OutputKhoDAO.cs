using FinalProject_quanlykho.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_quanlykho.DAO
{
    public class OutputKhoDAO
    {

        private static OutputKhoDAO instance;

        public static OutputKhoDAO Instance
        {
            get { if (instance == null) instance = new OutputKhoDAO(); return OutputKhoDAO.instance; }
            private set { OutputKhoDAO.instance = value; }
        }

        private OutputKhoDAO() { }
        // thành công : ID_OUPUT
        //thất bại: -1

        public int GetUnPaymentOutputByAgentID(int id_daily)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from outputkho where ID_DAILY = " + id_daily + "AND statuspayment = 0");

            if (data.Rows.Count > 0)
            {
                OutputKho outputKho = new OutputKho(data.Rows[0]);
                return outputKho.ID_OUTPUT;
            }
            return -1;
        }
    }
}
