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
namespace Hotel_Management.GUI_CaiDat
{
    public partial class GUI_QuanTri : Form
    {
        public GUI_QuanTri()
        {
            InitializeComponent();
        }

        private GUI_CaiDat.GUI_ListQuyen gui_ListQuyen = new GUI_ListQuyen();
        private GUI_CaiDat.GUI_ListNhanSu gui_ListNS = new GUI_ListNhanSu();
        private void GUI_QuanTri_Load(object sender, EventArgs e)
        {
            Thread newThread = new Thread(() =>
            {
                Invoke(new Action(() =>
               {
                   panel_ListQuyen.Controls.Add(gui_ListQuyen);
                   gui_ListQuyen.Dock = DockStyle.Top;
                   panel_ListNS.Controls.Add(gui_ListNS);
                   gui_ListNS.Dock = DockStyle.Top;
                   
               }));
                 
            });
            newThread.Start();
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            pageQuanTri.SetPage(1);
        }

        private void btn_ThemQuyen_Click(object sender, EventArgs e)
        {
            GUI_CaiDat.GUI_ListQuyen guiListQuyen = new GUI_CaiDat.GUI_ListQuyen();
            panel_ListQuyen.Controls.Add(guiListQuyen);
            guiListQuyen.Dock = DockStyle.Top;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_NhanSu_Click(object sender, EventArgs e)
        {
            pageQuanTri.SetPage(2);
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            GUI_CaiDat.GUI_ListNhanSu guiListNS = new GUI_CaiDat.GUI_ListNhanSu();
            panel_ListNS.Controls.Add(guiListNS);
            guiListNS.Dock = DockStyle.Top;
        }

        private void bt_ThongTin_Click(object sender, EventArgs e)
        {
            pageQuanTri.SetPage(0);
        }
    }
}
