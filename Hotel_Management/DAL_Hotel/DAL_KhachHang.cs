using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Hotel
{
    public class DAL_KhachHang
    {
        private static DAL_KhachHang instance;

        public static DAL_KhachHang Instance { get => instance; set => instance = value; }

        public List<DTO_KhachHang> LoadKhachHang(DTO_KhachHang obj)
        {
            string query = string.Empty;
            List<DTO_KhachHang> list = new List<DTO_KhachHang>();
            query += "";
            DataTable data = DBConnection.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                DTO_KhachHang khachhang = new DTO_KhachHang(item);
                list.Add(khachhang);
            }
            return list;
        }
    }
}
