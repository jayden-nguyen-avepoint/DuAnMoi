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
        public string ID_KhachHang { get; set; }
        public FormOrderKH(string M,string K)
        {
            ID_May = M;
            ID_KhachHang = K;
            InitializeComponent();
            ShowListHD(M);
        }
        public FormOrderKH()
        {
            
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
        public string MaOrdertutang()
        {
            string ma = "";
            List<int> l = new List<int>();
            foreach (ListTPham tk in BllOrderKH.Instance.GetListTPByIDTP(""))
            {
                l.Add(Convert.ToInt32(tk.IdOrderList.Remove(0, 5)));
            }
            for (int i = 0; i < l.Count; i++)
            {
                if (!l.Contains(i + 1)) return i + 1 < 10 ? "Order00" + ++i : i + 1 < 100 ? "Order0" + ++i : "Order" + ++i;
            }
            return l.Count + 1 < 10 ? "Order00" + (l.Count + 1) : l.Count + 1 < 100 ? "Order0" + (l.Count + 1) : "Order" + (l.Count + 1);

        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            ListTPham orderkh = new ListTPham()
            {
                IdOrderList = MaOrdertutang(),
                IdTP = BllOrderKH.Instance.GetIDTP(txtMon.Text),
                SoluongTP = Convert.ToInt32(txtSL.Text),
                ThanhTien = Convert.ToInt32(txtSL.Text) * Convert.ToInt32(txtGia.Text),
                IdChiTiet = BllOrderKH.Instance.Get(ID_May)
            };
            BllOrderKH.Instance.addOrder1(orderkh);
            MessageBox.Show("Thành công !");
            txtMon.Text = "";
            txtSL.Text = "";
            txtGia.Text = "";
            ShowListHD(BllOrderKH.Instance.Get(ID_May));
        }
        public void ShowListHD(string Id)
        {

            dgvList.DataSource = BllOrderKH.Instance.GetListTPViewByIDCT(BllOrderKH.Instance.Get(Id));
        }
    }
}
