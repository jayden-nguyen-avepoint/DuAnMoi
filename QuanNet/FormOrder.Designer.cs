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
            this.cusBtn1 = new QuanNet.CustomsDetail.CusBtn();
            this.SuspendLayout();
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
            this.cusBtn1.Location = new System.Drawing.Point(412, 211);
            this.cusBtn1.Name = "cusBtn1";
            this.cusBtn1.Size = new System.Drawing.Size(150, 40);
            this.cusBtn1.TabIndex = 0;
            this.cusBtn1.Text = "cusBtn1";
            this.cusBtn1.TextColor = System.Drawing.Color.White;
            this.cusBtn1.UseVisualStyleBackColor = false;
            this.cusBtn1.Click += new System.EventHandler(this.cusBtn1_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1154, 622);
            this.Controls.Add(this.cusBtn1);
            this.Name = "FormOrder";
            this.Text = "Order";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomsDetail.CusBtn cusBtn1;
    }
}