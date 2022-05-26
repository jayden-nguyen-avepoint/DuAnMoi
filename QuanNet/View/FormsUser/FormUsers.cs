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

        public FormUsers(string M, string K)
        {
            InitializeComponent();
            ID_May = M;
            IDKhachHang = K;
            random = new Random();
            GUI(ID_May,IDKhachHang);
            BllMayTinh.Instance.addTKinMay(ID_May, IDKhachHang,"");
            txtMay.Enabled = false;
            txtSodu.Enabled=false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            timer1.Start();
            this.FormBorderStyle = FormBorderStyle.None;
        
    }
        //=============UI CODE=============
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
        //================================
        public void GUI(string ID_May,string IdKhach)
        {
            txtMay.Text = ID_May.ToString();
            foreach(May i in BllMayTinh.Instance.GetListMayByID(ID_May))
            {
                txtGia.Text = i.TienGio.ToString();
                
                foreach (TaiKhoan tk in BllKhachHang.Instance.GetListTKByIDTK(i.IdTK))
                {
                    txtSodu.Text = tk.Sodu.ToString();
                }
            }
        }
        public int TinhTgChoi(DateTime time)
        {
            DateTime aDateTime = DateTime.Now;
            TimeSpan interval = aDateTime.Subtract(time);
            int tienGio = BllMayTinh.Instance.GetMayByIDMay(ID_May).TienGio;
            int TongTienChoi = tienGio * interval.Hours + tienGio * interval.Minutes / 60 + tienGio * interval.Seconds / 3600;
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
        private void btnApp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsUser.FormApp(ID_May, IDKhachHang), sender);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsUser.FormOrderKH(ID_May, IDKhachHang), sender);

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show(TinhTgChoi(Convert.ToDateTime(time)).ToString());
            BllMayTinh.Instance.addTKinMay(ID_May,null,null);
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTG.Text= (Convert.ToDateTime(DateTime.Now.ToLongTimeString())-Convert.ToDateTime(time)).ToString();

        }
        private void FormUsers_Load(object sender, EventArgs e)
        {
            time= DateTime.Now.ToString();
        }
    }
}
