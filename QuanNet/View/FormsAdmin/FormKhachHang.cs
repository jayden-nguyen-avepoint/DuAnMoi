﻿using System;
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
                BllQLy.Instance.Edit(tk);
            }
            else BllQLy.Instance.Add(tk);
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
            if (BllQLy.Instance.CheckAddUpdate(ID))
            {
                txtIDTK.Enabled = false;
                txtIDTK.Text = (BllQLy.Instance.GetTKByIDTK(ID)).IdTK.ToString();
                txtLienHe.Text = (BllQLy.Instance.GetTKByIDTK(ID)).LienHe;
                txtTenKH.Text = (BllQLy.Instance.GetTKByIDTK(ID)).TenKH.ToString();
                txtTK.Text = (BllQLy.Instance.GetTKByIDTK(ID)).TenDN.ToString();
                txtTK.Enabled = false;
                txtMK.Text = (BllQLy.Instance.GetTKByIDTK(ID)).MatKhau.ToString();
                txtSoDu.Text = (BllQLy.Instance.GetTKByIDTK(ID)).Sodu.ToString();
                txtSoDu.Enabled = false;
            }
            
        }
        public void ShowList(string i)
        {   
            txtIDTK.Text=MaKHtutang();
            dgvKH.DataSource = BllQLy.Instance.GetTKViewByIDKH(i);
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
            BllQLy.Instance.Add(tk);
            SetNull();
            ShowList("");
            txtIDTK.Enabled = false;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count == 1)
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
                BllQLy.Instance.Edit(tk);
                SetNull();
                ShowList("");
                dgvKH.ClearSelection();
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow i in dgvKH.SelectedRows)
                {
                    string IDKH = i.Cells["ID_TaiKhoan"].Value.ToString();
                    BllQLy.Instance.DeleteKH(IDKH);
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
                int moneyAdd = Convert.ToInt32(txtNap.Text);
                if (moneyAdd > 0)
                {
                    int Sodu = Convert.ToInt32(txtSoDu.Text);
                    Sodu += moneyAdd;
                    txtSoDu.Text = Sodu.ToString();
                    txtNap.Text = "";
                }
                else MessageBox.Show("Số lượng nạp không đúng", "Thông báo", MessageBoxButtons.OK);
                NewTK();
            }

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyWord = txtSearch.Text.ToLower();
            dgvKH.DataSource = BllQLy.Instance.SearchKH(keyWord);

        }
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            ShowList("");
            SetNull();
            txtIDTK.Enabled = false;
            txtTK.Enabled = false;
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
            string ma = (BllQLy.Instance.GetIDTKCuoi()).IdTK.ToString();
            string s = ma.Substring(2, ma.Length - 2);
            int i = int.Parse(s);
            i++;
            if (i < 10) return "KH00" + Convert.ToString(i);
            else
            if (i < 100) return "KH0" + Convert.ToString(i);
            else return "KH" + Convert.ToString(i);       
         }
    }
}