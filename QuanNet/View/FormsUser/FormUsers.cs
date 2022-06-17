using QuanNet.BLL;
using QuanNet.CustomsDetail;
using QuanNet.LinQ;
using QuanNet.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanNet.FormsUser
{
    public partial class FormUsers : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public string ID_May { get; set; }
        public string IDKhachHang { get; set; }
        public string time { get; set; }
        public string ID_CT { get; set; }
        public FormUsers(string M, string K)
        {
            InitializeComponent();
            ID_May = M;
            IDKhachHang = K;
            
            txtMay.Enabled = false;
            txtSodu.Enabled=false;
            
            timer1.Start();

            GUIUser(ID_May);
            BllMayTinh.Instance.addTKinMay(ID_May, IDKhachHang,null);
            
            random = new Random();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }
        public FormUsers()
        {
        }
//=============CODE Giao diện người dùng===================================================================================================
        private Color SelectThemeColor()
        {
            int index = random.Next(theme.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(theme.ColorList.Count);
            }
            tempIndex = index;
            string color = theme.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = theme.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }
//================================================================================================================================
        //Code chức năng
        public void GUIUser(string ID_May)
        {
            txtMay.Text = ID_May.ToString();
            foreach (May i in BllMayTinh.Instance.GetListMayByID(ID_May))
            {
                txtGia.Text = i.TienGio.ToString();
                txtSodu.Text = i.TaiKhoan.Sodu.ToString();
            }
        }
        //GUI() hiển thị thông tin lên màn hình chính

        public int TinhTgChoi(DateTime t)
        {
            TimeSpan f = Convert.ToDateTime(DateTime.Now.ToLongTimeString()) - Convert.ToDateTime(time);
            int tienGio = BllMayTinh.Instance.GetMayByIDMay(ID_May).TienGio;
            int TongTienChoi = tienGio * f.Hours + tienGio * f.Minutes / 60 + tienGio * f.Seconds / 3600;
            if (TongTienChoi <= 2000)
            {
                TongTienChoi = 2000;
            }
            else
            {
                string TT = Convert.ToString(TongTienChoi);
                if (Convert.ToInt32(TT.Substring(TT.Length - 3, 3)) > 1)
                {
                    TongTienChoi = (Convert.ToInt32(TT.Substring(0, TT.Length - 3)) + 1) * 1000;
                }
                else return TongTienChoi;
            }
            return TongTienChoi;
        }
        // Hàm TinhTGchoi(), khi kết thúc, gọi hàm để tính tổng tg chơi và tiền
        private void btnApp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormApp(ID_May, IDKhachHang), sender);
        }
        //Mở form app

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormOrderKH(ID_May, IDKhachHang,ID_CT), sender);           
        }
        /*Mở form Order*/
        public void ending()
        {
            timer1.Stop();

            TaiKhoan s= new TaiKhoan()
            {
                IdTK=IDKhachHang,
                LienHe=BllKhachHang.Instance.GetTKByIDTK(IDKhachHang).LienHe,
                TenDN= BllKhachHang.Instance.GetTKByIDTK(IDKhachHang).TenDN,
                MatKhau= BllKhachHang.Instance.GetTKByIDTK(IDKhachHang).MatKhau,
                TenKH= BllKhachHang.Instance.GetTKByIDTK(IDKhachHang).TenKH,
                Sodu = BllKhachHang.Instance.GetTKByIDTK(IDKhachHang).Sodu - TinhTgChoi(Convert.ToDateTime(time)) - Convert.ToInt32(txtOrder.Text)
            };
            BllKhachHang.Instance.Edit(s);
            BllMayTinh.Instance.addTKinMay(ID_May, null, null);
            BllHoaDon.Instance.updatetongtien(ID_CT);
            Dispose();
        }
        //Hàm ending(), khi kết thúc tự cập nhật HDCT, Máy, Tắt màn hình user
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ending();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTG.Text= (Convert.ToDateTime(DateTime.Now.ToLongTimeString())-Convert.ToDateTime(time)).ToString();
            
        }
        private void FormUsers_Load(object sender, EventArgs e)
        {

            time = DateTime.Now.ToString();
            ID_CT = BllHoaDon.Instance.CreateIDCT(IDKhachHang, ID_May);
            BllHoaDon.Instance.AddHDCT(new HoaDonChiTiet
            {
                IdChiTiet = ID_CT,
                IdMay = ID_May,
                NgayThang= DateTime.Now,
                TongTien = null
            });
        }
        private void txtTG__TextChanged(object sender, EventArgs e)
        {
            txtOrder.Text = BllOrderKH.Instance.TinhTienOrder(ID_CT).ToString();
            int TienChoiTatca = TinhTgChoi(DateTime.Now) + Convert.ToInt32(txtOrder.Text);
            txtTongTien.Text = TienChoiTatca.ToString();
            txtSodu.Text = BllMayTinh.Instance.GetMayByIDMay(ID_May).TaiKhoan.Sodu.ToString();
        }

        private void txtTongTien__TextChanged(object sender, EventArgs e)
        {
            
            if (Convert.ToInt32(txtTongTien.Text) > Convert.ToInt32(txtSodu.Text) - BllMayTinh.Instance.GetMayByIDMay(ID_May).TienGio)
            {
                MessageBox.Show("Tài khoản sắp hết, cần nạp thêm để tiếp tục dịch vụ", "Thông báo", MessageBoxButtons.OK);
            }
                if (Convert.ToInt32(txtTongTien.Text) == Convert.ToInt32(txtSodu.Text))
                {
                    MessageBox.Show("Tài khoản đã hết, cần nạp thêm để tiếp tục dịch vụ", "Thông báo", MessageBoxButtons.OK);
                    ending();
                }
        }
    }
}
