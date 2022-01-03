using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_quanlykho.DTO
{
    public class OutputKho
    {

        public OutputKho(int id_output, int statuspayment, string payment, string deliverystatus, DateTime date_output)
        {
            this.ID_OUTPUT = id_output;
            this.STATUSPAYMENT = statuspayment;
            this.PAYMENT = payment;
            this.DELIVERYSTATUS = deliverystatus;
            this.DATE_OUTPUT = date_output;
        }

        public OutputKho(DataRow row)
        {
            this.ID_OUTPUT = (int)row["ID_OUTPUT"];
            this.STATUSPAYMENT = (int)row["STATUSPAYMENT"];
            this.PAYMENT = (string)row["PAYMENT"];
            this.DELIVERYSTATUS = (string)row["DELIVERYSTATUS"];
            this.DATE_OUTPUT = (DateTime)row["DATE_OUTPUT"];
        }


        private int iD_OUTPUT;
        public int ID_OUTPUT { get => iD_OUTPUT; set => iD_OUTPUT = value; }

        private int sTATUSPAYMENT;
        public int STATUSPAYMENT { get => sTATUSPAYMENT; set => sTATUSPAYMENT = value; }


        private string pAYMENT;
        public string PAYMENT { get => pAYMENT; set => pAYMENT = value; }

        private string dELIVERYSTATUS;
        public string DELIVERYSTATUS { get => dELIVERYSTATUS; set => dELIVERYSTATUS = value; }

        private DateTime dATE_OUTPUT;
        public DateTime DATE_OUTPUT { get => dATE_OUTPUT; set => dATE_OUTPUT = value; }
    }
}
