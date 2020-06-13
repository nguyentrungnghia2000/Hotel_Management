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
    public partial class GUI_QuanTri : Form
    {
        public GUI_QuanTri()
        {
            InitializeComponent();
            btnLuu.Visible = false;
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            pageQuanTri.SetPage(0);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnLuu.Visible == true)
            {
                btnLuu.Visible = false;
                btnSua.Visible = true;
            }
            else
            {
                btnSua.Visible = true;
                btnLuu.Visible = false;
            }
        }

        private void SuaClick()
        {
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
            txtSoDT.Enabled = true;
            txtTen.Enabled = true;
            txtWebSite.Enabled = true;
        }
        private void LuuClick()
        {
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            txtSoDT.Enabled = false;
            txtTen.Enabled = false;
            txtWebSite.Enabled = false;
        }
        private void btnSua_Click_1(object sender, EventArgs e)
        {
            
            if (btnSua.Visible == true)
            {
                SuaClick();
                btnSua.Visible = false;
                btnLuu.Visible = true;
            }
            else
            {
                LuuClick();
                btnLuu.Visible = true;
                btnSua.Visible = false;
            }
        }
    }
}
