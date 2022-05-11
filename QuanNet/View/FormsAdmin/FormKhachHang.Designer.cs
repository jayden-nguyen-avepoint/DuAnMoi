namespace QuanNet
{
    partial class FormKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMK = new QuanNet.CustomsDetail.CustomTextbox();
            this.txtTK = new QuanNet.CustomsDetail.CustomTextbox();
            this.txtSearch = new QuanNet.CustomsDetail.CustomTextbox();
            this.txtNap = new QuanNet.CustomsDetail.CustomTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenKH = new QuanNet.CustomsDetail.CustomTextbox();
            this.txtLienHe = new QuanNet.CustomsDetail.CustomTextbox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.txtSoDu = new QuanNet.CustomsDetail.CustomTextbox();
            this.txtIDTK = new QuanNet.CustomsDetail.CustomTextbox();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.btnNap = new FontAwesome.Sharp.IconButton();
            this.btnDel = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel1.Location = new System.Drawing.Point(26, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtMK);
            this.panel2.Controls.Add(this.txtTK);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.txtNap);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtTenKH);
            this.panel2.Controls.Add(this.txtLienHe);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSoDu);
            this.panel2.Controls.Add(this.txtIDTK);
            this.panel2.Controls.Add(this.dgvKH);
            this.panel2.Controls.Add(this.btnNap);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(39, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 586);
            this.panel2.TabIndex = 2;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(465, 252);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(110, 50);
            this.iconButton1.TabIndex = 29;
            this.iconButton1.Text = "Reload";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.FormKhachHang_Load);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnEdit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(214, 252);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 50);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(299, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tài khoản";
            // 
            // txtMK
            // 
            this.txtMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtMK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.txtMK.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMK.BorderRadius = 0;
            this.txtMK.BorderSize = 2;
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.ForeColor = System.Drawing.Color.White;
            this.txtMK.Location = new System.Drawing.Point(391, 184);
            this.txtMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMK.Multiline = false;
            this.txtMK.Name = "txtMK";
            this.txtMK.Padding = new System.Windows.Forms.Padding(7);
            this.txtMK.PasswordChar = false;
            this.txtMK.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMK.PlaceholderText = "";
            this.txtMK.Size = new System.Drawing.Size(183, 39);
            this.txtMK.TabIndex = 25;
            this.txtMK.UnderlinedStyle = true;
            // 
            // txtTK
            // 
            this.txtTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtTK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.txtTK.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTK.BorderRadius = 0;
            this.txtTK.BorderSize = 2;
            this.txtTK.Enabled = false;
            this.txtTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.ForeColor = System.Drawing.Color.White;
            this.txtTK.Location = new System.Drawing.Point(92, 184);
            this.txtTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTK.Multiline = false;
            this.txtTK.Name = "txtTK";
            this.txtTK.Padding = new System.Windows.Forms.Padding(7);
            this.txtTK.PasswordChar = false;
            this.txtTK.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTK.PlaceholderText = "";
            this.txtTK.Size = new System.Drawing.Size(183, 39);
            this.txtTK.TabIndex = 24;
            this.txtTK.UnderlinedStyle = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.txtSearch.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.BorderSize = 4;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(897, 252);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "...";
            this.txtSearch.Size = new System.Drawing.Size(183, 35);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.UnderlinedStyle = true;
            // 
            // txtNap
            // 
            this.txtNap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtNap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.txtNap.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNap.BorderRadius = 0;
            this.txtNap.BorderSize = 2;
            this.txtNap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNap.ForeColor = System.Drawing.Color.White;
            this.txtNap.Location = new System.Drawing.Point(900, 191);
            this.txtNap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNap.Multiline = false;
            this.txtNap.Name = "txtNap";
            this.txtNap.Padding = new System.Windows.Forms.Padding(7);
            this.txtNap.PasswordChar = false;
            this.txtNap.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNap.PlaceholderText = "0đ";
            this.txtNap.Size = new System.Drawing.Size(183, 39);
            this.txtNap.TabIndex = 21;
            this.txtNap.UnderlinedStyle = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label6.Location = new System.Drawing.Point(459, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "NET HOC THEM";
            // 
            // txtTenKH
            // 
            this.txtTenKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtTenKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.txtTenKH.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenKH.BorderRadius = 0;
            this.txtTenKH.BorderSize = 2;
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.ForeColor = System.Drawing.Color.White;
            this.txtTenKH.Location = new System.Drawing.Point(391, 56);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenKH.Multiline = false;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Padding = new System.Windows.Forms.Padding(7);
            this.txtTenKH.PasswordChar = false;
            this.txtTenKH.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenKH.PlaceholderText = "";
            this.txtTenKH.Size = new System.Drawing.Size(183, 39);
            this.txtTenKH.TabIndex = 20;
            this.txtTenKH.UnderlinedStyle = true;
            // 
            // txtLienHe
            // 
            this.txtLienHe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtLienHe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.txtLienHe.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtLienHe.BorderRadius = 0;
            this.txtLienHe.BorderSize = 2;
            this.txtLienHe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLienHe.ForeColor = System.Drawing.Color.White;
            this.txtLienHe.Location = new System.Drawing.Point(391, 120);
            this.txtLienHe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLienHe.Multiline = false;
            this.txtLienHe.Name = "txtLienHe";
            this.txtLienHe.Padding = new System.Windows.Forms.Padding(7);
            this.txtLienHe.PasswordChar = false;
            this.txtLienHe.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLienHe.PlaceholderText = "";
            this.txtLienHe.Size = new System.Drawing.Size(183, 39);
            this.txtLienHe.TabIndex = 19;
            this.txtLienHe.UnderlinedStyle = true;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 20;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(790, 245);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 42);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSoDu
            // 
            this.txtSoDu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtSoDu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.txtSoDu.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSoDu.BorderRadius = 0;
            this.txtSoDu.BorderSize = 2;
            this.txtSoDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDu.ForeColor = System.Drawing.Color.White;
            this.txtSoDu.Location = new System.Drawing.Point(92, 120);
            this.txtSoDu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoDu.Multiline = false;
            this.txtSoDu.Name = "txtSoDu";
            this.txtSoDu.Padding = new System.Windows.Forms.Padding(7);
            this.txtSoDu.PasswordChar = false;
            this.txtSoDu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoDu.PlaceholderText = "";
            this.txtSoDu.Size = new System.Drawing.Size(183, 39);
            this.txtSoDu.TabIndex = 18;
            this.txtSoDu.UnderlinedStyle = true;
            // 
            // txtIDTK
            // 
            this.txtIDTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtIDTK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.txtIDTK.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIDTK.BorderRadius = 0;
            this.txtIDTK.BorderSize = 2;
            this.txtIDTK.Enabled = false;
            this.txtIDTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDTK.ForeColor = System.Drawing.Color.White;
            this.txtIDTK.Location = new System.Drawing.Point(92, 56);
            this.txtIDTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDTK.Multiline = false;
            this.txtIDTK.Name = "txtIDTK";
            this.txtIDTK.Padding = new System.Windows.Forms.Padding(7);
            this.txtIDTK.PasswordChar = false;
            this.txtIDTK.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIDTK.PlaceholderText = "";
            this.txtIDTK.Size = new System.Drawing.Size(183, 39);
            this.txtIDTK.TabIndex = 17;
            this.txtIDTK.UnderlinedStyle = true;
            this.txtIDTK._TextChanged += new System.EventHandler(this.txtIDTK__TextChanged);
            // 
            // dgvKH
            // 
            this.dgvKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(105)))));
            this.dgvKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKH.ColumnHeadersHeight = 30;
            this.dgvKH.EnableHeadersVisualStyles = false;
            this.dgvKH.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvKH.Location = new System.Drawing.Point(3, 319);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersVisible = false;
            this.dgvKH.RowHeadersWidth = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvKH.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKH.Size = new System.Drawing.Size(1080, 264);
            this.dgvKH.TabIndex = 16;
            this.dgvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellClick);
            // 
            // btnNap
            // 
            this.btnNap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btnNap.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnNap.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btnNap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNap.IconSize = 35;
            this.btnNap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNap.Location = new System.Drawing.Point(790, 184);
            this.btnNap.Name = "btnNap";
            this.btnNap.Size = new System.Drawing.Size(101, 42);
            this.btnNap.TabIndex = 13;
            this.btnNap.Text = "Nạp";
            this.btnNap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNap.UseVisualStyleBackColor = true;
            this.btnNap.Click += new System.EventHandler(this.btnNap_Click);
            // 
            // btnDel
            // 
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btnDel.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnDel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btnDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(341, 252);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(101, 50);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "Xóa";
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnThem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(92, 252);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 50);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số dư:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(307, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Liên hệ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(322, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1154, 622);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormKhachHang";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnNap;
        private FontAwesome.Sharp.IconButton btnDel;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.DataGridView dgvKH;
        private CustomsDetail.CustomTextbox txtNap;
        private CustomsDetail.CustomTextbox txtTenKH;
        private CustomsDetail.CustomTextbox txtLienHe;
        private CustomsDetail.CustomTextbox txtSoDu;
        private CustomsDetail.CustomTextbox txtSearch;
        private CustomsDetail.CustomTextbox txtIDTK;
        private System.Windows.Forms.Label label5;
        private CustomsDetail.CustomTextbox txtMK;
        private CustomsDetail.CustomTextbox txtTK;
        private FontAwesome.Sharp.IconButton btnEdit;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}