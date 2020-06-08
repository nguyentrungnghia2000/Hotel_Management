using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management.GUI_CaiDat
{
    public partial class GUI_TaiKhoan : Form
    {
        public GUI_TaiKhoan()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            if (btnHuy.Visible == false)
            {
                btnHuy.Visible = true;
                btnLuu.Visible = true;
             
            }
            else
            {
                btnHuy.Visible = false;
                btnLuu.Visible = false;
             
            }
        }
        
    }
}
