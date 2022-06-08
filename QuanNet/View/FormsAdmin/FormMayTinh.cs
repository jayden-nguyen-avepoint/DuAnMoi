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
using QuanNet.CustomsDetail;
using QuanNet.LinQ;
using QuanNet.FormsUser;

namespace QuanNet
{
    public partial class FormMayTinh : Form
    {
        public delegate int Mydel(DateTime EndTime);
        public Mydel d { get; set; }
        public string time { get; set; }
        public FormMayTinh()
        {
            InitializeComponent();
            txtMay.Enabled = false;    
        }
        public void GUI(string IDMay)
        {
            if (BllMayTinh.Instance.GetMayByIDMay(IDMay).IdTK == null)
            {
                txtIDTK.Text = "Trống";
            }
            else
            {
                txtIDTK.Text = (BllMayTinh.Instance.GetMayByIDMay(IDMay)).IdTK.ToString();
                FormUsers f = new FormUsers(txtMay.Text, txtIDTK.Text);
                f.t = (s)=>txtTien.Text=s.ToString();
            }
            txtMay.Text =BllMayTinh.Instance.GetMayByIDMay(IDMay).IdMay ;
            txtCauHinh.Text = BllMayTinh.Instance.GetMayByIDMay(IDMay).CauHinh;
            txtTien.Text = BllMayTinh.Instance.GetMayByIDMay(IDMay).TienGio.ToString();
            txtHD.Text = BllMayTinh.Instance.GetMayByIDMay(IDMay).HoatDong;

            txtCauHinh.Enabled=false;
            txtTien.Enabled=false;
        }
        // Hiển thị thông tin máy tính lên màn hình
        private void sh(int s)
        {
            txtTien.Text=s.ToString();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            string maMay = ((Button)sender).Name;
            txtMay.Text = maMay;
            GUI(maMay);
        }
        // Chọn máy 

        private void FormMayTinh_Load(object sender, EventArgs e)
        {
            foreach (var item in panel1.Controls)
            {
                if (item is IconButton)
                {
                    if (BllMayTinh.Instance.GetMayByIDMay(((IconButton)item).Name).TrangThai == true)
                    {
                        ((IconButton)item).IconColor = Color.Red;
                    }
                }
            }
            //Load may tinh đang sử dụng sẽ hiện đỏ, còn trống- xanh
            //FormUsers f = new FormUsers();
            //f.t = (s)=> txttgchoi.Text=s;
            //Truyền con trỏ hàm với Lambda Expressions
        }
    }
}
