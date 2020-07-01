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
using DAL_Hotel;
using BUS_Hotel;
using System.Net.NetworkInformation;
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

        private void LoadList()
        {
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
            if(result != "0")
            {
                MessageBox.Show("Load list have been fail. \n" + result);
                return;
            }

            foreach (DTO_Phong item in lsobj)
            {
                
                BunifuButton btn_phong = new BunifuButton();
                btn_phong.BackColor = Color.Green;
                btn_phong.Width = 200;
                btn_phong.Height = 200;
                btn_phong.TextAlign = ContentAlignment.MiddleCenter;
                btn_phong.Text = item.Sophong +"\n"+ item.Status;
                this.flpnlSODOPHONG.Controls.Add(btn_phong);
            }

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

        private void GUI_SoDoPhong_Load(object sender, EventArgs e)
        {
            bus = new BUS_Phong();
        }
    }
}
