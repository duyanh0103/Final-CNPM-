using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_quanlykho.DTO
{
    public class Menu
    {


        public Menu(string tensanpham, int count, float giaban, int statuspayment, string payment, string deliverystatus , float totalPrice, DateTime date_output)
        {
            this.TENSANPHAM = tensanpham;
            this.Count = count;
            this.GIABAN = giaban;
            this.TotalPrice = totalPrice;
            this.STATUSPAYMENT = statuspayment;
            this.PAYMENT = payment;
            this.DELIVERYSTATUS = deliverystatus;
            this.DATE_OUTPUT = date_output;
        }
        //đặt propertyname theo this.'...' trong ''
        public Menu(DataRow row)
        {
            this.TENSANPHAM = row["TENSANPHAM"].ToString();
            this.Count = (int)row["SOLUONG"];
            this.GIABAN = (float)Convert.ToDouble(row["GIABAN"].ToString());
            this.STATUSPAYMENT = (int)row["STATUSPAYMENT"];
            this.PAYMENT = row["PAYMENT"].ToString();
            this.DELIVERYSTATUS = row["DELIVERYSTATUS"].ToString();
            this.TotalPrice = (float)Convert.ToDouble(row["ĐƠN GIÁ"].ToString()); //cái này là thành tiền 
            this.DATE_OUTPUT = (DateTime)row["DATE_OUTPUT"];

        }

        private DateTime dATE_OUTPUT;
        public DateTime DATE_OUTPUT { get => dATE_OUTPUT; set => dATE_OUTPUT = value; }

        private string dELIVERYSTATUS;
        public string DELIVERYSTATUS { get => dELIVERYSTATUS; set => dELIVERYSTATUS = value; }

        private string pAYMENT;
        public string PAYMENT { get => pAYMENT; set => pAYMENT = value; }

        private int sTATUSPAYMENT;

        public int STATUSPAYMENT { get => sTATUSPAYMENT; set => sTATUSPAYMENT = value; }

        private float totalPrice;
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }

        private float gIABAN;
        public float GIABAN { get => gIABAN; set => gIABAN = value; }
        private int count;
        public int Count { get => count; set => count = value; }


        private string tENSANPHAM;
        public string TENSANPHAM { get => tENSANPHAM; set => tENSANPHAM = value; }
        
    }
}
