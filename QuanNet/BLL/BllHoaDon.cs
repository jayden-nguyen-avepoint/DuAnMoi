using QuanNet.DTO;
using QuanNet.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanNet.BLL
{
    public class BllHoaDon
    {
        DoAnQLCyber db = new DoAnQLCyber();
        private static BllHoaDon _Instance;
        public static BllHoaDon Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BllHoaDon();
                };
                return _Instance;
            }
            private set { }
        }
        private BllHoaDon()
        {

        }
        public HoaDon GetHDByID(string IDHD)
        {
            return db.HoaDons.Find(IDHD);
            //return ve 1 record duy nhat
        }
        public List<HoaDon> GetListHDByID(string IDHD)
        {
            List<HoaDon> data = new List<HoaDon>();
            if (IDHD == "")
            {
                data = db.HoaDons.ToList();
            }
            else
            {
                data = db.HoaDons.Where(p => p.IdHoaDon == IDHD.ToString()).Select(p => p).ToList();
            }
            return data;
        }
        public List<HoaDonView> GetHDViewByIDHD(string IDHD,string keyWord)
        {
            List<HoaDonView> data = new List<HoaDonView>();
            foreach (HoaDon i in GetListHDByID(IDHD))
            {
                if (i.IdHoaDon.Contains(keyWord) || i.IdTK.Contains(keyWord))
                {
                    data.Add(new HoaDonView
                    {
                        ID_HoaDon = i.IdHoaDon,
                        NgayXuatHD = i.NgayXuatHD,
                        Tai_Khoan = i.IdTK,
                    });
                }
            }
            return data;

        }
        public void DeleteHD(string IDHD)
            {
                HoaDon s = db.HoaDons.Find(IDHD);
                db.HoaDons.Remove(s);
                db.SaveChanges();
            }
        
    }
}
