using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using QuanNet.BLL;
using QuanNet.DTO;

namespace QuanNet
{
    public partial class FormThongKe : Form
    { 
        public FormThongKe()
        {
            InitializeComponent();
        }  
        private void FormThongKe_Load(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(BllThongKe.Instance.GetSLHoaDonCT(DateTime.Now.Month,DateTime.Now.Year,"h"));
            label6.Text = Convert.ToString(BllThongKe.Instance.GetPriceHoaDonCT(DateTime.Now.Month, DateTime.Now.Year, "h")) + "VND";
            chart1.DataSource = BllThongKe.Instance.SortData(BllThongKe.Instance.GetDoanhThuTungNgay(BllThongKe.Instance.GetDoanhThuLoad()));
            chart1.Series[0].XValueMember = "Ngay";
            chart1.Series[0].YValueMembers = "TongHoaDon";          
            chart1.DataBind();
            dgrvThongKe.DataSource = BllThongKe.Instance.GetListHDCTView_TheoThongKe(DateTime.Now.Year, DateTime.Now.Month, 5);
        }

        private void btnThisYear_Click(object sender, EventArgs e)
        {       
            label3.Text = Convert.ToString(BllThongKe.Instance.GetSLHoaDonCT(DateTime.Now.Month, DateTime.Now.Year, "y"));
            label6.Text = Convert.ToString(BllThongKe.Instance.GetPriceHoaDonCT(DateTime.Now.Month, DateTime.Now.Year, "y")) + "VND";
            chart1.DataSource = BllThongKe.Instance.GetDoanhThuThisYear1();
            chart1.Series[0].XValueMember = "Thang";
            chart1.Series[0].YValueMembers = "TongHoaDon";
            chart1.DataBind();
            dgrvThongKe.DataSource = BllThongKe.Instance.GetListHDCTView_TheoThongKe(DateTime.Now.Year, DateTime.Now.Month, 1);
            
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(BllThongKe.Instance.GetSLHoaDonCT(DateTime.Now.Month, DateTime.Now.Year, "m"));
            label6.Text = Convert.ToString(BllThongKe.Instance.GetPriceHoaDonCT(DateTime.Now.Month, DateTime.Now.Year, "m")) + "VND";
            chart1.DataSource = BllThongKe.Instance.SortData(BllThongKe.Instance.GetDoanhThuTungNgay(BllThongKe.Instance.GetDoanhThuThisMonth(DateTime.Now.Month, DateTime.Now.Year)));
            chart1.Series[0].XValueMember = "Ngay";
            chart1.Series[0].YValueMembers = "TongHoaDon";
            chart1.DataBind();
            dgrvThongKe.DataSource = BllThongKe.Instance.GetListHDCTView_TheoThongKe(DateTime.Now.Year, DateTime.Now.Month, 2);

        }

        private void btnLast7day_Click(object sender, EventArgs e)
        {

            label3.Text = Convert.ToString(BllThongKe.Instance.GetSLHoaDonCT(DateTime.Now.Month, DateTime.Now.Year, "l7"));
            label6.Text = Convert.ToString(BllThongKe.Instance.GetPriceHoaDonCT(DateTime.Now.Month, DateTime.Now.Year, "l7")) + "VND";
            chart1.DataSource =BllThongKe.Instance.SortData(BllThongKe.Instance.GetDoanhThuTungNgay(BllThongKe.Instance.GetDoanhThuLast7Day()));
            chart1.Series[0].XValueMember = "Ngay";
            chart1.Series[0].YValueMembers = "TongHoaDon";
            chart1.DataBind();
            dgrvThongKe.DataSource = BllThongKe.Instance.GetListHDCTView_TheoThongKe(DateTime.Now.Year, DateTime.Now.Month, 4);
        }

        private void btnLast30Day_Click(object sender, EventArgs e)
        {

            label3.Text = Convert.ToString(BllThongKe.Instance.GetSLHoaDonCT(DateTime.Now.Month, DateTime.Now.Year, "l30"));
            label6.Text = Convert.ToString(BllThongKe.Instance.GetPriceHoaDonCT(DateTime.Now.Month, DateTime.Now.Year, "l30")) + "VND";
            chart1.DataSource = BllThongKe.Instance.SortData(BllThongKe.Instance.GetDoanhThuTungNgay(BllThongKe.Instance.GetDoanhThuLast30Day()));
            chart1.Series[0].XValueMember = "Ngay";
            chart1.Series[0].YValueMembers = "TongHoaDon";
            chart1.DataBind();
            dgrvThongKe.DataSource = BllThongKe.Instance.GetListHDCTView_TheoThongKe(DateTime.Now.Year, DateTime.Now.Month, 3);
        }

        
    }
}
