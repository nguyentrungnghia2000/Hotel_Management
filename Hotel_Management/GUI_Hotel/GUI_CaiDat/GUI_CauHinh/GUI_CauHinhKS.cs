using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using DTO_Hotel;
using BUS_Hotel;
namespace Hotel_Management.GUI_CaiDat
{
    public partial class GUI_CauHinhKS : Form
    {
        public GUI_CauHinhKS()
        {
            InitializeComponent();
        }
        BUS_Phong bus = new BUS_Phong();
        
        private GUI_CaiDat.GUI_ListLoaiPhong guiListLP = new GUI_CaiDat.GUI_ListLoaiPhong();
        private GUI_CaiDat.GUI_ListDichVu guiListDV = new GUI_CaiDat.GUI_ListDichVu();
        private GUI_CaiDat.GUI_ListPhong guiListPhong = new GUI_CaiDat.GUI_ListPhong();
        private void GUI_CauHinhKS_Load(object sender, EventArgs e)
        {
            Thread newThread = new Thread(() =>
            {
                Invoke(new Action(() =>
                {

                    panelListLP.Controls.Add(guiListLP);
                    guiListLP.Dock = DockStyle.Top;
                    pnl_listdv.Controls.Add(guiListDV);
                    guiListDV.Dock = DockStyle.Top;
                    panelListPhong.Controls.Add(guiListPhong);
                    guiListPhong.Dock = DockStyle.Top;

                }));
            });
            newThread.Start();
        }
        private void LoadList()
        {
            panelListPhong.Controls.Clear();
            //List<DTO_Phong> roomlist = DAL_Phong.Instance.LoadListRoom();

            //foreach(DTO_Phong item in roomlist)
            //{
            //    Button btn = new Button();
            //    btn.Width = 100;
            //    btn.Height = 100;

            //    flp_phong.Controls.Add(btn); 
            //}

            List<DTO_Phong> lsobj = new List<DTO_Phong>();

            string result = this.bus.SelectAll(lsobj);
            if (result != "0")
            {
                MessageBox.Show("Load list have been fail. \n" + result);
                return;
            }


            foreach (DTO_Phong item in lsobj)
            {

                GUI_ListPhong gui_x1Phong = new GUI_ListPhong();
                gui_x1Phong.txb_sophong.Text = item.Sophong;
              

                this.panelListPhong.Controls.Add(gui_x1Phong);
            }


            //foreach (DTO_Phong item in lsobj)
            //{
            //    SodophongChild sodophongChild = new SodophongChild(item.Sophong, item.Status, item.Malp);
            //    this.flpnlSODOPHONG.Controls.Add(sodophongChild);
            //}

            //dgv_load.Columns.Clear();
            //dgv_load.DataSource = null;

            //dgv_load.AutoGenerateColumns = false;
            //dgv_load.AllowUserToAddRows = false;
            //dgv_load.DataSource = lsobj;

            //DataGridViewTextBoxColumn cSophong = new DataGridViewTextBoxColumn();
            //cSophong.Name = "Sophong";
            //cSophong.HeaderText = "Số phòng";
            //cSophong.DataPropertyName = "Sophong";

            //DataGridViewTextBoxColumn cStatus = new DataGridViewTextBoxColumn();
            //cStatus.Name = "Status";
            //cStatus.HeaderText = "Trạng thái";
            //cStatus.DataPropertyName = "Status";

            //DataGridViewTextBoxColumn cMalp = new DataGridViewTextBoxColumn();
            //cMalp.Name = "Malp";
            //cMalp.HeaderText = "Mã loại phòng";
            //cMalp.DataPropertyName = "Malp";



            //dgv_load.Columns.AddRange(new DataGridViewTextBoxColumn[] { cSophong, cStatus,cMalp });
            //CurrencyManager myCurrenManager = (CurrencyManager)this.BindingContext[dgv_load.DataSource];
            //myCurrenManager.Refresh();
            //dgv_load.Refresh();
        }


        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoaiPhong_Click(object sender, EventArgs e)
        {
            pageCauHinh.SetPage(0);
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            pageCauHinh.SetPage(1);
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            pageCauHinh.SetPage(2);
        }

        private void btnAddLoaiPhong_Click(object sender, EventArgs e)
        {
            GUI_CaiDat.GUI_ListLoaiPhong guiListLP1 = new GUI_CaiDat.GUI_ListLoaiPhong();
            panelListLP.Controls.Add(guiListLP1);
            guiListLP1.Dock = DockStyle.Top;
        }

        private void btnAddPhong_Click(object sender, EventArgs e)
        {
            //GUI_CaiDat.GUI_ListPhong guiListPhong = new GUI_CaiDat.GUI_ListPhong();
            //panelListPhong.Controls.Add(guiListPhong);
            //guiListPhong.Dock = DockStyle.Top;
            LoadList();

        }

        private void btnAddDV_Click(object sender, EventArgs e)
        {
            GUI_CaiDat.GUI_ListDichVu guiListDV = new GUI_CaiDat.GUI_ListDichVu();
            pnl_listdv.Controls.Add(guiListDV);
            guiListDV.Dock = DockStyle.Top;
        }

    }       
    
}
