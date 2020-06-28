using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management.GUI_SoDoPhong
{
    public partial class SodophongChild : UserControl
    {
        public SodophongChild( string SOPHONG, string TINHTRANG, string MALP )
        {
            InitializeComponent();
            lb_sophong.Text = SOPHONG;
            lb_status.Text = TINHTRANG;
            lb_malp.Text = MALP;
            this.btnsdp.Click += Btnsdp_Click;
        }

        private void Btnsdp_Click(object sender, EventArgs e)
        {

        }
    }
}
