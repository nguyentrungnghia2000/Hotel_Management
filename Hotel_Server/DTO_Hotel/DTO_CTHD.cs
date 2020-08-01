using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_CTHD
    {
        private string macthd;
        private string makh;
        private string manv;
        private string ngaynhanphong;
        private string ngaydi;
        private string sophong;
        private int tratruoc;
        private int songuoi;
        private string trangthai;

        public string Macthd { get => macthd; set => macthd = value; }
        public string Makh { get => makh; set => makh = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Ngaynhanphong { get => ngaynhanphong; set => ngaynhanphong = value; }
        public string Ngaydi { get => ngaydi; set => ngaydi = value; }
        public string Sophong { get => sophong; set => sophong = value; }
        public int Tratruoc { get => tratruoc; set => tratruoc = value; }
        public int Songuoi { get => songuoi; set => songuoi = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
    }
}
