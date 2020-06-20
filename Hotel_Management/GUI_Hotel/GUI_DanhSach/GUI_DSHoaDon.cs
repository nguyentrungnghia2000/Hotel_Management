using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management.GUI_DanhSach
{
    public partial class GUI_DSHoaDon : UserControl
    {
        public GUI_DSHoaDon()
        {
            InitializeComponent();
        }

        private void GUI_DSHoaDon_Load(object sender, EventArgs e)
        {
            GUI_DanhSach.x1HoaDon gui_HD = new GUI_DanhSach.x1HoaDon();
            panel_HoaDon.Controls.Add(gui_HD);
            gui_HD.Dock = DockStyle.Top;
        }
    }
}
