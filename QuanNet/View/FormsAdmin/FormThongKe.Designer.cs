namespace QuanNet
{
    partial class FormThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bieuDo1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.bieuDo1)).BeginInit();
            this.SuspendLayout();
            // 
            // bieuDo1
            // 
            chartArea1.Name = "ChartArea1";
            this.bieuDo1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.bieuDo1.Legends.Add(legend1);
            this.bieuDo1.Location = new System.Drawing.Point(225, 180);
            this.bieuDo1.Name = "bieuDo1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.bieuDo1.Series.Add(series1);
            this.bieuDo1.Size = new System.Drawing.Size(666, 365);
            this.bieuDo1.TabIndex = 0;
            this.bieuDo1.Text = "chart1";
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1154, 622);
            this.Controls.Add(this.bieuDo1);
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.bieuDo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart bieuDo1;
    }
}