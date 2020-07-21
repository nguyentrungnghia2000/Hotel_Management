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
    public partial class GUI_ListLoaiPhong : UserControl
    {
        public GUI_ListLoaiPhong()
        {
            InitializeComponent();
        }
        private void ShowPanel()
        {
            this.Size = new Size(910, 219);
            if (panelSubMenu.Visible == true)
            {
                panelSubMenu.Visible = false;
                this.Size = new Size(910, 45); 
            }
            else
            {
                panelSubMenu.Visible = true;
                this.Size = new Size(910, 219);
            }
        }

        private BUS_LoaiPhong bus = new BUS_LoaiPhong();

        void LoadLPbyMaLP(string malp)
        {
            List<DTO_LoaiPhong> loaiPhong = new List<DTO_LoaiPhong>();
            string result = this.bus.SelectByID(loaiPhong, malp);
            if (result != "0")
            {
                MessageBox.Show("Load list have been fail. \n" + result);
                return;
            }
            foreach (DTO_LoaiPhong item in loaiPhong)
            {
                GUI_ListLoaiPhong phong = new GUI_ListLoaiPhong();
                item.Tenlp = txb_tenloaiphong.Text;
                item.Gia = txb_giaphong.Text;
                item.Trangthietbi = txb_trangthietbi.Text;
                item.Donvi = txb_donvi.Text;
                lb_ten.Text = item.Tenlp;
                lb_gia.Text = item.Gia;
            }
        }

        void LuuLoaiPhong()
        {
            DTO_LoaiPhong loaiphong = new DTO_LoaiPhong();
            string result = this.bus.Update(loaiphong);
            if (result == "0")
            {
                MessageBox.Show("Load list have been fail. \n" + result);
                return;
            }

            loaiphong.Tenlp = txb_tenloaiphong.Text;
            loaiphong.Trangthietbi = txb_trangthietbi.Text;
            loaiphong.Gia = txb_giaphong.Text;
            loaiphong.Donvi = txb_donvi.Text;

            LoadLPbyMaLP(txb_malp.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowPanel();  
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            LuuLoaiPhong();
            btn_luu.Visible = false;
            txb_tenloaiphong.ReadOnly = true;
            txb_trangthietbi.ReadOnly = true;
            txb_donvi.ReadOnly = true;
            txb_giaphong.ReadOnly = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            btn_luu.Visible = true;
            txb_tenloaiphong.ReadOnly = false;
            txb_trangthietbi.ReadOnly = false;
            txb_donvi.ReadOnly = false;
            txb_giaphong.ReadOnly = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }
    }
}
