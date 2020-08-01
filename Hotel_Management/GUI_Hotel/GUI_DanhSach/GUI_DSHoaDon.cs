using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Hotel;
using BUS_Hotel;

namespace Hotel_Management.GUI_DanhSach
{
    public partial class GUI_DSHoaDon : UserControl
    {
        public GUI_DSHoaDon()
        {
            InitializeComponent();
        }

        BUS_CTHD bus_cthd = new BUS_CTHD();
        BUS_HoaDon bus_hd = new BUS_HoaDon();
        BUS_CTDV bus_ctdv = new BUS_CTDV();
        BUS_DichVu bus_dv = new BUS_DichVu();
        

        void LoadListHoaDon()
        {
            List<DTO_CTHD> lscthd = new List<DTO_CTHD>();
            List<DTO_HoaDon> lshd = new List<DTO_HoaDon>();
            List<DTO_CTDV> lsctdv = new List<DTO_CTDV>();
            List<DTO_DichVu> lsdv = new List<DTO_DichVu>();
            string result = bus_cthd.SelectAll(lscthd);
            string result1 = bus_hd.LoadHoaDon(lshd);
            string result2 = bus_ctdv.SelectAll(lsctdv);
            string result3 = bus_dv.LoadDichVu(lsdv);

            var listhoadon = (from x in lscthd
                              join y in lshd on x.Macthd equals y.MaCTHD
                              join z in lsctdv on x.Macthd equals z.Macthd
                              join t in lsdv on z.Madv equals t.Madv
                              where (( y.Trangthai == "DEBT" ) && (x.Trangthai == "STAYED"))
                              select new
                              {
                                  Makh = x.Makh,
                                  Sophong = x.Sophong,
                                  Tratruoc = x.Tratruoc,
                                  Hoadon = y.Mahd,
                                  Chiphi = y.Thanhtien,
                                  Trangthai = y.Trangthai,
                                  Tiendv = t.Giadv
                              });
            foreach(var item in listhoadon)
            {
                x1HoaDon hd = new x1HoaDon();
                hd.lb_makh.Text = item.Makh;
                hd.lb_sophong.Text = item.Sophong;
                hd.lb_hoadon.Text = item.Hoadon;
                int tongtien = (int)Convert.ToInt32(item.Chiphi);
                int tiendichvu = (int)Convert.ToInt32(item.Tiendv);
                int chitra = tongtien - item.Tratruoc + tiendichvu;
                hd.lb_chiphi.Text = chitra.ToString();
                hd.lb_trangthai.Text = item.Trangthai;
                panel_HoaDon.Controls.Add(hd);
                hd.Dock = DockStyle.Top;
            }
        }

        private void GUI_DSHoaDon_Load(object sender, EventArgs e)
        {
            LoadListHoaDon();
        }
    }
}
