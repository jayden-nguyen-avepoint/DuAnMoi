namespace QuanNet.FormsUser
{
    partial class FormUsers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnApp = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSodu = new QuanNet.CustomsDetail.CustomTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongTien = new QuanNet.CustomsDetail.CustomTextbox();
            this.btnThanhToan = new QuanNet.CustomsDetail.CusBtn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrder = new QuanNet.CustomsDetail.CustomTextbox();
            this.txtGia = new QuanNet.CustomsDetail.CustomTextbox();
            this.txtTG = new QuanNet.CustomsDetail.CustomTextbox();
            this.txtMay = new QuanNet.CustomsDetail.CustomTextbox();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btnOrder);
            this.panelMenu.Controls.Add(this.btnApp);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 753);
            this.panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 428);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 325);
            this.panel1.TabIndex = 3;
            // 
            // btnOrder
            // 
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 294);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnOrder.Size = new System.Drawing.Size(220, 134);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnApp
            // 
            this.btnApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnApp.FlatAppearance.BorderSize = 0;
            this.btnApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApp.Location = new System.Drawing.Point(0, 160);
            this.btnApp.Name = "btnApp";
            this.btnApp.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnApp.Size = new System.Drawing.Size(220, 134);
            this.btnApp.TabIndex = 2;
            this.btnApp.Text = "App Center";
            this.btnApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApp.UseVisualStyleBackColor = true;
            this.btnApp.Click += new System.EventHandler(this.btnApp_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 160);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanNet.Properties.Resources.Hoc_Them_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1172, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(45, 23);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(95, 31);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "HOME";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDesktopPanel.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(941, 673);
            this.panelDesktopPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtSodu);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtTongTien);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtOrder);
            this.panel2.Controls.Add(this.txtGia);
            this.panel2.Controls.Add(this.txtTG);
            this.panel2.Controls.Add(this.txtMay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1167, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 673);
            this.panel2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(6, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 61;
            this.label7.Text = "Số dư";
            // 
            // txtSodu
            // 
            this.txtSodu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtSodu.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSodu.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSodu.BorderRadius = 15;
            this.txtSodu.BorderSize = 2;
            this.txtSodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSodu.ForeColor = System.Drawing.Color.DimGray;
            this.txtSodu.Location = new System.Drawing.Point(75, 329);
            this.txtSodu.Margin = new System.Windows.Forms.Padding(4);
            this.txtSodu.Multiline = false;
            this.txtSodu.Name = "txtSodu";
            this.txtSodu.Padding = new System.Windows.Forms.Padding(7);
            this.txtSodu.PasswordChar = false;
            this.txtSodu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSodu.PlaceholderText = "";
            this.txtSodu.Size = new System.Drawing.Size(136, 35);
            this.txtSodu.TabIndex = 60;
            this.txtSodu.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(2, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 59;
            this.label5.Text = "Bill order\r\n";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtTongTien.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTongTien.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTongTien.BorderRadius = 15;
            this.txtTongTien.BorderSize = 2;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.DimGray;
            this.txtTongTien.Location = new System.Drawing.Point(75, 277);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Multiline = false;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Padding = new System.Windows.Forms.Padding(7);
            this.txtTongTien.PasswordChar = false;
            this.txtTongTien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTongTien.PlaceholderText = "";
            this.txtTongTien.Size = new System.Drawing.Size(136, 35);
            this.txtTongTien.TabIndex = 58;
            this.txtTongTien.UnderlinedStyle = false;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnThanhToan.BackgroundColor = System.Drawing.Color.MediumOrchid;
            this.btnThanhToan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThanhToan.BorderRadius = 20;
            this.btnThanhToan.BorderSize = 0;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(27, 266);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(138, 47);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextColor = System.Drawing.Color.White;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(4, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 57;
            this.label4.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(4, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 56;
            this.label3.Text = "Giá giờ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(2, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 55;
            this.label2.Text = "Thời gian";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(0, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 54;
            this.label6.Text = "Số máy";
            // 
            // txtOrder
            // 
            this.txtOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtOrder.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtOrder.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtOrder.BorderRadius = 15;
            this.txtOrder.BorderSize = 2;
            this.txtOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrder.ForeColor = System.Drawing.Color.DimGray;
            this.txtOrder.Location = new System.Drawing.Point(75, 224);
            this.txtOrder.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrder.Multiline = false;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Padding = new System.Windows.Forms.Padding(7);
            this.txtOrder.PasswordChar = false;
            this.txtOrder.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtOrder.PlaceholderText = "";
            this.txtOrder.Size = new System.Drawing.Size(136, 35);
            this.txtOrder.TabIndex = 3;
            this.txtOrder.UnderlinedStyle = false;
            // 
            // txtGia
            // 
            this.txtGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtGia.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtGia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGia.BorderRadius = 15;
            this.txtGia.BorderSize = 2;
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.ForeColor = System.Drawing.Color.DimGray;
            this.txtGia.Location = new System.Drawing.Point(75, 175);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.Multiline = false;
            this.txtGia.Name = "txtGia";
            this.txtGia.Padding = new System.Windows.Forms.Padding(7);
            this.txtGia.PasswordChar = false;
            this.txtGia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGia.PlaceholderText = "";
            this.txtGia.Size = new System.Drawing.Size(136, 35);
            this.txtGia.TabIndex = 2;
            this.txtGia.UnderlinedStyle = false;
            // 
            // txtTG
            // 
            this.txtTG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtTG.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTG.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTG.BorderRadius = 15;
            this.txtTG.BorderSize = 2;
            this.txtTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTG.ForeColor = System.Drawing.Color.DimGray;
            this.txtTG.Location = new System.Drawing.Point(74, 127);
            this.txtTG.Margin = new System.Windows.Forms.Padding(4);
            this.txtTG.Multiline = false;
            this.txtTG.Name = "txtTG";
            this.txtTG.Padding = new System.Windows.Forms.Padding(7);
            this.txtTG.PasswordChar = false;
            this.txtTG.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTG.PlaceholderText = "";
            this.txtTG.Size = new System.Drawing.Size(136, 35);
            this.txtTG.TabIndex = 1;
            this.txtTG.UnderlinedStyle = false;
            // 
            // txtMay
            // 
            this.txtMay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtMay.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMay.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMay.BorderRadius = 15;
            this.txtMay.BorderSize = 2;
            this.txtMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMay.ForeColor = System.Drawing.Color.DimGray;
            this.txtMay.Location = new System.Drawing.Point(74, 78);
            this.txtMay.Margin = new System.Windows.Forms.Padding(4);
            this.txtMay.Multiline = false;
            this.txtMay.Name = "txtMay";
            this.txtMay.Padding = new System.Windows.Forms.Padding(7);
            this.txtMay.PasswordChar = false;
            this.txtMay.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMay.PlaceholderText = "";
            this.txtMay.Size = new System.Drawing.Size(136, 35);
            this.txtMay.TabIndex = 0;
            this.txtMay.UnderlinedStyle = false;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1392, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan Ly ";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelMenu;
    private System.Windows.Forms.Panel panelLogo;
    private System.Windows.Forms.Button btnApp;
    private System.Windows.Forms.Panel panelTitleBar;
    private System.Windows.Forms.Label labelTitle;
    private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panel2;
        private CustomsDetail.CustomTextbox txtOrder;
        private CustomsDetail.CustomTextbox txtGia;
        private CustomsDetail.CustomTextbox txtTG;
        private CustomsDetail.CustomTextbox txtMay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private CustomsDetail.CustomTextbox txtSodu;
        private System.Windows.Forms.Label label5;
        private CustomsDetail.CustomTextbox txtTongTien;
        private CustomsDetail.CusBtn btnThanhToan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}