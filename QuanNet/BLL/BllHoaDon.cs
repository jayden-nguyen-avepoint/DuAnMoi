using QuanNet.DTO;
using QuanNet.LinQ;
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
        public string ID_CT { get; set; }

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
        //============================Hóa đơn tổng=================================
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
        public void AddHD(HoaDon s)
        {
            db.HoaDons.Add(s);
            db.SaveChanges();
        }
        public void DeleteHD(string IDHD)
        {
            HoaDon s = db.HoaDons.Find(IDHD);
            db.HoaDons.Remove(s);
            db.SaveChanges();
        }
        public string MaHoaDon()
        {
            List<int> l = new List<int>();
            foreach (HoaDon hd in BllHoaDon.Instance.GetListHDByID(""))
            {
                l.Add(Convert.ToInt32(hd.IdHoaDon.Remove(0, 4)));

            }
            for (int i = 0; i < l.Count; i++)
            {
                if (!l.Contains(i + 1)) return i + 1 < 10 ? "Bill00" + ++i : i + 1 < 100 ? "Bill0" + ++i : "Bill" + ++i;
            }
            return l.Count + 1 < 10 ? "Bill00" + (l.Count + 1) : l.Count + 1 < 100 ? "Bill0" + (l.Count + 1) : "Bill" +
                + (l.Count + 1);

        }
        //=======================Hóa đơn chi tiết============================================
        public HoaDonChiTiet GetHoadonCTByID(string Id_HDCT)
        {
            return db.HoaDonChiTiets.Find(Id_HDCT);
            //return ve 1 record duy nhat
        }
        public void AddHDCT(HoaDonChiTiet s)
        {
            db.HoaDonChiTiets.Add(s);
            db.SaveChanges();
        }
        public List<HoaDonChiTiet> GetListHDCTByID(string IDHDCT)
        {
            List<HoaDonChiTiet> data = new List<HoaDonChiTiet>();
            if (IDHDCT == "")
            {
                data = db.HoaDonChiTiets.ToList();
            }
            else
            {
                data = db.HoaDonChiTiets.Where(p => p.IdChiTiet == IDHDCT.ToString()).Select(p => p).ToList();
            }
            return data;
        }
        public string CreateIDCT(string IdKh, string ID_may)
        {
            string idct= IdKh.Substring(0, 5) + ID_may.Substring(1, 2);
            List<int> Ma = new List<int>();
            foreach (HoaDonChiTiet tk in GetsomethingInView(IdKh, ID_may))
            {
                Ma.Add(Convert.ToInt32(tk.IdChiTiet.Remove(0, 7)));
                idct = tk.IdChiTiet.Substring(0, 7);
            }
            for (int i = 0; i < Ma.Count; i++)
            {
                if (!Ma.Contains(i + 1)) return i + 1 < 10 ? idct+"00" + ++i : i + 1 < 100 ? idct+"0" + ++i : idct + ++i;
            }
            return Ma.Count + 1 < 10 ? idct+"00" + (Ma.Count + 1) : Ma.Count + 1 < 100 ? idct+ "0" + (Ma.Count + 1) : idct + (Ma.Count + 1);

        }
        public List<HoaDonChiTiet> GetsomethingInView(string idKH, string idMay)
        {
            //KH001+M01 = KH00101
            string keyWord= idKH.Substring(0, 5)+ idMay.Substring(1,2);
            List<HoaDonChiTiet> data = new List<HoaDonChiTiet>();
            data = db.HoaDonChiTiets.Where(p => p.IdChiTiet.Contains(keyWord)).Select(p => p).ToList();
            return data;
        }
        public void updatetongtien(string idct)
        {
            HoaDonChiTiet hdct = db.HoaDonChiTiets.Single(p => p.IdChiTiet == idct);
            
            hdct.TongTien = tien(idct);
            db.SaveChanges();
        }
        public int tien(string idct)
        {
            int tong = 0;
            foreach (ListTPham i in BllOrderKH.Instance.GetListTPByIDCT(""))
            {
                if (i.IdChiTiet == idct)
                {
                    tong += i.ThanhTien;
                }
            }
            return tong;
        }
        public string IDMAY(string idct)
        {
                string idm = "";
                foreach(HoaDonChiTiet i in GetListHDCTByID(""))
                {
                    if (i.IdChiTiet == idct)
                    {
                        idm = i.IdMay;
                        Console.WriteLine(idm);
                    }
                }
            return idm;
        }
        
       

    }
}
