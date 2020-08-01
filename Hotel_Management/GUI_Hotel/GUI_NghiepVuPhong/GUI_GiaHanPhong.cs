using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Hotel;
using DTO_Hotel;

namespace Hotel_Management.GUI_NghiepVuPhong
{
    public partial class GUI_GiaHanPhong : UserControl
    {
        public GUI_GiaHanPhong()
        {
            InitializeComponent();
        }

        string get_MACTHD;
        private string _message;

        BUS_CTHD bus_cthd = new BUS_CTHD();
        BUS_KhachHang bus_kh = new BUS_KhachHang();
        BUS_LoaiPhong bus_lp = new BUS_LoaiPhong();
        BUS_Phong bus_p = new BUS_Phong();
        BUS_DichVu bus_dv = new BUS_DichVu();
        BUS_CTDV bus_ctdv = new BUS_CTDV();
        BUS_HoaDon bus_hoadon = new BUS_HoaDon();
        DTO_Phong obj = new DTO_Phong();

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        private void LoadThongTinKHTuMAKH()
        {
            List<DTO_KhachHang> lsobj_kh = new List<DTO_KhachHang>();
            List<DTO_CTHD> lsobj_cthd = new List<DTO_CTHD>();
            List<DTO_LoaiPhong> lsobj_lp = new List<DTO_LoaiPhong>();
            List<DTO_Phong> lsobj_p = new List<DTO_Phong>();

            string result = bus_kh.SelectAll(lsobj_kh);
            string result1 = bus_cthd.SelectAll(lsobj_cthd);
            string result2 = bus_lp.SelectAll(lsobj_lp);
            string result3 = bus_p.SelectAll(lsobj_p);

            var query = (from kh in lsobj_kh
                         join cthd in lsobj_cthd on kh.Makh equals cthd.Makh
                         join p in lsobj_p on cthd.Sophong equals p.Sophong
                         join lp in lsobj_lp on p.Malp equals lp.Malp
                         where kh.Makh == txb_makh.Text
                         select new
                         {
                             TenKH = kh.Tenkh,
                             CMND = kh.Cmnd,
                             GioiTinh = kh.Gioitinh,
                             NgaySinh = kh.Ngaysinh,
                             SDT = kh.Sdt,
                             QuocTich = kh.Quoctich,
                             DiaChi = kh.Diachi,
                             NgayNhanPhong = cthd.Ngaynhanphong,
                             NgayDi = cthd.Ngaydi,
                             LoaiPhong = lp.Tenlp,
                             SoPhong = p.Sophong,
                             MACTHD = cthd.Macthd,
                             SoNguoi = cthd.Songuoi
                         }
                );

            foreach (var item in query)
            {
                txb_tenkh.Text = item.TenKH;
                txb_cmnd.Text = item.CMND.ToString();
                txb_gioitinh.Text = item.GioiTinh;
                txb_sinhnhat.Text = item.NgaySinh;
                txb_sodt.Text = item.SDT;
                txb_quoctich.Text = item.QuocTich;
                txb_diachi.Text = item.DiaChi;
                txb_ngaynhanphong.Text = item.NgayNhanPhong;
                txb_ngaydi.Text = item.NgayDi;
                txb_loaiphong.Text = item.LoaiPhong;
                txb_sophong.Text = item.SoPhong;
                txb_songuoi.Text = item.SoNguoi.ToString();
                get_MACTHD = item.MACTHD;
            }
        }

        private void LoadThongTinTuCMND()
        {
            List<DTO_KhachHang> lsobj_kh = new List<DTO_KhachHang>();
            List<DTO_CTHD> lsobj_cthd = new List<DTO_CTHD>();
            List<DTO_LoaiPhong> lsobj_lp = new List<DTO_LoaiPhong>();
            List<DTO_Phong> lsobj_p = new List<DTO_Phong>();

            string result = bus_kh.SelectAll(lsobj_kh);
            string result1 = bus_cthd.SelectAll(lsobj_cthd);
            string result2 = bus_lp.SelectAll(lsobj_lp);
            string result3 = bus_p.SelectAll(lsobj_p);
            var query = (from kh in lsobj_kh
                         join cthd in lsobj_cthd on kh.Makh equals cthd.Makh
                         join p in lsobj_p on cthd.Sophong equals p.Sophong
                         join lp in lsobj_lp on p.Malp equals lp.Malp
                         where kh.Cmnd.ToString() == txb_cmnd.Text
                         select new
                         {
                             TenKH = kh.Tenkh,
                             CMND = kh.Cmnd,
                             GioiTinh = kh.Gioitinh,
                             NgaySinh = kh.Ngaysinh,
                             SDT = kh.Sdt,
                             QuocTich = kh.Quoctich,
                             DiaChi = kh.Diachi,
                             NgayNhanPhong = cthd.Ngaynhanphong,
                             NgayDi = cthd.Ngaydi,
                             LoaiPhong = lp.Tenlp,
                             SoPhong = p.Sophong,
                             SoNguoi = cthd.Songuoi,
                             MACTHD = cthd.Macthd
                         }
                );

            foreach (var item in query)
            {
                txb_tenkh.Text = item.TenKH;
                txb_cmnd.Text = item.CMND.ToString();
                txb_gioitinh.Text = item.GioiTinh;
                txb_sinhnhat.Text = item.NgaySinh;
                txb_sodt.Text = item.SDT;
                txb_quoctich.Text = item.QuocTich;
                txb_diachi.Text = item.DiaChi;
                txb_ngaynhanphong.Text = item.NgayNhanPhong;
                txb_ngaydi.Text = item.NgayDi;
                txb_loaiphong.Text = item.LoaiPhong;
                txb_sophong.Text = item.SoPhong;
                txb_songuoi.Text = item.SoNguoi.ToString();
                get_MACTHD = item.MACTHD;
            }
        }

        void ClearTools()
        {
            txb_tenkh.Text = "";
            txb_cmnd.Text = "";
            txb_gioitinh.Text = "";
            txb_sinhnhat.Text = "";
            txb_sodt.Text = "";
            txb_quoctich.Text = "";
            txb_diachi.Text = "";
            txb_ngaynhanphong.Text = "";
            txb_ngaydi.Text = "";
            txb_loaiphong.Text = "";
            txb_sophong.Text = "";
            txb_songuoi.Text = "";
            //get_MACTHD = item.MACTHD;
        }

        private void bt_giahan_Click(object sender, EventArgs e)
        {
            if(dpr_ngaydi.Value.ToString()=="")
            {
                MessageBox.Show("Chưa chọn ngày đi kìa!", "Thông báo");
                return;
            }
            else
            {
                string ngaydi = dpr_ngaydi.Value.ToString();
                if (bus_cthd.GiaHan(get_MACTHD, ngaydi)!="0")
                {
                    MessageBox.Show("Gia hạn phòng thất bại rồi :(( !", "Thông báo!");
                    return;
                }
                else
                {
                    ClearTools();
                    MessageBox.Show("Gia hạn phòng thành công ^^ !", "Thông báo!");
                    return;
                }
            }
            
        }

        private void txb_makh_Leave(object sender, EventArgs e)
        {
            LoadThongTinKHTuMAKH();
        }

        private void txb_cmnd_Leave(object sender, EventArgs e)
        {
            LoadThongTinTuCMND();
        }
    }
}
