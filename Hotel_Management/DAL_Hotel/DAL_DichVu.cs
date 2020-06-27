using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Hotel
{
    public class DAL_DichVu
    {
        private static DAL_DichVu instance;

        public static DAL_DichVu Instance { get => instance; set => instance = value; }

        //public List<DTO_DichVu> LoadDichVu()
        //{
        //    string query = string.Empty;
        //    List<DTO_DichVu> list = new List<DTO_DichVu>();
        //    query += "select * from TBL_DICHVU";
        //    DataTable data = DBConnection.Instance.ExecuteQuery(query);
        //    foreach (DataRow item in data.Rows)
        //    {
        //        DTO_DichVu dichvu = new DTO_DichVu(item);
        //        list.Add(dichvu);
        //    }
        //    return list;
        //}
    }
}
