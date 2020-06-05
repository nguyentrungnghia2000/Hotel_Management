using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL_Hotel
{
    class DBConnection
    {
        private string connectionSTR = @"Data Source=LAPTOP-RLAB8F3L\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True";

        public DataTable ExecuteQuery(string query)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            connection.Close();
            
            return table;
        }
    }
}
