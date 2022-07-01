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
using QuanNet.Properties;
using QuanNet.View.FormsAdmin;

namespace QuanNet
{
    public partial class FormKhachHang : Form
    {   
        public FormKhachHang()
        {
            InitializeComponent(); 
            cbbSort.Items.AddRange(new object[] { "All", "ID Khách hàng", "Tên khách hàng", "Số dư" });
            cbbSort.SelectedIndex = 0;
            ShowList("");
            dgvKH.ClearSelection();
        }
        
        public void ShowList(string id, string key="")
        {   
            dgvKH.DataSource = BllKhachHang.Instance.GetView(id,key);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            AddEditForm f=new AddEditForm("");
            f.Show();
            f.d = new AddEditForm.MyDel(ShowList);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count == 1)
            {
                string id = dgvKH.SelectedRows[0].Cells["ID_TaiKhoan"].Value.ToString();
                AddEditForm f = new AddEditForm(id);
                f.Show();
                f.d = new AddEditForm.MyDel(ShowList);
            }
            else MessageBox.Show("Vui lòng chọn một khách hàng cần tương tác", "Thông báo", MessageBoxButtons.OK);
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count> 0)
            {
                foreach (DataGridViewRow i in dgvKH.SelectedRows)
                {
                    string IDKH = i.Cells["ID_TaiKhoan"].Value.ToString();
                    BllKhachHang.Instance.DeleteKH(IDKH);
                }
            }
                ShowList("");
                dgvKH.ClearSelection();
        }
        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            ShowList("", txtSearch.Text);
        }

        private void cbbSort_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cbbSort.ForeColor=Color.White;
            dgvKH.DataSource= BllKhachHang.Instance.Sort(cbbSort.SelectedIndex);
        }
    }
}
