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
    public partial class GUI_DSDonDatPhong : UserControl
    {
        public GUI_DSDonDatPhong()
        {
            InitializeComponent();
        }

        BUS_CTHD bus_cthd = new BUS_CTHD();
        BUS_KhachHang bus_kh = new BUS_KhachHang();

        private void GUI_DSDonDatPhong_Load(object sender, EventArgs e)
        {
            LoadListDonDatPhong();
        }

        void LoadListDonDatPhong()
        {
            List<DTO_CTHD> lscthd = new List<DTO_CTHD>();
            List<DTO_KhachHang> lskh = new List<DTO_KhachHang>();
            string result = bus_cthd.SelectAll(lscthd);
            string result1 = bus_kh.SelectAll(lskh);

            var listcthd = (from x in lscthd
                            join y in lskh on x.Makh equals y.Makh
                            where (x.Trangthai == "WILLCOME")
                            select new
                            {
                                Maddp = x.Macthd,
                                TenKH = y.Tenkh,
                                Sophong = x.Sophong,
                                Ngayden = x.Ngaynhanphong,
                                Tratruoc = x.Tratruoc
                            });
            foreach(var item in listcthd)
            {
                x1DonDatPhong don = new x1DonDatPhong();
                don.lb_maddp.Text = item.Maddp;
                don.lb_tenkhachhang.Text = item.TenKH;
                don.lb_sophong.Text = item.Sophong;
                don.lb_ngayden.Text = item.Ngayden;
                don.lb_tratruoc.Text = item.Tratruoc.ToString();
                panel_DonDatPhong.Controls.Add(don);
                don.Dock = DockStyle.Top;
            }
        }
    }
}
