using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Hotel
{
    public class DAL_HoaDon
    {
        private string connectionSTR = null;

        public DAL_HoaDon()
        {
            connectionSTR = ConfigurationManager.AppSettings["ConnectionSTR"];
        }

        public string Insert(DTO_HoaDon obj)
        {
            string query = string.Empty;
            query += "INSERT INTO [TBL_HOADON] ( [MAHD], [NGAYTHANHTOAN], [TRATRUOC], [MANV] )";
            query += "VALUES (@MALP, @NGAYTHANHTOAN, @TRATRUOC, @MANV)";
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;

                    comm.Parameters.AddWithValue("@MAHD", obj.Mahd);
                    comm.Parameters.AddWithValue("@NGAYTHANHTOAN", obj.Ngaythanhtoan);
                    comm.Parameters.AddWithValue("@TRATRUOC", obj.Tratruoc);
                    comm.Parameters.AddWithValue("@MANV", obj.Mavn);

                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Adding fails\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string Delete(DTO_HoaDon obj)
        {
            string query = string.Empty;
            query += " DELETE FROM [TBL_HOADON] ";
            query += " WHERE ";
            query += " [MAHD] = @MAHD ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MAHD", obj.Mahd);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Deleting fails\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string Update(DTO_HoaDon obj)
        {
            string query = string.Empty;
            query += " UPDATE [TBL_HOADON] SET";
            query += " [NGAYTHANHTOAN] = @NGAYTHANHTOAN";
            query += " [TRATRUOC] = @TRATRUOC";
            query += " [MANV] = @MANV";
            query += " WHERE ";
            query += " [MAHD] = @MAHD ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MAHD", obj.Mahd);
                    comm.Parameters.AddWithValue("@NGAYTHANHTOAN", obj.Ngaythanhtoan);
                    comm.Parameters.AddWithValue("@TRATRUOC", obj.Tratruoc);
                    comm.Parameters.AddWithValue("@MANV", obj.Mavn);

                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Updating fails\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string Search(string kq, List<DTO_HoaDon> lsObj)
        {

            string query = string.Empty;
            query += " SELECT [MAHD], [NGAYTHANHTOAN], [TRATRUOC], [MANV]";
            query += " FROM [TBL_HOADON]";
            query += " WHERE";
            query += " [MAHD] = @MAHD ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MAHD", "%" + kq.ToString() + "%");

                    try
                    {
                        conn.Open();

                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                DTO_HoaDon obj = new DTO_HoaDon();
                                obj.Mahd = reader["MAHD"].ToString();
                                obj.Ngaythanhtoan = reader["NGAYTHANHTOAN"].ToString();
                                obj.Mavn = reader["MANV"].ToString();
                                obj.Tratruoc = (int)Convert.ToInt32(reader["TRATRUOC"].ToString());

                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Searching fail fails\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }
    }
}
