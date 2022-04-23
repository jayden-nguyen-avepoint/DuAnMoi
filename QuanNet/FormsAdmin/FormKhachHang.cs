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
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
                    {
                    new DataColumn {ColumnName = "ID", DataType= typeof(int)},
                    new DataColumn {ColumnName = "Name", DataType= typeof(string)},
                    new DataColumn { ColumnName = "Contacts", DataType = typeof(string) },
                    new DataColumn { ColumnName = "So Du", DataType = typeof(int) },
                    });
            dt.Rows.Add("102", "NVA", "18T", "20000");
            dt.Rows.Add("103", "NVB", "18T", "50000");
            dt.Rows.Add("104", "NVC", "19T", "240000");
            dataGridView1.DataSource = dt;
            
        }
        
        
        

    }
}
