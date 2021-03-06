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
    public class DAL_LoaiPhong
    {
        private string connectionSTR = null;

        public DAL_LoaiPhong()
        {
            connectionSTR = DBConnection.connectionSTR;
        }

        public string SelectAllByMaLP(List<DTO_LoaiPhong> lsObj, string malp)
        {

            string query = string.Empty;
            query += " EXEC USP_GETBYMALP @MALP = ";
            query += malp;

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MALP", malp);

                    try
                    {
                        conn.Open();

                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                DTO_LoaiPhong obj = new DTO_LoaiPhong();
                                obj.Malp = reader["MALP"].ToString();
                                obj.Tenlp = reader["TENLP"].ToString();
                                obj.Gia = reader["GIA"].ToString();
                                obj.Trangthietbi = reader["TRANGTHIETBI"].ToString();
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

        public string selectAll(List<DTO_LoaiPhong> lsObj)
        {

            string query = string.Empty;
            query += " EXEC USP_GETLOAIPHONG";

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
                                DTO_LoaiPhong obj = new DTO_LoaiPhong();
                                obj.Malp = reader["MALP"].ToString();
                                obj.Tenlp = reader["TENLP"].ToString();
                                obj.Trangthietbi = reader["TRANGTHIETBI"].ToString();
                                obj.Gia = reader["GIA"].ToString();
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

        public string Insert(DTO_LoaiPhong obj)
        {
            string query = string.Empty;
            query += "INSERT INTO [TBL_LOAIPHONG] ( [MALP], [TENLP], [TRANGTHIETBI], [GIA] )";
            query += "VALUES (@MALP, @TENLP, @TRANGTHIETBI, @GIA)";
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;

                    comm.Parameters.AddWithValue("@MALP", obj.Malp);
                    comm.Parameters.AddWithValue("@TENLP", obj.Tenlp);
                    comm.Parameters.AddWithValue("@TRANGTHIETBI", obj.Trangthietbi);
                    comm.Parameters.AddWithValue("@GIA", obj.Gia);

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

        public string Delete(DTO_LoaiPhong obj)
        {
            string query = string.Empty;
            query += " DELETE FROM [TBL_LOAIPHONG] ";
            query += " WHERE ";
            query += " [MALP] = @MALP ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MALP", obj.Malp);
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

        public string Update(DTO_LoaiPhong obj)
        {
            string query = string.Empty;
            query += "USP_UPDATELOAIPHONG";
            //query += ", @TENLP";
            //query += ", @TRANGTHIETBI";
            //query += ", @GIA";
            //query += ", @MALP";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MALP", obj.Malp);
                    comm.Parameters.AddWithValue("@TENLP", obj.Tenlp);
                    comm.Parameters.AddWithValue("@TRANGTHIETBI", obj.Trangthietbi);
                    comm.Parameters.AddWithValue("@GIA", obj.Gia);
                    

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

        public string Search(string kq, List<DTO_LoaiPhong> lsObj)
        {

            string query = string.Empty;
            query += " SELECT [MALP], [TENLP], [TRANGTHIETBI], [GIA], [DONVI]";
            query += " FROM [TBL_LOAIPHONG]";
            query += " WHERE";
            query += " [MALP] = @MALP ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MALP", "%" + kq.ToString() + "%");
                    comm.Parameters.AddWithValue("@TENLP", "%" + kq.ToString() + "%");

                    try
                    {
                        conn.Open();

                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                DTO_LoaiPhong obj = new DTO_LoaiPhong();
                                obj.Malp = reader["MALP"].ToString();
                                obj.Tenlp = reader["TENLP"].ToString();
                                obj.Trangthietbi = reader["TRANGTHIETBI"].ToString();
                                obj.Gia = reader["GIA"].ToString();

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
