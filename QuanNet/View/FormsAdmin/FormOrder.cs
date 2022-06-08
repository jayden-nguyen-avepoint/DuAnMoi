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
            //cbbHDCT.Items.Add("None");
            //cbbHDCT.Items.AddRange(BllOrderKH.Instance.GetCBB().ToArray());
            ShowOrder();
        }
        public void ShowOrder()
        {
            dgvOrder.DataSource = BllHoaDon.Instance.GetOrderAd("");
        }
        public void Show(string CT)
        {
            dgvOrder.DataSource= BllOrderKH.Instance.GetListTPViewByIDCT(CT);
        }

        private void cbbHDCT_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public string MaHoaDon()
        {
            List<int> l = new List<int>();
            foreach (HoaDon hd in BllHoaDon.Instance.GetListHDByID(""))
            {
                l.Add(Convert.ToInt32(hd.IdHoaDon.Remove(0, 4)));

            }
            for (int i = 0; i < l.Count; i++)
            {
                if (!l.Contains(i + 1)) return i + 1 < 10 ? "Bill00" + ++i : i + 1 < 100 ? "Bill0" + ++i : "Bill" + ++i;
            }
            return l.Count + 1 < 10 ? "Bill00" + (l.Count + 1) : l.Count + 1 < 100 ? "Bill0" + (l.Count + 1) : "Bill" +
                +(l.Count + 1);

        }
        private void btnXN_Click(object sender, EventArgs e)
        {
            ID_CT=  dgvOrder.SelectedRows[0].Cells["IdChiTiet"].Value.ToString();
            //foreach(HoaDonChiTiet i in BllHoaDon.Instance.GetListHDCTByID(ID_CT))
            //{
                
                    if(!BllHoaDon.Instance.checkVal(ID_CT))
                    {
                        MessageBox.Show("error");
                    } 
                        else
                    {
                        HoaDon s = new HoaDon()
                        {
                            IdHoaDon = MaHoaDon(),
                            NgayXuatHD = DateTime.Now,
                            IdTK = ID_CT.Substring(0, 5),
                            IdChiTiet = ID_CT
                        };
                        BllHoaDon.Instance.AddHD(s);

                    }
            ShowOrder();
                
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrder.SelectedRows.Count==1)
            {
                string id = dgvOrder.SelectedRows[0].Cells["IdChiTiet"].Value.ToString();
                Show(id);
                dgvOrder.Enabled = false;
                dgvOrder.ClearSelection();
            }else ShowOrder();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowOrder();
            dgvOrder.ClearSelection();
            dgvOrder.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow i in dgvOrder.SelectedRows)
            {
                string IDKH = i.Cells["IDChiTiet"].Value.ToString();
                BllHoaDon.Instance.DeleteHDCT(IDKH);
                ShowOrder();
            }
        }
    }
}
