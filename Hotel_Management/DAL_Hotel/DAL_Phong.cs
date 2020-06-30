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
    public class DAL_Phong
    {
        private static DAL_Phong instance;
        public static DAL_Phong Instance
        {
            get { if (instance == null) instance = new DAL_Phong(); return DAL_Phong.instance; }
            private set { DAL_Phong.instance = value; }
        }

        private string connectionSTR = null;

        public DAL_Phong()
        {
            connectionSTR = ConfigurationManager.AppSettings["ConnectionSTR"];
        }

        public string Insert(DTO_Phong obj)
        {
            string query = string.Empty;
            query += "INSERT INTO [TBL_PHONG] ( [SOPHONG], [TINHTRANG], [MALP] )";
            query += "VALUES (@SOPHONG, @TINHTRANG, @MALP)";
            using(SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using(SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;

                    comm.Parameters.AddWithValue("@SOPHONG", obj.Sophong);
                    comm.Parameters.AddWithValue("@TINHTRANG", obj.Status);
                    comm.Parameters.AddWithValue("@MALP", obj.Malp);

                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        conn.Close();
                        return "Adding fails\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string selectAll(List<DTO_Phong> lsObj)
        {

            string query = string.Empty;
            query += " SELECT [SOPHONG], [TINHTRANG], [MALP]";
            query += " FROM [TBL_PHONG]";

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
                                DTO_Phong obj = new DTO_Phong();
                                obj.Sophong = reader["SOPHONG"].ToString();
                                obj.Status = reader["TINHTRANG"].ToString();
                                obj.Malp = reader["MALP"].ToString();
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

        public string selectAllBySophong(List<DTO_Phong> lsObj, int sophong)
        {

            string query = string.Empty;
            query += " SELECT [SOPHONG], [TINHTRANG], [MALP]";
            query += " FROM [TBL_PHONG]";
            query += " WHERE ";
            query += " [SOPHONG] = @SOPHONG ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@SOPHONG", sophong);

                    try
                    {
                        conn.Open();

                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                DTO_Phong obj = new DTO_Phong();
                                obj.Sophong = reader["SOPHONG"].ToString();
                                obj.Status = reader["TINHTRANG"].ToString();
                                obj.Malp = reader["MALP"].ToString();
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

        public string search(string kq, List<DTO_Phong> lsObj)
        {

            string query = string.Empty;
            query += " SELECT [MAKH], [TENKH], [DIACHI], [GIOITINH], [CMND], [QUOCTICH], [SDT] ";
            query += " FROM [TBL_KHACHHANG]";
            query += " WHERE ";
            query += " [SOPHONG] LIKE @SOPHONG ";

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
                                DTO_Phong obj = new DTO_Phong();
                                obj.Sophong = reader["SOPHONG"].ToString();
                                obj.Status = reader["TINHTRANG"].ToString();
                                obj.Malp = reader["MALP"].ToString();
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

        public string delete(DTO_Phong obj)
        {
            string query = string.Empty;
            query += " DELETE FROM [TBL_PHONG] ";
            query += " WHERE ";
            query += " [SOPHONG] = @SOPHONG ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@SOPHONG", obj.Sophong);
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

        public string update(DTO_Phong obj)
        {
            string query = string.Empty;
            query += " UPDATE [TBL_PHONG] SET";
            query += " [TINHTRANG] = @TINHTRANG";
            query += " WHERE ";
            query += " [SOPHONG] = @SOPHONG ";

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@SOPHONG", obj.Sophong);
                    comm.Parameters.AddWithValue("@TINHTRANG", obj.Status);
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

        //public List<DTO_Phong> LoadListRoom()
        //{

        //    List<DTO_Phong> roomlist = new List<DTO_Phong>();
        //    DataTable data = DBConnection.Instance.ExecuteQuery("EXECUTE USP_GETROOM");
        //    foreach (DataRow item in data.Rows)
        //    {
        //        DTO_Phong phong = new DTO_Phong(item);
        //        roomlist.Add(phong);
        //    }
        //    return roomlist;
        //}
    }
}
