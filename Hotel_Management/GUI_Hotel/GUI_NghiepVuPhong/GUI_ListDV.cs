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
namespace Hotel_Management.GUI_NghiepVuPhong
{
    public partial class GUI_ListDV : UserControl
    {
        BUS_CTDV bus_ctdv = new BUS_CTDV();
        BUS_DichVu bus_dv = new BUS_DichVu();
        public GUI_ListDV()
        {
            InitializeComponent();
        }
        private string _message;

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DTO_DichVu dv = new DTO_DichVu();
            dv.Madv = lb_MaDV.Text;
            dv.Tendv = lb_TenDV.Text;
            dv.Giadv = lb_GiaDV.Text;
            if (MessageBox.Show("Bạn muốn xóa dịch vụ này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                if (bus_dv.Delete(dv) != "0")
                {
                    MessageBox.Show("Xóa thất bại");
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa dịch vụ thành công");
                    return;
                }
            }
        }
    }
}
