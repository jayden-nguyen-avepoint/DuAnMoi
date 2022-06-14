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
                Tongtienhd += Convert.ToInt32(i.Cells["Tong_Tien"].Value);
            }
            lbTong.Text = dem.ToString();
            lbTongTien.Text = Tongtienhd.ToString();
        }
        public void ShowListHD(string i,string Key="")
        {
            dgvHoaDon.DataSource = BllHoaDon.Instance.GetHDViewByIDHD(i,Key);
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            ShowListHD("", txtSearch.Text);
        }

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {
            DateTime start=dateStart.Value;
            DateTime end = dateEnd.Value;
            dgvHoaDon.DataSource = BllHoaDon.Instance.SearchByDay(start, end);
            //if (start == end)
            //{
            //    dgvHoaDon.DataSource = BllHoaDon.Instance.SearchByDay(start, end);
            //}
            //else dgvHoaDon.DataSource = BllHoaDon.Instance.SearchByDay(start, end);
        }

        private void sort_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            BllHoaDon.Instance.Sort(sort.SelectedIndex);
        }
    }
}
