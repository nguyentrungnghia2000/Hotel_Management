using DAL_Hotel;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Hotel
{
    public class BUS_KhachHang
    {
        private static BUS_KhachHang instance;

        public static BUS_KhachHang Instance { get => instance; set => instance = value; }

    }
}
