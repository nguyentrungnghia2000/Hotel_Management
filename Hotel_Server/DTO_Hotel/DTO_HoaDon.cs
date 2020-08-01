using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_HoaDon
    {
        private string mahd;
        private string manv;
        private string maCTHD;
        private string thanhtien;
        private string trangthai;

        public string Mahd { get => mahd; set => mahd = value; }
        public string Manv { get => manv; set => manv = value; }
        public string MaCTHD { get => maCTHD; set => maCTHD = value; }
        public string Thanhtien { get => thanhtien; set => thanhtien = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
    }
}
