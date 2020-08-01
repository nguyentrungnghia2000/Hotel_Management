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

namespace Hotel_Management.GUI_CaiDat
{
    public partial class GUI_ListDichVu : UserControl
    {
        public GUI_ListDichVu()
        {
            InitializeComponent();
            ShowPanel();
        }

        BUS_DichVu bus_dv = new BUS_DichVu();

        private void ShowPanel()
        {
            this.Size = new Size(910, 189);
            if (panelSubMenu.Visible == true)
            {
                panelSubMenu.Visible = false;
                this.Size = new Size(910, 45);

            }
            else
            {
                panelSubMenu.Visible = true;
                this.Size = new Size(910, 189);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowPanel();
        }

        private void GUI_ListDichVu_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            btn_luu.Visible = true;
            txb_GiaDV.ReadOnly = true;
            txb_TenDV.ReadOnly = true;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string text = btn_luu.Text;
            if (text == "Lưu")
            {
                DTO_DichVu dv = new DTO_DichVu();
                dv.Madv = txb_MaDV.Text;
                dv.Giadv = txb_GiaDV.Text;
                dv.Tendv = txb_TenDV.Text;

                if (txb_GiaDV.Text == "")
                {
                    MessageBox.Show("Chưa nhập số phòng", "Erro");
                    return;
                }
                if (txb_TenDV.Text == "")
                {
                    MessageBox.Show("Chưa chọn loại phòng", "Erro");
                    return;
                }

                if (bus_dv.Update(dv) != "0")
                {
                    MessageBox.Show("Cập nhật dịch vụ thất bại!", "Error");
                    return;
                }
                else
                {
                    btn_luu.Visible = false;
                    txb_GiaDV.ReadOnly = false;
                    txb_TenDV.ReadOnly = false;
                    MessageBox.Show("Cập nhật dịch vụ thành công!", "Error");
                    return;
                }
            }
            else if (text == "Thêm")
            {
                DTO_DichVu dv = new DTO_DichVu();
                dv.Madv = txb_MaDV.Text;
                dv.Giadv = txb_GiaDV.Text;
                dv.Tendv = txb_TenDV.Text;

                if (txb_GiaDV.Text == "")
                {
                    MessageBox.Show("Chưa nhập số phòng", "Erro");
                    return;
                }
                if (txb_TenDV.Text == "")
                {
                    MessageBox.Show("Chưa chọn loại phòng", "Erro");
                    return;
                }
                if (bus_dv.Insert(dv) != "0")
                {
                    MessageBox.Show("Cập nhật dịch vụ thất bại!", "Error");
                    return;
                }
                else
                {
                    btn_luu.Text = "Lưu";
                    btn_luu.Visible = false;
                    txb_GiaDV.ReadOnly = false;
                    txb_TenDV.ReadOnly = false;
                    MessageBox.Show("Cập nhật dịch vụ thành công!", "Error");
                    return;
                }
                
            }
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa dịch vụ đã chọn?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DTO_DichVu dv = new DTO_DichVu();
                dv.Madv = txb_MaDV.Text;
                dv.Giadv = txb_GiaDV.Text;
                dv.Tendv = txb_TenDV.Text;

                if (bus_dv.Delete(dv) != "0")
                {
                    MessageBox.Show("Xóa dịch vụ thất bại!", "Error");
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa dịch vụ thành công!", "Error");
                    return;
                }
            }
        }

        private void txb_TenDV_Leave(object sender, EventArgs e)
        {
            txb_MaDV.Text = bus_dv.TaoMa();
        }
    }
}
