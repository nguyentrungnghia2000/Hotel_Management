using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO_Hotel;

namespace DAL_Hotel
{
   public class DAL_SignIn:DBConnection
    {
        public string SignIn(DTO_SignIn account)
        {
            try
            {
                conn.Open();
                string sql = string.Format("SELECT CHUCVU FROM TBL_TAIKHOAN WHERE TAIKHOAN = '"+account.user + "' and MATKHAU = '"+ account.pass + "'");
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true) 
                {
                    return dta["CHUCVU"].ToString();
                }
                else
                {
                    return "0";
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return "0";
        }
        
    }
}
