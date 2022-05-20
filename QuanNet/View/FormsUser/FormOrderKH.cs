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
        public string IDTP = "TP01";
        public FormOrderKH(string ID_May, string IDKhachHang)
        {
            InitializeComponent();
        }
        public void GUI(string ID)
        {
            txtMon.Text = BllMon.Instance.GetTphamByID(ID).TenTP;
            txtGia.Text = BllMon.Instance.GetTphamByID(ID).Gia.ToString();
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
        //private void Laygiasp(object sender, EventArgs e)
        //{
        //    txtGia.Text = BllOrderKH.Instance.ThanhTien(txtMon.Text, Convert.ToInt32(txtSL.Text)).ToString();
        //}

        //private void Gia(object sender, EventArgs e)
        //{
        //    txtGia.Text = BllOrderKH.Instance.TraVeGia(txtMon.Text).ToString();
        //}
        private void btnThem_Click(object sender, EventArgs e)
        {
            
                ListTPham orderkh = new ListTPham()
                {
                    IdOrderList = "Order" + Convert.ToString(BllOrderKH.Instance.LastId() + 1),
                    IdTP = BllOrderKH.Instance.GetIDTP(txtMon.Text),
                    SoluongTP = Convert.ToInt32(txtSL.Text),
                    ThanhTien = Convert.ToInt32(txtSL.Text )* Convert.ToInt32(txtGia.Text),
                    IdChiTiet = "CT01",
                };
                BllOrderKH.Instance.addOrder1(orderkh);
                MessageBox.Show("Thành công !");
                txtMon.Text = "";
                txtSL.Text = "";
                txtGia.Text = "";
                ShowListHD();
        }
        public void ShowListHD()
        {
           
            dgvList.DataSource = BllOrderKH.Instance.GetListTPViewByID("","");
        }


    }
}
