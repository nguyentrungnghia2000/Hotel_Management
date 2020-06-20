using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management.GUI_NghiepVuPhong
{
    public partial class GUI_DatPhong : UserControl
    {
        public GUI_DatPhong()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bt_ToDichVu_Click(object sender, EventArgs e)
        {
            page_DatPhong.SetPage(1);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void bt_Tiep2_Click(object sender, EventArgs e)
        {
            page_DatPhong.SetPage(2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            page_DatPhong.SetPage(1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            page_DatPhong.SetPage(0);
        }

        
    }
}
