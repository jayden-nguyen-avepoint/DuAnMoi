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

namespace QuanNet
{
    public partial class FormMayTinh : Form
    {
        private IconButton currentBtn;
        public FormMayTinh()
        {
            InitializeComponent();
            txtMay.Enabled = false;
        }

        public void GUI(string IDMay)
        {

            txtIDTK.Enabled = false;
            //txtIDTK.Text = (BllQLy.Instance.GetTKByIDTK(ID)).IdTK.ToString();
            txtMay.Text =BllQLy.Instance.GetMayByIDMay(IDMay).IdMay ;
            txtCauHinh.Text = BllQLy.Instance.GetMayByIDMay(IDMay).CauHinh;
            txtTien.Text = BllQLy.Instance.GetMayByIDMay(IDMay).TienGio.ToString();
              


        }

        private void Button_Click(object sender, EventArgs e)
        {
            string maMay = "";
            if (((Button)sender).Text.Length ==1) 
            {
                 maMay = "M0" + ((Button)sender).Text;
            }else maMay ="M"+ ((Button)sender).Text;
            txtMay.Text = maMay;
            GUI(maMay);
            if (BllQLy.Instance.GetMayByIDMay(maMay).TrangThai)
            {
                ((IconButton)sender).IconColor = Color.Red;
            }
            else ((IconButton)sender).IconColor = Color.Chartreuse;
        }
    }
}
