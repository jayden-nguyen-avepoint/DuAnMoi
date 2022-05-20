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

namespace QuanNet
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
            ShowListHD("");
        }
        public void ShowListHD(string i,string Key="")
        {
            dgvHoaDon.DataSource = BllHoaDon.Instance.GetHDViewByIDHD(i,Key);
        }
        private void btnInHD_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow i in dgvHoaDon.SelectedRows)
                {
                    BllHoaDon.Instance.DeleteHD(i.Cells["IdHoaDon"].Value.ToString());
                }
            }
            ShowListHD("");
            dgvHoaDon.ClearSelection();

        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            ShowListHD("", txtSearch.Text);
        }
    }
}
