using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Hotel;
using Bunifu.UI.WinForms.BunifuButton;
using BUS_Hotel;
namespace Hotel_Management.GUI_CaiDat
{
    public partial class GUI_ListPhong : UserControl
    {
        public GUI_ListPhong()
        {
            InitializeComponent();
            ShowPanel();
        }
        BUS_Phong busp = new BUS_Phong();
        BUS_LoaiPhong bus_lp = new BUS_LoaiPhong();
        


        private void GUI_ListPhong_Load(object sender, EventArgs e)
        {
            LoadLoaiPhong();
        }

        private void LoadLoaiPhong()
        {
            List<DTO_LoaiPhong> lsobj_lp = new List<DTO_LoaiPhong>();
            string result = this.bus_lp.SelectAll(lsobj_lp);
            if (result != "0")
            {
                MessageBox.Show("Load list have been fail. \n" + result);
                return;
            }

            foreach (DTO_LoaiPhong item in lsobj_lp)
            {
                combobox_lp.Items.Add(item.Tenlp);
            }
           
          
        }
        //public void ReadOnlyTb()
        //{
        //    if (txb_sophong.ReadOnly == true)
        //    {
        //        txb_giaphong.ReadOnly = true;
        //        combobox_lp.Enabled = true;
        //        txb_sophong.ReadOnly = false ;
        //        txb_tinhtrang.ReadOnly = false;
        //    }
        //    else
        //    {
        //        txb_giaphong.ReadOnly = true;
        //        combobox_lp.Enabled = false;
        //        txb_sophong.ReadOnly = true;
        //        txb_tinhtrang.ReadOnly = true;
        //    }
        //}
        public void ShowPanel()
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

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            bt_Luu.Visible = true;
            txb_giaphong.ReadOnly = false;
            combobox_lp.Enabled = true;
            //kt = 1;

        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (bt_Luu.Text == "Lưu")
            {
                DTO_Phong objp = new DTO_Phong();
                List<DTO_LoaiPhong> lsobj_lp = new List<DTO_LoaiPhong>();
                string result = bus_lp.SelectAll(lsobj_lp);


                var Malp = from x in lsobj_lp
                           where (x.Tenlp == combobox_lp.Text)
                           select new
                           {
                               malp = x.Malp
                           };
                objp.Sophong = this.txb_sophong.Text;
                objp.Status = this.txb_tinhtrang.Text;
                foreach (var item in Malp)
                {
                    objp.Malp = item.malp;
                }
                lb_ten.Text = txb_sophong.Text;
                lb_status.Text = txb_tinhtrang.Text;

                if (busp.Update(objp) != "0")
                {
                    MessageBox.Show("Cập nhật phòng thất bại", "Lỗi sửa phòng");
                    return;
                }
                else
                {
                    bt_Luu.Visible = false;
                    txb_giaphong.ReadOnly = true;
                    MessageBox.Show("Cập nhật phòng thành công", "Lỗi sửa phòng");
                    return;
                }

                
            }
            else if (bt_Luu.Text == "Thêm")
            {
                DTO_Phong objp = new DTO_Phong();
                List<DTO_LoaiPhong> lsobj_lp = new List<DTO_LoaiPhong>();
                string result = bus_lp.SelectAll(lsobj_lp);


                var Malp = from x in lsobj_lp
                           where (x.Tenlp == combobox_lp.Text)
                           select new
                           {
                               malp = x.Malp
                           };
                objp.Sophong = this.txb_sophong.Text;
                objp.Status = this.txb_tinhtrang.Text;
                foreach (var item in Malp)
                {
                    objp.Malp = item.malp;
                }
                lb_ten.Text = txb_sophong.Text;
                lb_status.Text = txb_tinhtrang.Text;

                if (busp.Insert(objp) != "0")
                {
                    MessageBox.Show("Thêm phòng thất bại", "Lỗi sửa phòng");
                    return;
                }
                else
                {
                    bt_Luu.Text = "Lưu";
                    bt_Luu.Visible = false;
                    txb_giaphong.ReadOnly = true;
                    MessageBox.Show("Thêm phòng thành công", "Lỗi sửa phòng");
                    return;
                }

                
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            DTO_Phong objp = new DTO_Phong();
            objp.Sophong = txb_sophong.Text;
            
            if (busp.Delete(objp) != "0")
            {
                MessageBox.Show("Vẫn còn phòng thuộc loại phòng này", "Lỗi xóa phòng");
                return;
            }
            this.Hide();
        }

        private void txb_giaphong_Leave(object sender, EventArgs e)
        {
            txb_sophong.Text = busp.TaoMa();
        }
    }
}
