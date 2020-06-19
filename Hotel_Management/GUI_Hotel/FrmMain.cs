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

namespace Hotel_Management
{
    public partial class FrmMain : Form
    {

        private
        GUI_NghiepVuPhong.GUI_DatPhong gui_DP = new GUI_NghiepVuPhong.GUI_DatPhong();
        GUI_NghiepVuPhong.GUI_ChuyenPhong gui_CP = new GUI_NghiepVuPhong.GUI_ChuyenPhong();
        GUI_NghiepVuPhong.GUI_GiaHanPhong gui_GHP = new GUI_NghiepVuPhong.GUI_GiaHanPhong();
        GUI_NghiepVuPhong.GUI_HuyPhong gui_HP = new GUI_NghiepVuPhong.GUI_HuyPhong();
        GUI_DanhSach.GUI_DSDonDatPhong gui_DDP = new GUI_DanhSach.GUI_DSDonDatPhong();
        GUI_DanhSach.GUI_DSHoaDon gui_HD = new GUI_DanhSach.GUI_DSHoaDon();
        GUI_ThongTinChung.GUI_ThongTinChung gui_TTC = new GUI_ThongTinChung.GUI_ThongTinChung();
        GUI_SoDoPhong.GUI_SoDoPhong gui_SDP = new GUI_SoDoPhong.GUI_SoDoPhong();
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            HidePanel();
            Thread newThread = new Thread(() =>
            {
                Invoke(new Action(() =>
                {
                    panelChinh.Controls.Add(gui_TTC);
                    panelChinh.Controls.Add(gui_SDP);
                    panelChinh.Controls.Add(gui_DP);
                    panelChinh.Controls.Add(gui_CP);
                    panelChinh.Controls.Add(gui_GHP);
                    panelChinh.Controls.Add(gui_HP);
                    panelChinh.Controls.Add(gui_HD);
                    panelChinh.Controls.Add(gui_DDP);
                   
                }));
            });
            newThread.Start();
        }
        
        private void HidePanel()
        {
            panelSubMenuNVP.Visible = false;
            panelSubMenuDS.Visible = false;
            panelSubMenuBC.Visible = false;
            panelCaiDat.Visible = false;
        }

        private void ShowPanel(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HidePanel();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
          
        }
        private void btnThongTinChung_Click(object sender, EventArgs e)
        {
            gui_TTC.BringToFront();
            SidePanel.Height = bt_ThongTinChung.Height;
            SidePanel.Top = bt_ThongTinChung.Top;
        }

        private void bt_SoDoPhong_Click(object sender, EventArgs e)
        {
            gui_SDP.BringToFront();
            SidePanel.Height = bt_SoDoPhong.Height;
            SidePanel.Top = bt_SoDoPhong.Top;
        }
        private void btnNghiepVu_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnNghiepVu.Height;
            SidePanel.Top = btnNghiepVu.Top;
            ShowPanel(panelSubMenuNVP);
            
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            gui_DP.BringToFront();
            gui_DP.Dock = DockStyle.Fill;
        }

        private void btnChuyenPhong_Click(object sender, EventArgs e)
        {
            gui_CP.BringToFront();
        }

        private void btnGiaHanPhong_Click(object sender, EventArgs e)
        {
            gui_GHP.BringToFront();
        }

        private void btnHuyPhong_Click(object sender, EventArgs e)
        {
            gui_HP.BringToFront();
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnDanhSach.Height;
            SidePanel.Top = btnDanhSach.Top;
            ShowPanel(panelSubMenuDS);
        }

        private void btnDonDatPhong_Click(object sender, EventArgs e)
        {
            gui_DDP.BringToFront();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
           gui_HD.BringToFront();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnBaoCao.Height;
            SidePanel.Top = btnBaoCao.Top;
            ShowPanel(panelSubMenuBC);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnThongKe.Height;
            SidePanel.Top = btnThongKe.Top;
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            ShowPanel(panelCaiDat);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    

        private void btnTaiKhoan_Click_1(object sender, EventArgs e)
        {
            HidePanel();
            GUI_CaiDat.GUI_TaiKhoan gui_tk = new GUI_CaiDat.GUI_TaiKhoan();
            gui_tk.ShowDialog();
        }

        private void btnCauHinh_Click(object sender, EventArgs e)
        {
            HidePanel();
            GUI_CaiDat.GUI_CauHinhKS gui_chks = new GUI_CaiDat.GUI_CauHinhKS();
            gui_chks.ShowDialog();
        }

        private void btnQuanTri_Click(object sender, EventArgs e)
        {
            HidePanel();
            GUI_CaiDat.GUI_QuanTri gui_qt = new GUI_CaiDat.GUI_QuanTri();
            gui_qt.ShowDialog();
            
        }
    }
}
