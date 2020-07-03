using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using DTO_Hotel;
using BUS_Hotel;
//using DAL_Hotel;

namespace Hotel_Management.GUI_CaiDat
{
    public partial class GUI_CauHinhKS : Form
    {
        public GUI_CauHinhKS()
        {
            InitializeComponent();
        }

        private BUS_Phong bus = new BUS_Phong();
        private BUS_LoaiPhong bus_lp = new BUS_LoaiPhong();

        private void GUI_CauHinhKS_Load(object sender, EventArgs e)
        { 
        }

        private void LoadListPhong()
        {
            List<DTO_Phong> lsobj = new List<DTO_Phong>();
            string result = this.bus.SelectWithCost(lsobj);
            if (result != "0")
            {
                MessageBox.Show("Load list have been fail. \n" + result);
                return;
            }
            foreach (DTO_Phong item in lsobj)
            {
                GUI_ListPhong phong = new GUI_ListPhong();
                phong.txb_sophong.Text = item.Sophong;
                phong.txb_loaiphong.Text = item.Malp;
                phong.txb_tinhtrang.Text = item.Status;
                phong.txb_giaphong.Text = item.Gia;
                phong.lb_ten.Text = item.Sophong;
                phong.lb_status.Text = item.Status;
                this.flp_lsphong.Controls.Add(phong);
                phong.Dock = DockStyle.Top;
            }
        }

        private void LoadListLoaiPhong()
        {
            List<DTO_LoaiPhong> lsobj_lp = new List<DTO_LoaiPhong>();
            string result = this.bus_lp.SelectAll(lsobj_lp);
            if (result != "0")
            {
                MessageBox.Show("Load list have been fail. \n" + result);
                return;
            }
            foreach (DTO_LoaiPhong item in lsobj_lp)
            {
                GUI_ListLoaiPhong loaiphong = new GUI_ListLoaiPhong();
                loaiphong.txb_tenloaiphong.Text = item.Tenlp;
                loaiphong.txb_malp.Text = item.Malp;
                loaiphong.txb_giaphong.Text = item.Gia;
                loaiphong.txb_trangthietbi.Text = item.Trangthietbi;
                loaiphong.txb_donvi.Text = item.Donvi;
                loaiphong.lb_ten.Text = item.Tenlp;
                loaiphong.lb_gia.Text = item.Gia.ToString();
                this.flp_lsphong.Controls.Add(loaiphong);
                loaiphong.Dock = DockStyle.Top;
            }
        }
        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoaiPhong_Click(object sender, EventArgs e)
        {
            pageCauHinh.SetPage(0);
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            pageCauHinh.SetPage(1);
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            pageCauHinh.SetPage(2);
        }

        private void btnAddLoaiPhong_Click(object sender, EventArgs e)
        {
            GUI_CaiDat.GUI_ListLoaiPhong guiListLP1 = new GUI_CaiDat.GUI_ListLoaiPhong();
            panelListLP.Controls.Add(guiListLP1);
            guiListLP1.Dock = DockStyle.Top;
        }

        private void btnAddPhong_Click(object sender, EventArgs e)
        {
            GUI_CaiDat.GUI_ListPhong guiListPhong = new GUI_CaiDat.GUI_ListPhong();
            flp_lsphong.Controls.Add(guiListPhong);
            guiListPhong.Dock = DockStyle.Top;
        }

        private void btnAddDV_Click(object sender, EventArgs e)
        {
            GUI_CaiDat.GUI_ListDichVu guiListDV = new GUI_CaiDat.GUI_ListDichVu();
            pnl_listdv.Controls.Add(guiListDV);
            guiListDV.Dock = DockStyle.Top;
        }

        private void btn_LoadListPhong_Click(object sender, EventArgs e)
        {
           // LoadListPhong();
        }

        private void btn_LoadListPhong_Click_1(object sender, EventArgs e)
        {
            LoadListPhong();
        }

        private void btn_LoadListLP_Click(object sender, EventArgs e)
        {
            LoadListLoaiPhong();
        }
    }       
    
}
