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
    public partial class x1HoaDon : UserControl
    {
        public x1HoaDon()
        {
            InitializeComponent();
        }
        BUS_HoaDon bus_hd = new BUS_HoaDon();

        private void bt_DatCoc_Click(object sender, EventArgs e)
        {

        }

        private void bt_ThanhToan_Click(object sender, EventArgs e)
        {
            string mahd = lb_hoadon.Text;
            string sophong = lb_sophong.Text;
            string result = bus_hd.ThanhToan(mahd, sophong);
            if (MessageBox.Show("Bạn có muốn thanh toán \nPhòng : " + lb_sophong.Text + "\n Giá : " + lb_chiphi.Text, "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (result != "0")
                {
                    MessageBox.Show("Thanh toán không thành công!");
                    return;
                }
                else
                {
                    MessageBox.Show("Thanh toán thành công!");
                    this.Hide();
                    return;
                }
            }

            
        }
    }
}
