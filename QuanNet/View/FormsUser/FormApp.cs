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

namespace QuanNet.FormsUser
{
    public partial class FormApp : Form
    {
        public string ID_May { get; set; }
        public string IDKhachHang { get; set; }

        public FormApp(string M, string K)
        {
            ID_May = M;
            IDKhachHang = K;
            InitializeComponent();

        }

        private void icon_Click(object sender, EventArgs e)
        {
            txtHĐ.Text = ((Button)sender).Name;
            BllMayTinh.Instance.addTKinMay(ID_May, IDKhachHang, txtHĐ.Text.ToString());
            
        }


    }
}
