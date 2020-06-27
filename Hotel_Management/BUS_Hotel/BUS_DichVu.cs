using DAL_Hotel;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS_Hotel
{
    public class BUS_DichVu
    {
        private static BUS_DichVu instance;

        public static BUS_DichVu Instance { get => instance; set => instance = value; }

        public void LoadDichVu(DbDataReader data)
        {
            
            //List<DTO_DichVu> list = DAL_DichVu.Instance.LoadDichVu();
            //foreach(DTO_DichVu item in list)
            //{
            //}
        }
    }
}
