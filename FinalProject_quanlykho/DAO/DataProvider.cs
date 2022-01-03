using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_quanlykho.DAO
{
    public class DataProvider
    {

        private static DataProvider instance;
        public static DataProvider Instance 
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; } 
        }

        private DataProvider() { }
        private string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=quanlykho;Integrated Security=True";

       

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            //lay du lieu ra
            DataTable data = new DataTable();

            //kết nối client ==> server
            using (SqlConnection connection = new SqlConnection(connectionSTR)) 
            {
                connection.Open();
                //thực hiện câu truy vấn 

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    //phân biệt nhau bởi khoảng trắng
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        //item chua parameter
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                //==> trung gian lấy dữ liệu và thưc hiện câu truy vấn
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);
                connection.Close();
            }


            return data;
        }

        //executeNonQuery ==> trả ra số dòng thành công
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            //cho dù vấn đề là gì thì khi kết thúc dữ liệu sẽ tự giải phóng
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();


                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        //item chua parameter
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        //executeScallar ==> đếm số lượng
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            //cho dù vấn đề là gì thì khi kết thúc dữ liệu sẽ tự giải phóng
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();


                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        //item chua parameter
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }

    }
}
