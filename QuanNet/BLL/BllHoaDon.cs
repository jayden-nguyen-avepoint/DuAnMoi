using QuanNet.DTO;
using QuanNet.LinQ;
using QuanNet.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
                if (i.IdHoaDon.Contains(keyWord) || i.IdTK.Contains(keyWord) )
                {
                    data.Add(new HoaDonView
                    {
                        ID_HoaDon = i.IdHoaDon,
                        May = i.HoaDonChiTiet.IdMay,
                        NgayXuatHD = i.HoaDonChiTiet.NgayThang,
                        Tong_Tien =i.HoaDonChiTiet.TongTien.ToString()
                    });
                }
            }
            return data;
        }
        public dynamic SearchByDay(DateTime s, DateTime e)
        {
            return  db.HoaDons.Where(p => p.HoaDonChiTiet.NgayThang >= s && p.HoaDonChiTiet.NgayThang <= e).Select(p => new { ID_HoaDon=p.IdHoaDon,p.IdTK, p.HoaDonChiTiet.NgayThang, p.TaiKhoan.TenKH, p.HoaDonChiTiet.TongTien }).ToList();
        }
        public dynamic Sort(int i)
        {
            if (i == 0)
            {
                return (db.HoaDons.Select(p => new { ID_HoaDon=p.IdHoaDon, p.HoaDonChiTiet.NgayThang, p.TaiKhoan.TenKH, p.HoaDonChiTiet.TongTien }).OrderBy(p => p.TenKH)).ToList();
            }
            else if (i == 1)
            {
                return (db.HoaDons.Select(p => new { ID_HoaDon=p.IdHoaDon, p.IdTK, p.HoaDonChiTiet.NgayThang, p.TaiKhoan.TenKH, p.HoaDonChiTiet.TongTien }).OrderBy(p => p.NgayThang)).ToList();
            }
            else
            {
                return (db.HoaDons.Select(p => new { p.IdHoaDon, p.IdTK, p.HoaDonChiTiet.NgayThang, p.TaiKhoan.TenKH ,p.HoaDonChiTiet.TongTien}).OrderBy(p => p.TongTien)).ToList();
            }

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
        public bool checkVal(string id)
        {
            bool k = true;
            int dem = 0;
            foreach (HoaDon s in db.HoaDons)
            {
                if (s.IdChiTiet == id)
                {
                    dem++;
                }   
            }
            if (dem == 0)
            {
                k = true;
                //true là ko có tồn tại
            }else
            {
                k = false;
                //false là đã tồn tại
            }
            return k;
        }
        public string MaHoaDon()
        {
            List<int> l = new List<int>();
            foreach (HoaDon hd in GetListHDByID(""))
            {
                l.Add(Convert.ToInt32(hd.IdHoaDon.Remove(0, 4)));

            }
            for (int i = 0; i < l.Count; i++)
            {
                if (!l.Contains(i + 1)) return i + 1 < 10 ? "Bill00" + ++i : i + 1 < 100 ? "Bill0" + ++i : "Bill" + ++i;
            }
            return l.Count + 1 < 10 ? "Bill00" + (l.Count + 1) : l.Count + 1 < 100 ? "Bill0" + (l.Count + 1) : "Bill" +
                +(l.Count + 1);
        }
        //=======================Hóa đơn chi tiết============================================
        public void DeleteHDCT(string ID)
        {
            HoaDonChiTiet s = db.HoaDonChiTiets.Find(ID);
            db.HoaDonChiTiets.Remove(s);
            db.SaveChanges();
        }
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
        public List<OrderAdView> GetOrderAd(string Id, DateTime s)
        {
            List<OrderAdView> dt = new List<OrderAdView>();
            bool TT;
            foreach (HoaDonChiTiet i in GetListHDCTByID(Id))
            {
                if (checkVal(i.IdChiTiet))
                {
                    TT=false;
                }else TT=true;
                if(i.NgayThang.Date == s)
                {
                    dt.Add(new OrderAdView
                    {
                        IdChiTiet = i.IdChiTiet,
                        TongTien = i.TongTien,
                        IdMay = i.IdMay,
                        Trang_thai = TT

                    }) ;
                }
            }
            return dt;
        }
        public string CreateIDCT(string IdKh, string ID_may)
        {
            string idct= IdKh.Substring(0, 5) + ID_may.Substring(1, 2);
            List<int> Ma = new List<int>();
            foreach (HoaDonChiTiet tk in GetMaKHvaMaMay(IdKh, ID_may))
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
        public List<HoaDonChiTiet> GetMaKHvaMaMay(string idKH, string idMay)
        {
            //KH001+M01 = KH00101
            string keyWord= idKH.Substring(0, 5)+ idMay.Substring(1,2);
            List<HoaDonChiTiet> data = new List<HoaDonChiTiet>();
            data = db.HoaDonChiTiets.Where(p => p.IdChiTiet.Contains(keyWord)).Select(p => p).ToList();
            return data;
        }
        public void updatetongtien(string idct)
        {
            HoaDonChiTiet hdct = GetHoadonCTByID(idct);
            if (tien(idct) != 0)
            {
                hdct.TongTien = tien(idct);
                db.SaveChanges();
            }
            else
            {
                db.HoaDonChiTiets.Remove(GetHoadonCTByID(idct));
                db.SaveChanges();
            }
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
        public dynamic GetHDCTDay(DateTime s)
        {
            return db.HoaDonChiTiets.Where(p=>p.NgayThang == s).Select(p => p).ToList();
        }
    }
}
// Test merge code 