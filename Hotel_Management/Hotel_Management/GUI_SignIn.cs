using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class GUI_SignIn : Form
    {
        public GUI_SignIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            PageSignIn.SetPage(0);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            PageSignIn.SetPage(1);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frm = new FrmMain();
            frm.Show();
        }
    }
}
