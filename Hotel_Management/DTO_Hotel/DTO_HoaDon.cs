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
        private string ngaythanhtoan;
        private int tratruoc;
        private string mavn;

        public string Mahd { get => mahd; set => mahd = value; }
        public string Ngaythanhtoan { get => ngaythanhtoan; set => ngaythanhtoan = value; }
        public int Tratruoc { get => tratruoc; set => tratruoc = value; }
        public string Mavn { get => mavn; set => mavn = value; }
    }
}
