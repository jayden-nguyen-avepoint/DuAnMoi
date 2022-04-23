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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customTextbox1 = new QuanNet.CustomsDetail.CustomTextbox();
            this.customTextbox2 = new QuanNet.CustomsDetail.CustomTextbox();
            this.customTextbox3 = new QuanNet.CustomsDetail.CustomTextbox();
            this.customTextbox4 = new QuanNet.CustomsDetail.CustomTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cusBtn1 = new QuanNet.CustomsDetail.CusBtn();
            this.label5 = new System.Windows.Forms.Label();
            this.customTextbox5 = new QuanNet.CustomsDetail.CustomTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.customTextbox6 = new QuanNet.CustomsDetail.CustomTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel2.Controls.Add(this.customTextbox6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.customTextbox5);
            this.panel2.Controls.Add(this.cusBtn1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.customTextbox4);
            this.panel2.Controls.Add(this.customTextbox3);
            this.panel2.Controls.Add(this.customTextbox2);
            this.panel2.Controls.Add(this.customTextbox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1167, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 673);
            this.panel2.TabIndex = 3;
            // 
            // customTextbox1
            // 
            this.customTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.customTextbox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextbox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextbox1.BorderRadius = 15;
            this.customTextbox1.BorderSize = 2;
            this.customTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextbox1.ForeColor = System.Drawing.Color.DimGray;
            this.customTextbox1.Location = new System.Drawing.Point(74, 78);
            this.customTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.customTextbox1.Multiline = false;
            this.customTextbox1.Name = "customTextbox1";
            this.customTextbox1.Padding = new System.Windows.Forms.Padding(7);
            this.customTextbox1.PasswordChar = false;
            this.customTextbox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextbox1.PlaceholderText = "";
            this.customTextbox1.Size = new System.Drawing.Size(136, 35);
            this.customTextbox1.TabIndex = 0;
            this.customTextbox1.Texts = "";
            this.customTextbox1.UnderlinedStyle = false;
            // 
            // customTextbox2
            // 
            this.customTextbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.customTextbox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextbox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextbox2.BorderRadius = 15;
            this.customTextbox2.BorderSize = 2;
            this.customTextbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextbox2.ForeColor = System.Drawing.Color.DimGray;
            this.customTextbox2.Location = new System.Drawing.Point(74, 127);
            this.customTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.customTextbox2.Multiline = false;
            this.customTextbox2.Name = "customTextbox2";
            this.customTextbox2.Padding = new System.Windows.Forms.Padding(7);
            this.customTextbox2.PasswordChar = false;
            this.customTextbox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextbox2.PlaceholderText = "";
            this.customTextbox2.Size = new System.Drawing.Size(136, 35);
            this.customTextbox2.TabIndex = 1;
            this.customTextbox2.Texts = "";
            this.customTextbox2.UnderlinedStyle = false;
            // 
            // customTextbox3
            // 
            this.customTextbox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.customTextbox3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextbox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextbox3.BorderRadius = 15;
            this.customTextbox3.BorderSize = 2;
            this.customTextbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextbox3.ForeColor = System.Drawing.Color.DimGray;
            this.customTextbox3.Location = new System.Drawing.Point(75, 175);
            this.customTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.customTextbox3.Multiline = false;
            this.customTextbox3.Name = "customTextbox3";
            this.customTextbox3.Padding = new System.Windows.Forms.Padding(7);
            this.customTextbox3.PasswordChar = false;
            this.customTextbox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextbox3.PlaceholderText = "";
            this.customTextbox3.Size = new System.Drawing.Size(136, 35);
            this.customTextbox3.TabIndex = 2;
            this.customTextbox3.Texts = "";
            this.customTextbox3.UnderlinedStyle = false;
            // 
            // customTextbox4
            // 
            this.customTextbox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.customTextbox4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextbox4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextbox4.BorderRadius = 15;
            this.customTextbox4.BorderSize = 2;
            this.customTextbox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextbox4.ForeColor = System.Drawing.Color.DimGray;
            this.customTextbox4.Location = new System.Drawing.Point(75, 224);
            this.customTextbox4.Margin = new System.Windows.Forms.Padding(4);
            this.customTextbox4.Multiline = false;
            this.customTextbox4.Name = "customTextbox4";
            this.customTextbox4.Padding = new System.Windows.Forms.Padding(7);
            this.customTextbox4.PasswordChar = false;
            this.customTextbox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextbox4.PlaceholderText = "";
            this.customTextbox4.Size = new System.Drawing.Size(136, 35);
            this.customTextbox4.TabIndex = 3;
            this.customTextbox4.Texts = "";
            this.customTextbox4.UnderlinedStyle = false;
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
            // cusBtn1
            // 
            this.cusBtn1.BackColor = System.Drawing.Color.MediumOrchid;
            this.cusBtn1.BackgroundColor = System.Drawing.Color.MediumOrchid;
            this.cusBtn1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cusBtn1.BorderRadius = 20;
            this.cusBtn1.BorderSize = 0;
            this.cusBtn1.FlatAppearance.BorderSize = 0;
            this.cusBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cusBtn1.ForeColor = System.Drawing.Color.White;
            this.cusBtn1.Location = new System.Drawing.Point(72, 391);
            this.cusBtn1.Name = "cusBtn1";
            this.cusBtn1.Size = new System.Drawing.Size(138, 47);
            this.cusBtn1.TabIndex = 0;
            this.cusBtn1.Text = "Thanh toán";
            this.cusBtn1.TextColor = System.Drawing.Color.White;
            this.cusBtn1.UseVisualStyleBackColor = false;
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
            // customTextbox5
            // 
            this.customTextbox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.customTextbox5.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextbox5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextbox5.BorderRadius = 15;
            this.customTextbox5.BorderSize = 2;
            this.customTextbox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextbox5.ForeColor = System.Drawing.Color.DimGray;
            this.customTextbox5.Location = new System.Drawing.Point(75, 277);
            this.customTextbox5.Margin = new System.Windows.Forms.Padding(4);
            this.customTextbox5.Multiline = false;
            this.customTextbox5.Name = "customTextbox5";
            this.customTextbox5.Padding = new System.Windows.Forms.Padding(7);
            this.customTextbox5.PasswordChar = false;
            this.customTextbox5.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextbox5.PlaceholderText = "";
            this.customTextbox5.Size = new System.Drawing.Size(136, 35);
            this.customTextbox5.TabIndex = 58;
            this.customTextbox5.Texts = "";
            this.customTextbox5.UnderlinedStyle = false;
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
            // customTextbox6
            // 
            this.customTextbox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.customTextbox6.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextbox6.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextbox6.BorderRadius = 15;
            this.customTextbox6.BorderSize = 2;
            this.customTextbox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextbox6.ForeColor = System.Drawing.Color.DimGray;
            this.customTextbox6.Location = new System.Drawing.Point(75, 329);
            this.customTextbox6.Margin = new System.Windows.Forms.Padding(4);
            this.customTextbox6.Multiline = false;
            this.customTextbox6.Name = "customTextbox6";
            this.customTextbox6.Padding = new System.Windows.Forms.Padding(7);
            this.customTextbox6.PasswordChar = false;
            this.customTextbox6.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextbox6.PlaceholderText = "";
            this.customTextbox6.Size = new System.Drawing.Size(136, 35);
            this.customTextbox6.TabIndex = 60;
            this.customTextbox6.Texts = "";
            this.customTextbox6.UnderlinedStyle = false;
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
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private CustomsDetail.CustomTextbox customTextbox4;
        private CustomsDetail.CustomTextbox customTextbox3;
        private CustomsDetail.CustomTextbox customTextbox2;
        private CustomsDetail.CustomTextbox customTextbox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private CustomsDetail.CustomTextbox customTextbox6;
        private System.Windows.Forms.Label label5;
        private CustomsDetail.CustomTextbox customTextbox5;
        private CustomsDetail.CusBtn cusBtn1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}