using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_quanlykho.DTO
{
    public class OutputInfo
    {
        public OutputInfo(int id_outputinfo, string idsanpham, int id_output, int soluong)
        {
            this.ID_OUTPUTINFO = id_outputinfo;
            this.IDSANPHAM = idsanpham;
            this.ID_OUTPUT = id_output;
            this.SOLUONG = soluong;
        }

        public OutputInfo(DataRow row)
        {
            this.ID_OUTPUTINFO = (int)row["id_outputinfo"];
            this.IDSANPHAM = (string)row["IDSANPHAM"];
            this.ID_OUTPUT = (int)row["ID_OUTPUT"];
            this.SOLUONG = (int)row["SOLUONG"];
        }


        private int iD_OUTPUTINFO;
        public int ID_OUTPUTINFO { get => iD_OUTPUTINFO; set => iD_OUTPUTINFO = value; }

        private string iDSANPHAM;
        public string IDSANPHAM { get => iDSANPHAM; set => iDSANPHAM = value; }


        private int iD_OUTPUT;
        public int ID_OUTPUT { get => iD_OUTPUT; set => iD_OUTPUT = value; }

        private int sOLUONG;
        public int SOLUONG { get => sOLUONG; set => sOLUONG = value; }
    }
}
