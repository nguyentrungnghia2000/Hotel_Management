﻿using System;
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
        private string donvi;
        private string madv;

        public string Macthd { get => macthd; set => macthd = value; }
        public string Makh { get => makh; set => makh = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Ngaynhanphong { get => ngaynhanphong; set => ngaynhanphong = value; }
        public string Ngaydi { get => ngaydi; set => ngaydi = value; }
        public string Sophong { get => sophong; set => sophong = value; }
        public int Tratruoc { get => tratruoc; set => tratruoc = value; }
        public string Donvi { get => donvi; set => donvi = value; }
        public string Madv { get => madv; set => madv = value; }
    }
}
