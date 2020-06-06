using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL_Hotel
{
    public class DBConnection
    {
        protected SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4BQDKGPF;Initial Catalog=QLKS;Integrated Security=True");
    }
}
