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
        private string PasswordKH = "123";
        private string IDKH = "user";
        private IconButton currentBtn;
    private Panel leftBorderBtn;
    private Form thisChildForm;
        public FormLogin()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 166);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = true;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //====
            
            
        }
        public void ShowDB(bool a)
        {
            if (a)
            {
                panelQL.Visible = true;
                panelKHmain.Visible = false;
            }
            else
            {
                panelQL.Visible=false;
                panelKHmain.Visible = true;
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
            if (thisChildForm != null)
            {
                thisChildForm.Close();
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
            if (txtTKQL.Text == IDAdmin && txtMKQL.Text == PasswordAdmin)
            {
                Form1 f = new Form1();
                f.Show();

            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thong bao", MessageBoxButtons.OK);
            }
            txtMKQL.Text = "";
            txtTKQL.Text = "";
        }

        private void cusBtn1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter)
            {
               if (txtTKQL.Text == IDAdmin && txtMKQL.Text == PasswordAdmin)
               {
                    Form1 f = new Form1();
                    f.Show();
                    
               }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thong bao", MessageBoxButtons.OK);
                }
                txtMKQL.Text = "";
                txtTKQL.Text = "";
                e.Handled = true;
                
            }
        }

        private void cusBtnKH_Click(object sender, EventArgs e)
        {
            if (txtTKKH.Text == IDKH && txtMKKH.Text == PasswordKH )
            {
                FormsUser.FormUsers f = new FormsUser.FormUsers();
                f.Show();

            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thong bao", MessageBoxButtons.OK);
            }
            txtTKKH.Text = "";
            txtMKKH.Text = "";
        }
        //fuck this shit bruh
    }
}
