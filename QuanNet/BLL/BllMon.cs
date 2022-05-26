using QuanNet.LinQ;
using QuanNet.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanNet.BLL
{
    public class BllMon
    {
        DoAnQLCyber db = new DoAnQLCyber();
        private static BllMon _Instance;
        public static BllMon Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BllMon();
                };
                return _Instance;
            }
            private set { }
        }
        private BllMon()
        {

        }
        public TPham GetTphamByID(string IDTpham)
        {
            return db.TPhams.Find(IDTpham);
            //return ve 1 record duy nhat
        }
        public List<TPham> GetListTphamByID(string IDTpham)
        {
            List<TPham> data = new List<TPham>();
            if (IDTpham == "")
            {
                data = db.TPhams.ToList();
            }
            else
            {
                data = db.TPhams.Where(p => p.IdTP == IDTpham.ToString()).Select(p => p).ToList();
            }
            return data;
        }
    }
}
