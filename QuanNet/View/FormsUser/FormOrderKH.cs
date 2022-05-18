using QuanNet.BLL;
using QuanNet.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanNet.FormsUser
{
    public partial class FormOrderKH : Form
    {
        public string ID_May { get; set; }
        public FormOrderKH(string ID_May,string IDKhachHang)
        {
            InitializeComponent();
        }
        public void GUI(string ID)
        {
            txtMon.Text= BllMon.Instance.GetTphamByID(ID).TenTP;
            txtGia.Text= BllMon.Instance.GetTphamByID(ID).Gia.ToString();
        }
        private void Chon_Click(object sender, EventArgs e)
        {
            string ID = ((Button)sender).Name;
            GUI(ID);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMon.Text = "";
            txtSL.Text = "";
            txtGia.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //listView1.Items.Add(new ListViewItem {
            //});
        }
    }
}
