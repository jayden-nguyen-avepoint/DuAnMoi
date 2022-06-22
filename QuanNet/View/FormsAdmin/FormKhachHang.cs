using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanNet.BLL;
using QuanNet.DTO;
using QuanNet.LinQ;
using QuanNet.Properties;

namespace QuanNet
{
    public partial class FormKhachHang : Form
    {   
        public FormKhachHang()
        {
            InitializeComponent(); 
            txtIDTK.Text = MaKHtutang();
            txtIDTK.Enabled = false;
            txtTK.Enabled = false;
            cbbSort.Items.AddRange(new object[] { "", "ID Khách hàng", "Tên khách hàng", "Số dư" });
        }
        public void NewTK()
        {
            TaiKhoan tk = new TaiKhoan()
            {   
                IdTK = txtIDTK.Text,
                LienHe = txtLienHe.Text,
                TenKH = txtTenKH.Text,
                TenDN = txtTK.Text,
                MatKhau = txtMK.Text,
                Sodu = Convert.ToInt32(txtSoDu.Text),
            };
            if (dgvKH.SelectedRows.Count == 1)
            {
                BllKhachHang.Instance.Edit(tk);
            }
            else BllKhachHang.Instance.Add(tk);
        }
        public void SetNull()
        {
            if (txtIDTK.Text != "")
            {
                string Taikhoan = "user" + txtIDTK.Text;
                txtTK.Text = Taikhoan;
            }
            txtIDTK.Enabled = false;
            txtTK.Enabled = false;
            txtMK.Text = null;
            txtTenKH.Text = null;
            txtSoDu.Text = null;
            txtLienHe.Text = null;
            txtIDTK.Enabled = true;
            txtTK.Enabled = true;
            txtSoDu.Enabled = true;
        }
        public void GUI(string ID)
        {
            if (BllKhachHang.Instance.CheckAddUpdate(ID))
            {
                txtIDTK.Enabled = false;
                txtIDTK.Text = (BllKhachHang.Instance.GetTKByIDTK(ID)).IdTK.ToString();
                txtLienHe.Text = (BllKhachHang.Instance.GetTKByIDTK(ID)).LienHe;
                txtTenKH.Text = (BllKhachHang.Instance.GetTKByIDTK(ID)).TenKH.ToString();
                txtTK.Text = (BllKhachHang.Instance.GetTKByIDTK(ID)).TenDN.ToString();
                txtTK.Enabled = false;
                txtTK.ForeColor= Color.White;
                txtMK.Text = (BllKhachHang.Instance.GetTKByIDTK(ID)).MatKhau.ToString();
                txtSoDu.Text = (BllKhachHang.Instance.GetTKByIDTK(ID)).Sodu.ToString();
                txtSoDu.Enabled = false;
            }
            
        }
        public void ShowList(string i, string key="")
        {   
            txtIDTK.Text=MaKHtutang();
            dgvKH.DataSource = BllKhachHang.Instance.GetTKViewByIDKH(i,key);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {   
            TaiKhoan tk = new TaiKhoan()
            {
                IdTK = txtIDTK.Text,
                LienHe = txtLienHe.Text,
                TenKH = txtTenKH.Text,
                TenDN = txtTK.Text,
                MatKhau = txtMK.Text,
                Sodu = Convert.ToInt32(txtSoDu.Text),
            };
            BllKhachHang.Instance.Add(tk);
            SetNull();
            ShowList("");
            txtIDTK.Enabled = false;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow i in dgvKH.SelectedRows)
                {
                    string IDKH = i.Cells["ID_TaiKhoan"].Value.ToString();
                    BllKhachHang.Instance.DeleteKH(IDKH);
                }
            }
                SetNull();
                ShowList("");
                dgvKH.ClearSelection();
        }
        private void btnNap_Click(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count == 1)
            {
                if (txtNap.Text != "")
                {
                    int moneyAdd = Convert.ToInt32(txtNap.Text);
                    if (moneyAdd > 0)
                    {
                        int Sodu = Convert.ToInt32(txtSoDu.Text);
                        Sodu += moneyAdd;
                        txtSoDu.Text = Sodu.ToString();
                        txtNap.Text = "";
                    }
                    else MessageBox.Show("Số lượng nạp không đúng", "Thông báo", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Nhập số lượng tiền cần nạp cho tài khoản", "Thông báo", MessageBoxButtons.OK);
                NewTK();
                ShowList("");
            }

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowList("", txtSearch.Text);

        }
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            ShowList("");
            SetNull();
            txtIDTK.Enabled = false;
            txtTK.Enabled = false;
            txtTK.ForeColor = Color.White;
            dgvKH.ClearSelection();
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKH.SelectedRows.Count != 0)
            {
                string ID = dgvKH.SelectedRows[0].Cells["ID_TaiKhoan"].Value.ToString();
                GUI(ID);
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
                for(int i=0; i<l.Count;i++)
                {
                    if (!l.Contains(i + 1)) return i + 1 < 10 ? "KH00" + ++i : i + 1 < 100 ? "KH0" + ++i : "KH" + ++i;
                }
                return l.Count + 1 < 10 ? "KH00" + (l.Count + 1) : l.Count + 1 < 100 ? "KH0" + (l.Count + 1) : "KH" + (l.Count + 1);            
         }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            ShowList("", txtSearch.Text);
        }

        private void cbbSort_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            dgvKH.DataSource= BllKhachHang.Instance.Sort(cbbSort.SelectedIndex);
        }
    }
}
