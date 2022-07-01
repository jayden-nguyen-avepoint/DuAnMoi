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
        public string ID_CT { get; set; }
        public int Tien { get; set; }
        public FormOrderKH(string M,string K, string O)
        {
            ID_May = M;
            ID_KhachHang = K;
            ID_CT = O;
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
        public void SetNull()
        {
            txtMon.Text = "";
            numCount.Value=0;
            txtGia.Text = "";
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetNull();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListTPham orderkh = new ListTPham()
            {
                IdOrderList = BllOrderKH.Instance.MaListDoAn(),
                IdTP = BllOrderKH.Instance.GetIDTP(txtMon.Text),
                SoluongTP = (int)numCount.Value,
                ThanhTien = Convert.ToInt32(numCount.Value) * Convert.ToInt32(txtGia.Text),
                IdChiTiet = ID_CT
            };
            int tien = (int)numCount.Value * Convert.ToInt32(txtGia.Text);

            if (BllOrderKH.Instance.TinhTienOrder(ID_CT)+tien >= BllKhachHang.Instance.GetTKByIDTK(ID_KhachHang).Sodu) 
            {
                MessageBox.Show("Hết tiền rồi", "Thông báo", MessageBoxButtons.OK);
                SetNull();
            }
            else if((int)numCount.Value==0)
            {
                MessageBox.Show("Vui lòng chọn số lượng", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                BllOrderKH.Instance.addOrder1(orderkh);
                BllHoaDon.Instance.updatetongtien(ID_CT);
                SetNull();
            } 
                
            ShowListHD(ID_CT);
        }
        public void ShowListHD(string Id)
        {

            dgvList.DataSource = BllOrderKH.Instance.GetListTPViewByIDCT(Id);
            
        }

      
    }
}
