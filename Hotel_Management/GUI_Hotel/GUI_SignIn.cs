using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Hotel;
using DTO_Hotel;
namespace Hotel_Management
{
    public partial class GUI_SignIn : Form
    {
        BUS_SignIn busSignIn = new BUS_SignIn();
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
            if ((txtUsername.Text != "") && (txtPassword.Text != ""))
            {
                DTO_SignIn account = new DTO_SignIn(txtUsername.Text, txtPassword.Text);
                if ((busSignIn.SignIn(account) == "1"))
                {
                    this.Hide();
                    FrmMain frm = new FrmMain();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Sai Mat Khau, Nhap Lai");
                }
            }
            else
            {
                MessageBox.Show("Sai Mat Khau, Nhap Lai!!!");
            }
        }
    }
}
