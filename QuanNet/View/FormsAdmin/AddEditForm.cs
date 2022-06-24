using QuanNet.BLL;
using QuanNet.LinQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace QuanNet.View.FormsAdmin
{
    public partial class AddEditForm : Form
    {
        public delegate void MyDel(string id, string name);
        public  MyDel d { get; set; }
        public string IDKH { get; set; }
        public string MK { get; set; }
        public AddEditForm(string ID)
        {
            InitializeComponent();
            IDKH = ID;
            txtIDTK.Text = MaKHtutang();
            txtIDTK.Enabled = false;
            txtTK.Enabled = false;

            if (ID != "")
            {
                GUI(ID);
                MK = BllKhachHang.Instance.GetTKByIDTK(ID).MatKhau;
            }
            else
            {
                lbEr.Visible = false;
                txtNap.Enabled = false;
            }
        }
        public void GUI(string id)
        {
            txtMK.PasswordChar = false;
            lbNMK.Visible = false;
            txtNMK.Visible = false;
            lbEr.Visible = false;
            txtSoDu.Enabled = false;
            TaiKhoan s=BllKhachHang.Instance.GetTKByIDTK(id);
            txtIDTK.Text = id;
            txtLienHe.Text = s.LienHe;
            txtTenKH.Text = s.TenKH;
            txtMK.Text = s.MatKhau;
            txtTK.Text = s.TenDN;
            txtSoDu.Text = s.Sodu.ToString();
            txtNMK.Text=s.MatKhau;
        }
        public void TaiKhoanMoi()
        {
            try
            {
                TaiKhoan s = new TaiKhoan()
                {
                    IdTK = txtIDTK.Text,
                    LienHe = txtLienHe.Text,
                    TenDN = txtTK.Text,
                    MatKhau = txtMK.Text,
                    TenKH = txtTenKH.Text,
                    Sodu = Convert.ToInt32(txtSoDu.Text)
                };
                BllKhachHang.Instance.AddorUpdate(s);
            }catch
            {
                System.Windows.MessageBox.Show("Chưa nhập đủ dữ liệu khách hàng","Thông báo", MessageBoxButton.OK);
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNMK.Text == txtMK.Text)
            {
                TaiKhoanMoi();
                d("", "");
                this.Close();
            }
            else
            {
                System.Windows.MessageBox.Show("Mật khẩu được nhập không đúng", "Thông báo !", MessageBoxButton.OK);
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNap_Click(object sender, EventArgs e)
        {
            if (txtNap.Text != null )
            {
                int moneyAdd = Convert.ToInt32(txtNap.Text);
                if (moneyAdd > 0)
                {
                    int nap = Convert.ToInt32(txtSoDu.Text) + moneyAdd;
                    txtSoDu.Text = nap.ToString();
                    TaiKhoanMoi();
                    d("", "");
                    txtNap.Text = null;
                }
                else System.Windows.MessageBox.Show("Số lượng nạp không đúng", "Thông báo",MessageBoxButton.OK);
            }
            else
            {
                System.Windows.MessageBox.Show("Vui lòng nhập số tiền cần nạp", "Thông báo !", MessageBoxButton.OK);
                txtNap.Text = null;
            }

        }

        private void txtIDTK__TextChanged(object sender, EventArgs e)
        {
            
                if (txtIDTK.Text != "")
                {
                    string Taikhoan = "user" + txtIDTK.Text;
                    txtTK.Text = Taikhoan;
                }
                else txtTK.Text = "";
            
        }
        public string MaKHtutang()
        {
            List<int> l = new List<int>();
            foreach (TaiKhoan tk in BllKhachHang.Instance.GetListTKByIDTK(""))
            {
                l.Add(Convert.ToInt32(tk.IdTK.Remove(0, 2)));
            }
            for (int i = 0; i < l.Count; i++)
            {
                if (!l.Contains(i + 1)) return i + 1 < 10 ? "KH00" + ++i : i + 1 < 100 ? "KH0" + ++i : "KH" + ++i;
            }
            return l.Count + 1 < 10 ? "KH00" + (l.Count + 1) : l.Count + 1 < 100 ? "KH0" + (l.Count + 1) : "KH" + (l.Count + 1);
        }

        private void txtNMK__TextChanged(object sender, EventArgs e)
        {
            if(txtNMK.Text !="" && txtNMK.Text != txtMK.Text)
            {
                txtNMK.BorderFocusColor = Color.Red;
                txtNMK.BorderColor = Color.Red;
                lbEr.Visible=true;
            }
            else if(txtNMK.Text == txtMK.Text)
            {
                txtNMK.BorderFocusColor = Color.HotPink;
                lbEr.Visible=false;
            }
        }
        private void textBoxNumberOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
