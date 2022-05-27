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
using QuanNet.LinQ;

namespace QuanNet
{
    public partial class FormOrder : Form
    {
   
        public string ID_CT { get; set; }
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
            ID_CT = cbbHDCT.SelectedItem.ToString();
            Show(ID_CT);
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
            BllHoaDon.Instance.AddHD(
                new HoaDon
                {
                    IdHoaDon = BllHoaDon.Instance.MaHoaDon(),
                    NgayXuatHD = DateTime.Now,
                    IdTK = BllMayTinh.Instance.GetIDTK(BllHoaDon.Instance.IDMAY(ID_CT)),
                    //IdTK = "KH001",
                    
                    IdChiTiet = ID_CT

                }) ;
            
        }
    }
}
