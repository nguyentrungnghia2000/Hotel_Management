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
    public class DAL_CTHD
    {
        private string connectionSTR = null;

        public DAL_CTHD()
        {
            connectionSTR = ConfigurationManager.AppSettings["ConnectionSTR"];
        }

        public string Insert(DTO_CTHD obj)
        {
            string query = string.Empty;
            query += "INSERT INTO [TBL_CTHD] ( [MACTHD], [MAKH], [MANV], [NGAYNHANPHONG], [NGAYDI], [SOPHONG], [TRATRUOC], [DONVI], [MADV] )";
            query += "VALUES (@MACTHD, @MAKH, @MANV, @NGAYNHANPHONG, @NGAYDI, @SOPHONG, @TRATRUOC, @DONVI, @MADV)";
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;

                    comm.Parameters.AddWithValue("@MACTHD", obj.Macthd);
                    comm.Parameters.AddWithValue("@MAKH", obj.Makh);
                    comm.Parameters.AddWithValue("@MANV", obj.Manv);
                    comm.Parameters.AddWithValue("@NGAYNHANPHONG", obj.Ngaynhanphong);
                    comm.Parameters.AddWithValue("@NGAYDI", obj.Ngaydi);
                    comm.Parameters.AddWithValue("@SOPHONG", obj.Sophong);
                    comm.Parameters.AddWithValue("@TRATRUOC", obj.Tratruoc);
                    comm.Parameters.AddWithValue("@DONVI", obj.Donvi);
                    comm.Parameters.AddWithValue("@MADV", obj.Madv);

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

        public string Delete(DTO_CTHD obj)
        {
            string query = string.Empty;
            query += " DELETE FROM [TBL_CTHD] ";
            query += " WHERE ";
            query += " [MACTHD] = @MACTHD ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MACTHD", obj.Macthd);
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

        public string Update(DTO_CTHD obj)
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
                    comm.Parameters.AddWithValue("@MACTHD", obj.Macthd);
                    comm.Parameters.AddWithValue("@MAKH", obj.Makh);
                    comm.Parameters.AddWithValue("@MANV", obj.Manv);
                    comm.Parameters.AddWithValue("@NGAYNHANPHONG", obj.Ngaynhanphong);
                    comm.Parameters.AddWithValue("@NGAYDI", obj.Ngaydi);
                    comm.Parameters.AddWithValue("@SOPHONG", obj.Sophong);
                    comm.Parameters.AddWithValue("@TRATRUOC", obj.Tratruoc);
                    comm.Parameters.AddWithValue("@DONVI", obj.Donvi);
                    comm.Parameters.AddWithValue("@MADV", obj.Madv);

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

        public string Search(string kq, List<DTO_CTHD> lsObj)
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
                                DTO_CTHD obj = new DTO_CTHD();
                                obj.Macthd = reader["MACTHD"].ToString();
                                obj.Makh = reader["MAKH"].ToString();
                                obj.Ngaynhanphong = reader["NGAYNHANPHONG"].ToString();
                                obj.Ngaydi = reader["NGAYDI"].ToString();
                                obj.Sophong = reader["SOPHONG"].ToString();
                                obj.Donvi = reader["DONVI"].ToString();
                                obj.Madv = reader["MADV"].ToString();
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
