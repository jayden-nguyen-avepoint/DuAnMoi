using FontAwesome.Sharp;
using QuanNet.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanNet.Properties;

namespace QuanNet
{
    public partial class FormMayTinh : Form
    {
        public delegate void Mydel(string TongTienChoi);
        public Mydel d { get; set; }
        public string time { get; set; }
        public FormMayTinh()
        {
            InitializeComponent();
            txtMay.Enabled = false;
        }
       
        
        public void GUI(string IDMay)
        {
            if ((BllMayTinh.Instance.GetMayByIDMay(IDMay)).IdTK==null)
            {
                txtIDTK.Text = "Trống";
            }
            else txtIDTK.Text = (BllMayTinh.Instance.GetMayByIDMay(IDMay)).IdTK.ToString();
            txtMay.Text =BllMayTinh.Instance.GetMayByIDMay(IDMay).IdMay ;
            txtCauHinh.Text = BllMayTinh.Instance.GetMayByIDMay(IDMay).CauHinh;
            txtCauHinh.Enabled=false;
            txtTien.Text = BllMayTinh.Instance.GetMayByIDMay(IDMay).TienGio.ToString();
            txtTien.Enabled=false;
        }
        private void Button_Click(object sender, EventArgs e)
        {
            string maMay = ((Button)sender).Name;
            txtMay.Text = maMay;
            GUI(maMay);
        }
        public string NgayGioBD()
        {
            string s = Convert.ToString(DateTime.Now);
            return time=s;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtIDTK.Text != "Trống")
            {
                dgvMaytinh.DataSource = BllMayTinh.Instance.GetMtView(txtMay.Text, "", "");
                NgayGioBD();
            }
            else
            {
                MessageBox.Show("Chưa có ai sd máy này","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (txtIDTK.Text != "Trống")
            {
                DateTime aDateTime = DateTime.Now;
                TimeSpan interval = aDateTime.Subtract(Convert.ToDateTime(time));
                int tienGio = BllMayTinh.Instance.GetMayByIDMay(txtMay.Text).TienGio;
                int TongTienChoi = tienGio * interval.Hours + tienGio * interval.Minutes / 60 + tienGio * interval.Seconds / 3600;
                if (TongTienChoi <= 2000)
                {
                    TongTienChoi = 2000;
                }
                else
                {
                    string TT = Convert.ToString(TongTienChoi);
                    if (Convert.ToInt32(TT.Substring(TT.Length - 3, 3)) > 1)
                    {
                        TongTienChoi = (Convert.ToInt32(TT.Substring(0, TT.Length - 3)) + 1) * 1000;
                    }
                    else TongTienChoi.ToString();
                }
                dgvMaytinh.DataSource = BllMayTinh.Instance.GetMtView(txtMay.Text, interval.ToString(), TongTienChoi.ToString());
                foreach (TaiKhoan i in BllKhachHang.Instance.GetListTKByIDTK(txtIDTK.Text))
                {
                    TaiKhoan tk = new TaiKhoan()
                    {
                        IdTK = txtIDTK.Text,
                        LienHe = i.LienHe,
                        TenKH = i.TenKH,
                        TenDN = i.TenDN,
                        MatKhau = i.MatKhau,
                        Sodu = Convert.ToInt32(i.Sodu - TongTienChoi),
                    };
                    BllKhachHang.Instance.Edit(tk);
                }
            }
            else
            {
                MessageBox.Show("Chưa có ai sd máy này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
            //Console.WriteLine("Hours: " + interval.Hours);
            //Console.WriteLine("Minute: " + interval.Minutes);
            //Console.WriteLine("Seconds: " + interval.Seconds); 
