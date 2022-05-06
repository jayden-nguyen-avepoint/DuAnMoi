//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace QuanNet
//{
//    public class Datatest
//    {
//        public DataTable DTKH { get; set; }

//        public Datatest()
//        {

//            DTKH = new DataTable();
//            DTKH.Columns.AddRange(new DataColumn[]
//            {
//                        new DataColumn{ColumnName="ID", DataType= typeof(int)},
//                        new DataColumn{ColumnName="Name", DataType= typeof(string)},
//                        new DataColumn{ColumnName="Contacts", DataType= typeof(string)},
//                        new DataColumn{ColumnName="SoDu", DataType= typeof(int)},
                        
//            });
//            DTKH.Rows.Add("102", "NVA", "18T","20000" );
//            DTKH.Rows.Add("103", "NVB", "18T","50000" );
//            DTKH.Rows.Add("104", "NVC", "19T", "240000");
//        }
//        public DataTable GetData()
//        {
//            return DTKH;
//        }
//    }
//}
