﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    class NhanVienDTO
    {
        private string manv;

        public string Manv { get => manv; set => manv = value; }
        public string Name { get => name; set => name = value; }
        public string Malnv { get => malnv; set => malnv = value; }
        public string Date { get => date; set => date = value; }
        public bool Sex { get => sex; set => sex = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Address { get => address; set => address = value; }

        private string name;
        private string malnv;
        private string date;
        private bool sex;
        private string sdt;
        private string address;

        public NhanVienDTO(string manv, string name, string malnv, string date, bool sex, string sdt, string address)
        {
            this.manv = manv;
            this.name = name;
            this.malnv = malnv;
            this.date = date;
            this.sex = sex;
            this.sdt = sdt;
            this.address = address;
        }
    }
}
