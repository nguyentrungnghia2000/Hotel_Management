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
using BUS_Hotel;
using Bunifu.UI.WinForms.BunifuButton;

namespace Hotel_Management.GUI_SoDoPhong
{
    public partial class GUI_SoDoPhong : UserControl
    {
        private BUS_Phong bus;
        public GUI_SoDoPhong()
        {
            InitializeComponent();
        }

        private void GUI_SoDoPhong_Load(object sender, EventArgs e)
        {
            bus = new BUS_Phong();
            LoadList();
        }
        private void bt_Search_Click(object sender, EventArgs e)
        {
            LoadList();
        }
        private void LoadList()
        {
            flpnlSODOPHONG.Controls.Clear();
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
                
                GUI_x1Phong gui_x1Phong = new GUI_x1Phong();
                gui_x1Phong.lb_SoPhong.Text = item.Sophong;
                gui_x1Phong.lb_TrangThai.Text = item.Status;
                
                this.flpnlSODOPHONG.Controls.Add(gui_x1Phong);
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

        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        private void flpnlSODOPHONG_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}
