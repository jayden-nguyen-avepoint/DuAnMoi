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

namespace QuanNet
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
            ShowListHD("");
            TongHoaDon();
            sort.Items.AddRange(new object[] {"Tên khách hàng","Ngày xuất","Tổng tiền" });
        }
        public void TongHoaDon()
        {   
            int dem=0;
            int Tongtienhd=0;
            foreach (DataGridViewRow i in dgvHoaDon.Rows)
            {
                dem += 1;
            }
            foreach (HoaDonChiTiet i in BllHoaDon.Instance.GetListHDCTByID(""))
            {
                Tongtienhd += Convert.ToInt32(i.TongTien);
            }
            lbTong.Text = dem.ToString();
            lbTongTien.Text = Tongtienhd.ToString();
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

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {
            DateTime start=dateStart.Value;
            DateTime end = dateEnd.Value;
            if (start == end)
            {
                ShowListHD("",start.ToString());
            }
            else dgvHoaDon.DataSource = BllHoaDon.Instance.SearchByDay(start, end);
        }

        private void sort_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            BllHoaDon.Instance.Sort(sort.SelectedIndex);
        }
    }
}
