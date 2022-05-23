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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
            cbbHDCT.Items.Add("None");
            cbbHDCT.Items.AddRange(BllOrderKH.Instance.GetCBB().ToArray());
        }
        public void Show(string CT)
        {
            dgvOrder.DataSource= BllOrderKH.Instance.GetListTPViewByIDCT(CT);
        }

        private void cbbHDCT_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Show(cbbHDCT.SelectedItem.ToString());
        }
    }
}
