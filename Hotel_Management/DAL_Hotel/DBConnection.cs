using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Hotel
{
    class DBConnection
    {
        protected SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4BQDKGPF;Initial Catalog=Library_Manager;Integrated Security=True");
    }
}
