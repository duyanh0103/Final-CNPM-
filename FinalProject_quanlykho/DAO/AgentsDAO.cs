using FinalProject_quanlykho.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_quanlykho.DAO
{
    public class AgentsDAO
    {
        private static AgentsDAO instance;
        public static AgentsDAO Instance
        {
            get { if (instance == null) instance = new AgentsDAO(); return AgentsDAO.instance; }
            private set { AgentsDAO.instance = value; }
        }

        private AgentsDAO() { }

        public List<Agents> LoadAgentsList()
        {
            List<Agents> agentsList = new List<Agents>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from daily ");
            foreach (DataRow item in data.Rows)
            {
                Agents agents = new Agents(item);
                agentsList.Add(agents);
            }
            return agentsList;
        }
    }
}
