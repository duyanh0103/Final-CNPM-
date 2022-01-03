using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_quanlykho.DTO
{
    public class Agents
    {
        public Agents(int id_daily, string tendaily, string diachi_daily, string email_daily, string phone_daily)
        {
            this.ID_DAILY = id_daily;
            this.TENDAILY = tendaily;
            this.DIACHI_DAILY = diachi_daily;
            this.EMAIL_DAILY = email_daily;
            this.PHONE_DAILY = phone_daily;

        }


        //hàm dụng data row
        public Agents(DataRow row)
        {
            this.ID_DAILY = (int)row["id_daily"];
            this.TENDAILY = row["tendaily"].ToString();
            this.DIACHI_DAILY = row["diachi_daily"].ToString();
            this.EMAIL_DAILY = row["email_daily"].ToString();
            this.PHONE_DAILY = row["phone_daily"].ToString();
        }

        private int iD_DAILY;
        public int ID_DAILY
        {
            get { return iD_DAILY; }
            set { iD_DAILY = value; }
        }

        private string tENDAILY;
        public string TENDAILY
        {
            get { return tENDAILY; }
            set { tENDAILY = value; }
        }

        private string dIACHI_DAILY;
        public string DIACHI_DAILY { get => dIACHI_DAILY; set => dIACHI_DAILY = value; }


        private string eMAIL_DAILY;
        public string EMAIL_DAILY { get => eMAIL_DAILY; set => eMAIL_DAILY = value; }


        private string pHONE_DAILY;
        public string PHONE_DAILY { get => pHONE_DAILY; set => pHONE_DAILY = value; }
    }
}
