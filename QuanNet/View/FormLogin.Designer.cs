namespace QuanNet
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLoginKhach = new FontAwesome.Sharp.IconButton();
            this.btnLoginQL = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelQL = new System.Windows.Forms.Panel();
            this.iconQuanLy = new FontAwesome.Sharp.IconPictureBox();
            this.txtTKQL = new QuanNet.CustomsDetail.CustomTextbox();
            this.txtMKQL = new QuanNet.CustomsDetail.CustomTextbox();
            this.cusBtn1 = new QuanNet.CustomsDetail.CusBtn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.iconForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelKHmain = new System.Windows.Forms.Panel();
            this.BtnKH = new QuanNet.CustomsDetail.CusBtn();
            this.txtMKKH = new QuanNet.CustomsDetail.CustomTextbox();
            this.txtTKKH = new QuanNet.CustomsDetail.CustomTextbox();
            this.iconKH = new FontAwesome.Sharp.IconPictureBox();
            this.panelKH = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbMay = new QuanNet.CustomsDetail.CusCbb();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panelQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconQuanLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.panelKHmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconKH)).BeginInit();
            this.panelKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnLoginKhach);
            this.panelMenu.Controls.Add(this.btnLoginQL);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(258, 543);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLoginKhach
            // 
            this.btnLoginKhach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoginKhach.FlatAppearance.BorderSize = 0;
            this.btnLoginKhach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginKhach.ForeColor = System.Drawing.Color.Transparent;
            this.btnLoginKhach.IconChar = FontAwesome.Sharp.IconChar.Tv;
            this.btnLoginKhach.IconColor = System.Drawing.Color.White;
            this.btnLoginKhach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoginKhach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoginKhach.Location = new System.Drawing.Point(0, 376);
            this.btnLoginKhach.Name = "btnLoginKhach";
            this.btnLoginKhach.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLoginKhach.Size = new System.Drawing.Size(258, 166);
            this.btnLoginKhach.TabIndex = 2;
            this.btnLoginKhach.Text = "Khách Hàng";
            this.btnLoginKhach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoginKhach.UseVisualStyleBackColor = true;
            this.btnLoginKhach.Click += new System.EventHandler(this.btnLoginKhach_Click);
            // 
            // btnLoginQL
            // 
            this.btnLoginQL.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoginQL.FlatAppearance.BorderSize = 0;
            this.btnLoginQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginQL.ForeColor = System.Drawing.Color.Transparent;
            this.btnLoginQL.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnLoginQL.IconColor = System.Drawing.Color.White;
            this.btnLoginQL.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoginQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoginQL.Location = new System.Drawing.Point(0, 210);
            this.btnLoginQL.Name = "btnLoginQL";
            this.btnLoginQL.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLoginQL.Size = new System.Drawing.Size(258, 166);
            this.btnLoginQL.TabIndex = 1;
            this.btnLoginQL.Text = "Quản Lý";
            this.btnLoginQL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoginQL.UseVisualStyleBackColor = true;
            this.btnLoginQL.Click += new System.EventHandler(this.btnLoginQL_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(258, 210);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(212, 185);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Controls.Add(this.iconForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(258, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(620, 75);
            this.panelTitleBar.TabIndex = 1;
            // 
            // panelQL
            // 
            this.panelQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQL.Controls.Add(this.iconQuanLy);
            this.panelQL.Controls.Add(this.txtTKQL);
            this.panelQL.Controls.Add(this.txtMKQL);
            this.panelQL.Controls.Add(this.cusBtn1);
            this.panelQL.Location = new System.Drawing.Point(168, 2);
            this.panelQL.Name = "panelQL";
            this.panelQL.Size = new System.Drawing.Size(289, 456);
            this.panelQL.TabIndex = 6;
            // 
            // iconQuanLy
            // 
            this.iconQuanLy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconQuanLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconQuanLy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconQuanLy.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconQuanLy.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconQuanLy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconQuanLy.IconSize = 146;
            this.iconQuanLy.Location = new System.Drawing.Point(73, 41);
            this.iconQuanLy.Name = "iconQuanLy";
            this.iconQuanLy.Size = new System.Drawing.Size(155, 146);
            this.iconQuanLy.TabIndex = 3;
            this.iconQuanLy.TabStop = false;
            // 
            // txtTKQL
            // 
            this.txtTKQL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTKQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtTKQL.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTKQL.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTKQL.BorderRadius = 0;
            this.txtTKQL.BorderSize = 2;
            this.txtTKQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTKQL.ForeColor = System.Drawing.Color.White;
            this.txtTKQL.Location = new System.Drawing.Point(20, 209);
            this.txtTKQL.Margin = new System.Windows.Forms.Padding(4);
            this.txtTKQL.Multiline = false;
            this.txtTKQL.Name = "txtTKQL";
            this.txtTKQL.Padding = new System.Windows.Forms.Padding(7);
            this.txtTKQL.PasswordChar = false;
            this.txtTKQL.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtTKQL.PlaceholderText = "ID...";
            this.txtTKQL.Size = new System.Drawing.Size(250, 35);
            this.txtTKQL.TabIndex = 0;
            this.txtTKQL.UnderlinedStyle = true;
            this.txtTKQL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cusBtn1_KeyPress);
            // 
            // txtMKQL
            // 
            this.txtMKQL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMKQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtMKQL.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMKQL.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMKQL.BorderRadius = 0;
            this.txtMKQL.BorderSize = 2;
            this.txtMKQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKQL.ForeColor = System.Drawing.Color.White;
            this.txtMKQL.Location = new System.Drawing.Point(20, 268);
            this.txtMKQL.Margin = new System.Windows.Forms.Padding(4);
            this.txtMKQL.Multiline = false;
            this.txtMKQL.Name = "txtMKQL";
            this.txtMKQL.Padding = new System.Windows.Forms.Padding(7);
            this.txtMKQL.PasswordChar = true;
            this.txtMKQL.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtMKQL.PlaceholderText = "Mật khẩu...";
            this.txtMKQL.Size = new System.Drawing.Size(250, 35);
            this.txtMKQL.TabIndex = 1;
            this.txtMKQL.UnderlinedStyle = true;
            this.txtMKQL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cusBtn1_KeyPress);
            // 
            // cusBtn1
            // 
            this.cusBtn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cusBtn1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cusBtn1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cusBtn1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cusBtn1.BorderRadius = 20;
            this.cusBtn1.BorderSize = 0;
            this.cusBtn1.FlatAppearance.BorderSize = 0;
            this.cusBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cusBtn1.ForeColor = System.Drawing.Color.White;
            this.cusBtn1.Location = new System.Drawing.Point(57, 371);
            this.cusBtn1.Name = "cusBtn1";
            this.cusBtn1.Size = new System.Drawing.Size(171, 62);
            this.cusBtn1.TabIndex = 2;
            this.cusBtn1.Text = "Đăng nhập";
            this.cusBtn1.TextColor = System.Drawing.Color.White;
            this.cusBtn1.UseVisualStyleBackColor = false;
            this.cusBtn1.Click += new System.EventHandler(this.cusBtn1_Click);
            this.cusBtn1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cusBtn1_KeyPress);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.lblTitle.Location = new System.Drawing.Point(67, 23);
            this.lblTitle.MinimumSize = new System.Drawing.Size(200, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "LOGIN";
            // 
            // iconForm
            // 
            this.iconForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.iconForm.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.iconForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconForm.Location = new System.Drawing.Point(30, 27);
            this.iconForm.Name = "iconForm";
            this.iconForm.Size = new System.Drawing.Size(32, 32);
            this.iconForm.TabIndex = 0;
            this.iconForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(258, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(620, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.panelQL);
            this.panelDesktop.Controls.Add(this.panelKHmain);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(258, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(620, 459);
            this.panelDesktop.TabIndex = 3;
            // 
            // panelKHmain
            // 
            this.panelKHmain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelKHmain.Controls.Add(this.BtnKH);
            this.panelKHmain.Controls.Add(this.txtMKKH);
            this.panelKHmain.Controls.Add(this.txtTKKH);
            this.panelKHmain.Controls.Add(this.iconKH);
            this.panelKHmain.Controls.Add(this.panelKH);
            this.panelKHmain.Location = new System.Drawing.Point(168, 3);
            this.panelKHmain.Name = "panelKHmain";
            this.panelKHmain.Size = new System.Drawing.Size(289, 456);
            this.panelKHmain.TabIndex = 2;
            // 
            // BtnKH
            // 
            this.BtnKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnKH.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnKH.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnKH.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnKH.BorderRadius = 20;
            this.BtnKH.BorderSize = 0;
            this.BtnKH.FlatAppearance.BorderSize = 0;
            this.BtnKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKH.ForeColor = System.Drawing.Color.White;
            this.BtnKH.Location = new System.Drawing.Point(53, 351);
            this.BtnKH.Name = "BtnKH";
            this.BtnKH.Size = new System.Drawing.Size(171, 62);
            this.BtnKH.TabIndex = 4;
            this.BtnKH.Text = "Đăng nhập";
            this.BtnKH.TextColor = System.Drawing.Color.White;
            this.BtnKH.UseVisualStyleBackColor = false;
            this.BtnKH.Click += new System.EventHandler(this.cusBtnKH_Click);
            // 
            // txtMKKH
            // 
            this.txtMKKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMKKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtMKKH.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMKKH.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMKKH.BorderRadius = 0;
            this.txtMKKH.BorderSize = 2;
            this.txtMKKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKKH.ForeColor = System.Drawing.Color.White;
            this.txtMKKH.Location = new System.Drawing.Point(14, 236);
            this.txtMKKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMKKH.Multiline = false;
            this.txtMKKH.Name = "txtMKKH";
            this.txtMKKH.Padding = new System.Windows.Forms.Padding(7);
            this.txtMKKH.PasswordChar = true;
            this.txtMKKH.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtMKKH.PlaceholderText = "Mật khẩu...";
            this.txtMKKH.Size = new System.Drawing.Size(250, 35);
            this.txtMKKH.TabIndex = 4;
            this.txtMKKH.UnderlinedStyle = true;
            // 
            // txtTKKH
            // 
            this.txtTKKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTKKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtTKKH.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTKKH.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTKKH.BorderRadius = 0;
            this.txtTKKH.BorderSize = 2;
            this.txtTKKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTKKH.ForeColor = System.Drawing.Color.White;
            this.txtTKKH.Location = new System.Drawing.Point(13, 193);
            this.txtTKKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTKKH.Multiline = false;
            this.txtTKKH.Name = "txtTKKH";
            this.txtTKKH.Padding = new System.Windows.Forms.Padding(7);
            this.txtTKKH.PasswordChar = false;
            this.txtTKKH.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtTKKH.PlaceholderText = "Tài khoản...";
            this.txtTKKH.Size = new System.Drawing.Size(250, 35);
            this.txtTKKH.TabIndex = 4;
            this.txtTKKH.UnderlinedStyle = true;
            // 
            // iconKH
            // 
            this.iconKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconKH.IconChar = FontAwesome.Sharp.IconChar.Tv;
            this.iconKH.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconKH.IconSize = 146;
            this.iconKH.ImageLocation = "";
            this.iconKH.Location = new System.Drawing.Point(84, 20);
            this.iconKH.Name = "iconKH";
            this.iconKH.Size = new System.Drawing.Size(151, 146);
            this.iconKH.TabIndex = 5;
            this.iconKH.TabStop = false;
            // 
            // panelKH
            // 
            this.panelKH.Controls.Add(this.label1);
            this.panelKH.Controls.Add(this.cbbMay);
            this.panelKH.Location = new System.Drawing.Point(19, 291);
            this.panelKH.Name = "panelKH";
            this.panelKH.Size = new System.Drawing.Size(250, 57);
            this.panelKH.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mở:";
            // 
            // cbbMay
            // 
            this.cbbMay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cbbMay.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbMay.BorderSize = 1;
            this.cbbMay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbbMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbbMay.ForeColor = System.Drawing.Color.White;
            this.cbbMay.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.cbbMay.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbMay.ListTextColor = System.Drawing.Color.White;
            this.cbbMay.Location = new System.Drawing.Point(45, 10);
            this.cbbMay.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbbMay.Name = "cbbMay";
            this.cbbMay.Padding = new System.Windows.Forms.Padding(1);
            this.cbbMay.Size = new System.Drawing.Size(200, 30);
            this.cbbMay.TabIndex = 0;
            this.cbbMay.Texts = "";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 543);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MaximumSize = new System.Drawing.Size(1410, 800);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cusBtn1_KeyPress);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelQL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconQuanLy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelKHmain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconKH)).EndInit();
            this.panelKH.ResumeLayout(false);
            this.panelKH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private FontAwesome.Sharp.IconButton btnLoginKhach;
        private FontAwesome.Sharp.IconButton btnLoginQL;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconPictureBox iconForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private CustomsDetail.CustomTextbox txtTKQL;
        private CustomsDetail.CusBtn cusBtn1;
        private CustomsDetail.CustomTextbox txtMKQL;
        private FontAwesome.Sharp.IconPictureBox iconQuanLy;
        private System.Windows.Forms.Panel panelKH;
        private System.Windows.Forms.Label label1;
        private CustomsDetail.CusCbb cbbMay;
        private FontAwesome.Sharp.IconPictureBox iconKH;
        private System.Windows.Forms.Panel panelKHmain;
        private CustomsDetail.CusBtn BtnKH;
        private CustomsDetail.CustomTextbox txtMKKH;
        private CustomsDetail.CustomTextbox txtTKKH;
        private System.Windows.Forms.Panel panelQL;
    }
}

