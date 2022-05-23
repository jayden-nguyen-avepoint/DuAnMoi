using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanNet.BLL
{
    class BllHDCT
    {
        DoAnQLCyber db = new DoAnQLCyber();
        private static BllHDCT _Instance;
        public static BllHDCT Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BllHDCT();
                };
                return _Instance;
            }
            private set { }
        }
       
        public string LastId()
        {
            string ma = "0";
            if (db.HoaDonChiTiets == null)
            {
                return ma;
            }
            else if(db.HoaDonChiTiets != null)
            {
                
                 ma = Convert.ToString(db.HoaDonChiTiets.OrderByDescending(p => p.IdChiTiet).FirstOrDefault().IdChiTiet.Substring(4));
                
                
            }
            return ma;
                //return ma;d

        }
        public void adddl(HoaDonChiTiet a)
        { 
            db.HoaDonChiTiets.Add(a);
            db.SaveChanges();        
        }
   
        public string GetIDCT(string idmay)
        {
            string idct = "";
            List<HoaDonChiTiet> data = new List<HoaDonChiTiet>();
            data = db.HoaDonChiTiets.Where(p => p.IdMay == idmay.ToString()).Select(p => p).ToList();
            foreach (HoaDonChiTiet t in data)
            {
                idct = t.IdChiTiet;
            }
            return idct;
        }
    }
}
