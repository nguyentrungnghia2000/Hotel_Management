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
    public partial class GUI_DSDonDatPhong : UserControl
    {
        public GUI_DSDonDatPhong()
        {
            InitializeComponent();
        }

        private void GUI_DSDonDatPhong_Load(object sender, EventArgs e)
        {
            GUI_DanhSach.x1DonDatPhong gui_x1Don = new GUI_DanhSach.x1DonDatPhong();
            panel_DonDatPhong.Controls.Add(gui_x1Don);
            gui_x1Don.Dock = DockStyle.Top;
        }
    }
}
