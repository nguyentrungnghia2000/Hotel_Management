﻿using System;
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
    public partial class GUI_ListLoaiPhong : UserControl
    {
        public GUI_ListLoaiPhong()
        {
            InitializeComponent();
        }
        private void ShowPanel()
        {
            this.Size = new Size(910, 219);
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