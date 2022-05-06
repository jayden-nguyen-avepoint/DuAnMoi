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

namespace QuanNet
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
            //cbbSort.Items.Add(new CBBitemSort { Value = 0, Text = "All" });
            //cbbSort.Items.AddRange(BllQLy.Instance.GetCBB().ToArray());
            dgvKH.DataSource = BllQLy.Instance.GetTKViewByIDKH(0);
        }
        public void ShowList(int i)
        {
            dgvKH.DataSource = BllQLy.Instance.GetTKViewByIDKH(i);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int idkh =(BllQLy.Instance.GetTKByIDTK("1201")).IdKH;
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
                ShowList(0);
            }
        }

        private void btnNap_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

        }
    }
}
