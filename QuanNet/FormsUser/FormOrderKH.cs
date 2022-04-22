using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanNet.FormsUser
{
    public partial class FormOrderKH : Form
    {
        public FormOrderKH()
        {
            InitializeComponent();
        }
        private void Chon_Click(object sender, EventArgs e)
        {
            txtMon.Texts = ((Button)sender).Text;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMon.Texts = "";
            txtSL.Texts = "";
            txtGia.Texts = "";
        }


    }
}
