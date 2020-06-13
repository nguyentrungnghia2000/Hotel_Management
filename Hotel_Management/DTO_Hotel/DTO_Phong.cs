using System;
using System.Collections.Generic;
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

        public int Sophong { get => sophong; set => sophong = value; }
        public string Status { get => status; set => status = value; }
        public string Malp { get => malp; set => malp = value; }
    }
}
