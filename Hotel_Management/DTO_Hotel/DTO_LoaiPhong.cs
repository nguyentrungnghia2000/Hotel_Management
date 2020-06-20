using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_LoaiPhong
    {
        private string malp;
        private string tenlp;
        private string trangthietbi;
        private int gia;
        private string donvi;

        public DTO_LoaiPhong(string malp, string tenlp, string trangthietbi, int gia, string donvi)
        {
            this.Malp = malp;
            this.Tenlp = tenlp;
            this.Trangthietbi = trangthietbi;
            this.Gia = gia;
            this.Donvi = donvi;
        }

        public DTO_LoaiPhong(DataRow row)
        {
            this.Malp = row["MAKH"].ToString();
            this.Tenlp = row["TENKH"].ToString();
            this.Trangthietbi = row["DIACHI"].ToString();
            this.Gia = (int)Convert.ToInt32(row["CMND"].ToString());
            this.Donvi = row["QUOCTICH"].ToString();
        }

        public string Malp { get => malp; set => malp = value; }
        public string Tenlp { get => tenlp; set => tenlp = value; }
        public string Trangthietbi { get => trangthietbi; set => trangthietbi = value; }
        public int Gia { get => gia; set => gia = value; }
        public string Donvi { get => donvi; set => donvi = value; }
    }
}
