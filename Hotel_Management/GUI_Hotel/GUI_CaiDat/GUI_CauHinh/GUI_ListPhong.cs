using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management.GUI_CaiDat
{
    public partial class GUI_ListPhong : UserControl
    {
        public GUI_ListPhong()
        {
            InitializeComponent();
        }
        private void ShowPanel()
        {
            
            if (panelSubMenu.Visible == true)
            {
                panelSubMenu.Visible = false;
                this.Size = new Size(910, 45);

            }
            else
            {
                panelSubMenu.Visible = true;
                this.Size = new Size(910, 219);
            }


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowPanel();
        }
    }
}
