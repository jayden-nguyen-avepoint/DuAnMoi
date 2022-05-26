using QuanNet.BLL;
using QuanNet.LinQ;
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
        public string ID_CT { get; set; }
        public FormOrderKH(string M,string K, string O)
        {
            ID_May = M;
            ID_KhachHang = K;
            ID_CT = O;
            MessageBox.Show(ID_CT);
            InitializeComponent();

            ShowListHD(ID_CT);
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
        public string MaListDoAn()
        {
            List<int> l = new List<int>();
            foreach (ListTPham tk in BllOrderKH.Instance.GetListTPByIDCT(""))
            {
                l.Add(Convert.ToInt32(tk.IdOrderList.Remove(0, 5)));
            }
            for (int i = 0; i < l.Count; i++)
            {
                if (!l.Contains(i + 1)) return i + 1 < 10 ? "Order00" + ++i : i + 1 < 100 ? "Order0" + ++i : "Order" + ++i;
            }
            return l.Count + 1 < 10 ? "Order00" + (l.Count + 1) : l.Count + 1 < 100 ? "Order0" + (l.Count + 1) : "Order" + (l.Count + 1);

        }
        //public string MaOrderCT()
        //{
        //    List<int> Ma = new List<int>();
        //     foreach (HoaDonChiTiet tk in BllHoaDon.Instance.GetsomethingInView(ID_KhachHang,ID_May))
        //    {
        //        Ma.Add(Convert.ToInt32(tk.IdChiTiet.Remove(0, 7)));
        //        ID_CT=tk.IdChiTiet.Substring(0,7);
        //    }
        //    for (int i = 0; i < Ma.Count; i++)
        //    {
        //        if (!Ma.Contains(i + 1)) return i + 1 < 10 ? ID_CT + ++i : i + 1 < 100 ? ID_CT + ++i : ID_CT + ++i;
        //    }
        //    return Ma.Count + 1 < 10 ? ID_CT + (Ma.Count + 1) : Ma.Count + 1 < 100 ? ID_CT + (Ma.Count + 1) : ID_CT + (Ma.Count + 1);

        //}
        private void btnThem_Click(object sender, EventArgs e)
        {
            //string IdCT = BllHoaDon.Instance.CreateIDCT(ID_KhachHang, ID_May);
            ListTPham orderkh = new ListTPham()
            {
                IdOrderList = MaListDoAn(),
                IdTP = BllOrderKH.Instance.GetIDTP(txtMon.Text),
                SoluongTP = Convert.ToInt32(txtSL.Text),
                ThanhTien = Convert.ToInt32(txtSL.Text) * Convert.ToInt32(txtGia.Text),
                IdChiTiet = ID_CT
            };
            BllOrderKH.Instance.addOrder1(orderkh);
            MessageBox.Show("Thành công !");
            txtMon.Text = "";
            txtSL.Text = "";
            txtGia.Text = "";
            ShowListHD(ID_CT);
        }
        public void ShowListHD(string Id)
        {

            dgvList.DataSource = BllOrderKH.Instance.GetListTPViewByIDCT(Id);
        }
    }
}
