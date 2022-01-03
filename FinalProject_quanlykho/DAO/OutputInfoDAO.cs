using FinalProject_quanlykho.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_quanlykho.DAO
{
    public class OutputInfoDAO
    {
        private static OutputInfoDAO instance;

        public static OutputInfoDAO Instance
        {
            get { if (instance == null) instance = new OutputInfoDAO(); return OutputInfoDAO.instance; }
            private set { OutputInfoDAO.instance = value; }
        }

        public OutputInfoDAO() { }

        public List<OutputInfo> GetListOutputInfo(int id_output)
        {
            List<OutputInfo> listOutputInfo = new List<OutputInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from outputinfo where id_output = " + id_output);
            foreach (DataRow item in data.Rows)
            {
                OutputInfo info = new OutputInfo(item);
                listOutputInfo.Add(info);
            }


            return listOutputInfo;
        }
    }
}
