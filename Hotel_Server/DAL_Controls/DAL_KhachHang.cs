﻿using DTO_Hotel;
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
    public class DAL_KhachHang
    {
        private static DAL_KhachHang instance;
        public static DAL_KhachHang Instance
        {
            get { if (instance == null) instance = new DAL_KhachHang(); return DAL_KhachHang.instance; }
            private set { DAL_KhachHang.instance = value; }
        }

        private string connectionSTR = null;

        public DAL_KhachHang()
        {
            connectionSTR = DBConnection.connectionSTR;
        }

        public string Insert(DTO_KhachHang obj)
        {
            string query = string.Empty;
            query += "INSERT INTO [TBL_PHONG] ( [MAKH], [TENKH], [DIACHI], [GIOITINH], [CMND], [QUOCTICH], [SDT] )";
            query += "VALUES (@MAKH, @TENKH, @DIACHI, @GIOITINH, @CMND, @QUOCTICH, @SDT)";
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;

                    comm.Parameters.AddWithValue("@MAKH", obj.Makh);
                    comm.Parameters.AddWithValue("@TENKH", obj.Tenkh);
                    comm.Parameters.AddWithValue("@DIACHI", obj.Diachi);
                    comm.Parameters.AddWithValue("@GIOITINH", obj.Gioitinh);
                    comm.Parameters.AddWithValue("@CMND", obj.Cmnd);
                    comm.Parameters.AddWithValue("@QUOCTICH", obj.Quoctich);
                    comm.Parameters.AddWithValue("@SDT", obj.Sdt);

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

        public string selectAll(List<DTO_KhachHang> lsObj)
        {

            string query = string.Empty;
            query += " SELECT [MAKH], [TENKH], [DIACHI], [GIOITINH], [CMND], [QUOCTICH], [SDT] ";
            query += " FROM [TBL_KHACHHANG]";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;

                    try
                    {
                        conn.Open();

                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                DTO_KhachHang obj = new DTO_KhachHang();
                                obj.Makh = reader["MAKH"].ToString();
                                obj.Tenkh = reader["TINHTRANG"].ToString();
                                obj.Diachi = reader["MALP"].ToString();
                                obj.Gioitinh = reader["SOPHONG"].ToString();
                                obj.Cmnd = (int)Convert.ToInt32(reader["SOPHONG"].ToString());
                                obj.Quoctich = reader["SOPHONG"].ToString();
                                obj.Sdt = reader["SOPHONG"].ToString();
                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Selecting fails\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string selectAllByMakh(List<DTO_KhachHang> lsObj, int makh)
        {

            string query = string.Empty;
            query += " SELECT [MAKH], [TENKH], [DIACHI], [GIOITINH], [CMND], [QUOCTICH], [SDT] ";
            query += " FROM [TBL_KHACHHANG]";
            query += " WHERE ";
            query += " [MAKH] = @MAKH ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MAKH", makh);

                    try
                    {
                        conn.Open();

                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                DTO_KhachHang obj = new DTO_KhachHang();
                                obj.Makh = reader["MAKH"].ToString();
                                obj.Tenkh = reader["TINHTRANG"].ToString();
                                obj.Diachi = reader["MALP"].ToString();
                                obj.Gioitinh = reader["SOPHONG"].ToString();
                                obj.Cmnd = (int)Convert.ToInt32(reader["SOPHONG"].ToString());
                                obj.Quoctich = reader["SOPHONG"].ToString();
                                obj.Sdt = reader["SOPHONG"].ToString();
                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Selecting fails\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string search(string kq, List<DTO_KhachHang> lsObj)
        {

            string query = string.Empty;
            query += " SELECT [MAKH], [TENKH], [DIACHI], [GIOITINH], [CMND], [QUOCTICH], [SDT] ";
            query += " FROM [TBL_KHACHHANG]";
            query += " WHERE ";
            query += " [MAKH] LIKE @MAKH ";
            query += "  OR [TENKH] LIKE @TENKH ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MAKH", "%" + kq.ToString() + "%");
                    comm.Parameters.AddWithValue("@TENKH", "%" + kq.ToString() + "%");

                    try
                    {
                        conn.Open();

                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                DTO_KhachHang obj = new DTO_KhachHang();
                                obj.Makh = reader["MAKH"].ToString();
                                obj.Tenkh = reader["TINHTRANG"].ToString();
                                obj.Diachi = reader["MALP"].ToString();
                                obj.Gioitinh = reader["SOPHONG"].ToString();
                                obj.Cmnd = (int)Convert.ToInt32(reader["SOPHONG"].ToString());
                                obj.Quoctich = reader["SOPHONG"].ToString();
                                obj.Sdt = reader["SOPHONG"].ToString();
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

        public string delete(DTO_KhachHang obj)
        {
            string query = string.Empty;
            query += " DELETE FROM [TBL_KHACHHANG] ";
            query += " WHERE ";
            query += " [MAKH] = @MAKH ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MAKH", obj.Makh);
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

        public string update(DTO_KhachHang obj)
        {
            string query = string.Empty;
            query += " UPDATE [TBL_KHACHHANG] SET";
            query += " [TENKH] = @TENKH";
            query += ", [DIACHI] = @DIACHI";
            query += ", [GIOITINH] = @GIOITINH";
            query += ", [CMND] = @CMND";
            query += ", [QUOCTICH] = @QUOCTICH";
            query += ", [SDT] = @SDT";
            query += " WHERE ";
            query += " [MAKH] = @MAKH ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MAKH", obj.Makh);
                    comm.Parameters.AddWithValue("@TENKH", obj.Tenkh);
                    comm.Parameters.AddWithValue("@DIACHI", obj.Diachi);
                    comm.Parameters.AddWithValue("@GIOITINH", obj.Gioitinh);
                    comm.Parameters.AddWithValue("@CMND", obj.Cmnd);
                    comm.Parameters.AddWithValue("@QUOCTICH", obj.Quoctich);
                    comm.Parameters.AddWithValue("@SDT", obj.Sdt);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' Cập nhật that bai!!!
                        return "Updating fails\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string TaoMa()
        {
            string Makh = null;
            string query = string.Empty;
            query += "AUTO_IDKH";
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = query;
                    SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.VarChar);

                    //  
                    resultParam.Direction = ParameterDirection.ReturnValue;

                    comm.Parameters.Add(resultParam);

                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();

                        if (resultParam.Value != DBNull.Value)
                        {
                            Makh = (string)resultParam.Value;
                        }

                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' Cập nhật that bai!!!
                        return "Tạo mã thất bại" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
                return Makh;
            }

            //public List<DTO_KhachHang> LoadKhachHang()
            //{
            //    string query = string.Empty;
            //    List<DTO_KhachHang> list = new List<DTO_KhachHang>();
            //    query += "";
            //    DataTable data = DBConnection.Instance.ExecuteQuery(query);
            //    foreach(DataRow item in data.Rows)
            //    {
            //        DTO_KhachHang khachhang = new DTO_KhachHang(item);
            //        list.Add(khachhang);
            //    }
            //    return list;
            //}
        }
    }
}
