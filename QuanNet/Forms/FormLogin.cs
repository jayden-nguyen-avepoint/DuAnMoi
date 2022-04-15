using FontAwesome.Sharp;
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
    public partial class FormLogin : Form
    {
        //----
        private string PasswordAdmin = "123";
        private string IDAdmin = "admin";
        private IconButton currentBtn;
    private Panel leftBorderBtn;
    private Form currentChildForm;
        public FormLogin()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 110);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = true;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //====
            ShowDB(false);
            
        }
        public void ShowDB(bool a)
        {
            if (a)
            {
                txtMKQL.Visible = true;
                txtTKQL.Visible = true;
                cusBtn1.Visible = true;
                iconQuanLy.Visible = true;
            }
            else
            {
                txtMKQL.Visible = false;
                txtTKQL.Visible = false;
                cusBtn1.Visible = false;
                iconQuanLy.Visible = false;
            }
        }
        //-----------------Code UI Form---------------------------------------------------
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(34, 33, 74);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconForm.IconChar = currentBtn.IconChar;
                iconForm.IconColor = color;
                lblTitle.ForeColor = iconForm.IconColor;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconForm.IconChar = IconChar.Home;
            iconForm.IconColor = Color.MediumPurple;
            lblTitle.Text = "Home";
        }

        //---------End Code UI------------------------------------------------------------
        private void btnLoginQL_Click(object sender, EventArgs e)
        {   
            ActivateButton(sender, RGBColors.color1);
            ShowDB(true);
            
        }

        private void btnLoginKhach_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            ShowDB(false);

        }

        private void cusBtn1_Click(object sender, EventArgs e)
        {
            if (txtTKQL.Texts == IDAdmin && txtMKQL.Texts == PasswordAdmin)
            {
                Form1 f = new Form1();
                f.Show();

            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thong bao", MessageBoxButtons.OK);
            }
            txtMKQL.Texts = "";
            txtTKQL.Texts = "";
        }

        private void cusBtn1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter)
            {
               if (txtTKQL.Texts == IDAdmin && txtMKQL.Texts == PasswordAdmin)
               {
                    Form1 f = new Form1();
                    f.Show();
                    
               }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thong bao", MessageBoxButtons.OK);
                }
                txtMKQL.Texts = "";
                txtTKQL.Texts = "";
                e.Handled = true;
                
            }
        }
    }
}
