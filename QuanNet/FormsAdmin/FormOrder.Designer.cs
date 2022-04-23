namespace QuanNet
{
    partial class FormOrder
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
            this.cusBtn2 = new QuanNet.CustomsDetail.CusBtn();
            this.cusBtn1 = new QuanNet.CustomsDetail.CusBtn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cusCbb1 = new QuanNet.CustomsDetail.CusCbb();
            this.customTextbox1 = new QuanNet.CustomsDetail.CustomTextbox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 622);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cusBtn2);
            this.panel2.Controls.Add(this.cusBtn1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cusCbb1);
            this.panel2.Controls.Add(this.customTextbox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 476);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1154, 146);
            this.panel2.TabIndex = 1;
            // 
            // cusBtn2
            // 
            this.cusBtn2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cusBtn2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cusBtn2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cusBtn2.BorderRadius = 20;
            this.cusBtn2.BorderSize = 0;
            this.cusBtn2.FlatAppearance.BorderSize = 0;
            this.cusBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cusBtn2.ForeColor = System.Drawing.Color.White;
            this.cusBtn2.Location = new System.Drawing.Point(201, 15);
            this.cusBtn2.Name = "cusBtn2";
            this.cusBtn2.Size = new System.Drawing.Size(150, 40);
            this.cusBtn2.TabIndex = 5;
            this.cusBtn2.Text = "Hủy Order";
            this.cusBtn2.TextColor = System.Drawing.Color.White;
            this.cusBtn2.UseVisualStyleBackColor = false;
            // 
            // cusBtn1
            // 
            this.cusBtn1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cusBtn1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cusBtn1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cusBtn1.BorderRadius = 20;
            this.cusBtn1.BorderSize = 0;
            this.cusBtn1.FlatAppearance.BorderSize = 0;
            this.cusBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cusBtn1.ForeColor = System.Drawing.Color.White;
            this.cusBtn1.Location = new System.Drawing.Point(22, 15);
            this.cusBtn1.Name = "cusBtn1";
            this.cusBtn1.Size = new System.Drawing.Size(150, 40);
            this.cusBtn1.TabIndex = 4;
            this.cusBtn1.Text = "Xác nhận";
            this.cusBtn1.TextColor = System.Drawing.Color.White;
            this.cusBtn1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(880, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sắp xếp";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(877, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm kiếm";
            // 
            // cusCbb1
            // 
            this.cusCbb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cusCbb1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cusCbb1.BorderSize = 1;
            this.cusCbb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cusCbb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cusCbb1.ForeColor = System.Drawing.Color.White;
            this.cusCbb1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cusCbb1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cusCbb1.ListTextColor = System.Drawing.Color.DimGray;
            this.cusCbb1.Location = new System.Drawing.Point(959, 51);
            this.cusCbb1.MinimumSize = new System.Drawing.Size(150, 30);
            this.cusCbb1.Name = "cusCbb1";
            this.cusCbb1.Padding = new System.Windows.Forms.Padding(1);
            this.cusCbb1.Size = new System.Drawing.Size(182, 30);
            this.cusCbb1.TabIndex = 1;
            this.cusCbb1.Texts = "";
            // 
            // customTextbox1
            // 
            this.customTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.customTextbox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextbox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextbox1.BorderRadius = 15;
            this.customTextbox1.BorderSize = 2;
            this.customTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextbox1.ForeColor = System.Drawing.Color.White;
            this.customTextbox1.Location = new System.Drawing.Point(955, 9);
            this.customTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.customTextbox1.Multiline = false;
            this.customTextbox1.Name = "customTextbox1";
            this.customTextbox1.Padding = new System.Windows.Forms.Padding(7);
            this.customTextbox1.PasswordChar = false;
            this.customTextbox1.PlaceholderColor = System.Drawing.Color.DimGray;
            this.customTextbox1.PlaceholderText = "Search...";
            this.customTextbox1.Size = new System.Drawing.Size(186, 35);
            this.customTextbox1.TabIndex = 0;
            this.customTextbox1.Texts = "";
            this.customTextbox1.UnderlinedStyle = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(105)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 60;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1129, 448);
            this.dataGridView1.TabIndex = 17;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1154, 622);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormOrder";
            this.Text = "Order";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CustomsDetail.CustomTextbox customTextbox1;
        private CustomsDetail.CusBtn cusBtn2;
        private CustomsDetail.CusBtn cusBtn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomsDetail.CusCbb cusCbb1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}