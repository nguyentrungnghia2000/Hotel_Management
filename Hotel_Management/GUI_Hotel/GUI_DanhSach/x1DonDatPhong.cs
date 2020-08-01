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

namespace Hotel_Management.GUI_DanhSach
{
    public partial class x1DonDatPhong : UserControl
    {
        public x1DonDatPhong()
        {
            InitializeComponent();
        }

        BUS_CTHD bus_cthd = new BUS_CTHD();

        private void btn_nhanphong_Click(object sender, EventArgs e)
        {
            string maddp = lb_maddp.Text;
            string result = bus_cthd.UpdateNhanPhong(maddp);
            if(result != "0")
            {
                MessageBox.Show("Nhận đơn thất bại!");
                return;
            }
            this.Hide();
            MessageBox.Show("Nhận đơn thành công!");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maddp = lb_maddp.Text;
            bus_cthd.DeleteDonPhong(maddp);
            this.Hide();
        }
    }
}
