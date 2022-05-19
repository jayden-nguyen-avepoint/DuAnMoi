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

namespace QuanNet
{
    public partial class FormMayTinh : Form
    {
        public IconButton currentBtn;
        public FormMayTinh()
        {
            InitializeComponent();
            txtMay.Enabled = false;
        }
       
        
        public void GUI(string IDMay)
        {
            if ((BllMayTinh.Instance.GetMayByIDMay(IDMay)).IdTK==null)
            {
                txtIDTK.Text = "Trống";
            }
            else txtIDTK.Text = (BllMayTinh.Instance.GetMayByIDMay(IDMay)).IdTK.ToString();
            txtMay.Text =BllMayTinh.Instance.GetMayByIDMay(IDMay).IdMay ;
            txtCauHinh.Text = BllMayTinh.Instance.GetMayByIDMay(IDMay).CauHinh;
            txtCauHinh.Enabled=false;
            txtTien.Text = BllMayTinh.Instance.GetMayByIDMay(IDMay).TienGio.ToString();
            txtTien.Enabled=false;
        }
        private void Button_Click(object sender, EventArgs e)
        {
            string maMay = ((Button)sender).Name;
            txtMay.Text = maMay;
            GUI(maMay);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            dgvMaytinh.DataSource = BllMayTinh.Instance.GetListMayByID(txtMay.Text);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {

        }
    }
}
