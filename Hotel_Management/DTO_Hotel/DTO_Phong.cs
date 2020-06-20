using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_Phong
    {
        private int sophong;
        private string status;
        private string malp;

        public DTO_Phong(int sophong, string trangthai, string malp)
        {
            this.Sophong = sophong;
            this.Status = trangthai;
            this.Malp = malp;
        }

        public DTO_Phong(DataRow row)
        {
            this.Sophong = (int)Convert.ToInt32(row["SOPHONG"].ToString());
            this.Status = row["TINHTRANG"].ToString();
            this.Malp = row["MALP"].ToString();
        }

        public int Sophong { get => sophong; set => sophong = value; }
        public string Status { get => status; set => status = value; }
        public string Malp { get => malp; set => malp = value; }
    }
}
