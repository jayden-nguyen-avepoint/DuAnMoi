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
        public FormMayTinh()
        {
            InitializeComponent();
        }

        public void GUI(string ID)
        {
            if (BllQLy.Instance.CheckAddUpdate(ID))
            {
                txtIDTK.Enabled = false;
                txtIDTK.Text = (BllQLy.Instance.GetTKByIDTK(ID)).IdTK.ToString();
                //txtLienHe.Text = (BllQLy.Instance.GetTKByIDTK(ID)).LienHe;
                //txtTenKH.Text = (BllQLy.Instance.GetTKByIDTK(ID)).TenKH.ToString();
                //txtTK.Text = (BllQLy.Instance.GetTKByIDTK(ID)).TenDN.ToString();
                //txtTK.Enabled = false;
                //txtMK.Text = (BllQLy.Instance.GetTKByIDTK(ID)).MatKhau.ToString();
                //txtSoDu.Text = (BllQLy.Instance.GetTKByIDTK(ID)).Sodu.ToString();
                //txtSoDu.Enabled = false;
            }

        }
    }
}
