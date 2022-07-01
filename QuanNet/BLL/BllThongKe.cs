using QuanNet.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanNet.BLL
{
    public class BllThongKe
    {
        CyberManagerEntities db = new CyberManagerEntities();
        //public string ID_CT { get; set; }
        private static BllThongKe _Instance;
        public static BllThongKe Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BllThongKe();
                };
                return _Instance;
            }
            private set { }
        }
        private BllThongKe()
        {

        }
        public int GetSLHoaDonCT(int thang, int nam, string n)
        {
            int dem = 0;
            if (n == "h")
            {
                foreach (var i in BllHoaDon.Instance.GetListHDCTByID(""))
                {
                    dem++;
                }
            }
            if (n == "m")
            {
                foreach (var i in BllHoaDon.Instance.GetListHDCTByID(""))
                {
                    if (i.NgayThang.Month == thang && i.NgayThang.Year == nam)
                    {
                        dem++;
                    }
                }
            }
            if (n == "y")
            {
                foreach (var i in BllHoaDon.Instance.GetListHDCTByID(""))
                {
                    if (i.NgayThang.Year == nam)
                    {
                        dem++;
                    }
                }
            }
            if(n == "l7")
            {
                foreach (var i in BllHoaDon.Instance.GetListHDCTByID(""))
                {
                    if (i.NgayThang <= DateTime.Now && i.NgayThang >=DateTime.Now.AddDays(-7))
                    {
                        dem++;
                    }
                }
            }
            if (n == "l30")
            {
                foreach (var i in BllHoaDon.Instance.GetListHDCTByID(""))
                {
                    if (i.NgayThang <= DateTime.Now && i.NgayThang >= DateTime.Now.AddDays(-30))
                    {
                        dem++;
                    }
                }
            }

            return dem;
        }
        public int GetPriceHoaDonCT(int thang, int nam, string n)
        {
            int price = 0;
            if (n == "h")
            {
                foreach (var i in BllHoaDon.Instance.GetListHDCTByID(""))
                {
                    price += Convert.ToInt32(i.TongTien);
                }
            }
            if (n == "m")
            {
                foreach (var i in BllHoaDon.Instance.GetListHDCTByID(""))
                {
                    if (i.NgayThang.Month == thang && i.NgayThang.Year == nam)
                    {
                        price += Convert.ToInt32(i.TongTien);
                    }
                }
            }
            if (n == "y")
            {
                foreach (var i in BllHoaDon.Instance.GetListHDCTByID(""))
                {
                    if (i.NgayThang.Year == nam)
                    {
                        price += Convert.ToInt32(i.TongTien);
                    }
                }
            }
            if (n == "l7")
            {
                foreach (var i in BllHoaDon.Instance.GetListHDCTByID(""))
                {
                    if (i.NgayThang <= DateTime.Now && i.NgayThang >= DateTime.Now.AddDays(-7))
                    {
                        price += Convert.ToInt32(i.TongTien);
                    }
                }
            }
            if (n == "l30")
            {
                foreach (var i in BllHoaDon.Instance.GetListHDCTByID(""))
                {
                    if (i.NgayThang <= DateTime.Now && i.NgayThang >= DateTime.Now.AddDays(-30))
                    {
                        price += Convert.ToInt32(i.TongTien);
                    }
                }
            }
            return price;
        }
        public List<DashboardView> GetDoanhThuLoad()
        {
            List<DashboardView> list = new List<DashboardView>();
            foreach (HoaDonChiTiet i in BllHoaDon.Instance.GetListHDCTByID(""))
            {
                DashboardView db = new DashboardView();
                db.TongHoaDon = (int)(i.TongTien);
                db.Ngay = i.NgayThang;
                list.Add(db);
            }
            return list;
        }    
        

        public List<DashboardView> GetDoanhThuThisMonth(int thang, int nam)
        {
            List<DashboardView> list = new List<DashboardView>();
            foreach (HoaDonChiTiet i in BllHoaDon.Instance.GetListHDCTByID(""))
            {
                if (i.NgayThang.Month == thang && i.NgayThang.Year == nam)
                {
                    DashboardView db = new DashboardView();
                    db.TongHoaDon = (int)(i.TongTien);
                    db.Ngay = i.NgayThang;
                    list.Add(db);
                }
            }
            return list;
        }
        public DashboardView GetDoanhThuTungThang(int thang,int nam)
        {
            int money = 0;
            DashboardView db = new DashboardView();
            foreach (HoaDonChiTiet j in BllHoaDon.Instance.GetListHDCTByID(""))
            {
                if(j.NgayThang.Month== thang && j.NgayThang.Year == nam)
                {
                    money += Convert.ToInt32(j.TongTien);
                }    
            }
            db.Thang = "Th" + Convert.ToString(thang);
            db.TongHoaDon = money;
            return db;
        }
        public List<DashboardView> GetDoanhThuTungNgay(List<DashboardView> b)
        {
          
            List<DashboardView> list = new List<DashboardView>();
            List<DateTime> list1 = new List<DateTime>();
            List<DateTime> list2 = new List<DateTime>();

            foreach ( DashboardView i in b)
            {
                list1.Add(i.Ngay);
            }
            list2 = list1.Distinct().ToList();
            
            foreach ( DateTime i in list2)
            {
                DashboardView db = new DashboardView();
                int money = 0;
                foreach (DashboardView j in b)
                {
                    
                    if (j.Ngay.Year == i.Year && j.Ngay.Month == i.Month && j.Ngay.Day == i.Day )
                    {
                        money += j.TongHoaDon;                      
                    }
                      
                }
                db.Ngay = i;
                db.TongHoaDon = money;
                list.Add(db);
            }
            
            foreach (DashboardView i in list)
            {
                Console.WriteLine(i.Ngay);
                Console.WriteLine(i.TongHoaDon);
            }    
            return list;
        }
        public List<DashboardView> GetDoanhThuThisYear1()
        {
            List<DashboardView> list = new List<DashboardView>();
            for(int i = 1; i <= 12;i++)
            {
                DashboardView db = new DashboardView();
                db = GetDoanhThuTungThang(i, DateTime.Now.Year);
                list.Add(db);
            }
            return list;
        }
        public List<DashboardView> GetDoanhThuLast7Day()
        {
            List<DashboardView> list = new List<DashboardView>();
            foreach (HoaDonChiTiet i in BllHoaDon.Instance.GetListHDCTByID(""))
            {
                if (i.NgayThang <= DateTime.Now && i.NgayThang >= (DateTime.Now.AddDays(-7)))
                {
                    DashboardView db = new DashboardView();
                    db.TongHoaDon = (int)(i.TongTien);
                    db.Ngay = i.NgayThang;
                    list.Add(db);
                }
            }
            return list;
        }
        public List<DashboardView> GetDoanhThuLast30Day()
        {
            List<DashboardView> list = new List<DashboardView>();
            foreach (HoaDonChiTiet i in BllHoaDon.Instance.GetListHDCTByID(""))
            {
                if (i.NgayThang <= DateTime.Now && i.NgayThang >= (DateTime.Now.AddDays(-30)))
                {
                    DashboardView db = new DashboardView();
                    db.TongHoaDon = (int)(i.TongTien);
                    db.Ngay = i.NgayThang;
                    list.Add(db);
                }
            }
            return list;
        }
         public List<HoaDonView> GetListHDCTView_TheoThongKe(int nam,int thang,int m)
        {
            List<HoaDonView> list = new List<HoaDonView>();           
            if (m == 1)
            {
                foreach (HoaDonChiTiet i in BllHoaDon.Instance.GetListHDCTByID(""))
                {
                        if(i.NgayThang.Year== nam)
                    {
                        HoaDonView db = new HoaDonView();
                        db.ID_HoaDon = i.IdChiTiet;
                        db.May = i.IdMay;
                        db.NgayXuatHD = i.NgayThang;
                        db.Tong_Tien = Convert.ToString(i.TongTien);
                        list.Add(db);
                    }    
                } 
            }
            if (m == 2)
            {
                foreach (HoaDonChiTiet i in BllHoaDon.Instance.GetListHDCTByID(""))
                {
                    if (i.NgayThang.Year == nam && i.NgayThang.Month == thang)
                    {
                        HoaDonView db = new HoaDonView();
                        db.ID_HoaDon = i.IdChiTiet;
                        db.May = i.IdMay;
                        db.NgayXuatHD = i.NgayThang;
                        db.Tong_Tien = Convert.ToString(i.TongTien);
                        list.Add(db);
                    }
                }
            }
            if (m == 3)
            {
                foreach (HoaDonChiTiet i in BllHoaDon.Instance.GetListHDCTByID(""))
                {
                    if (i.NgayThang <= DateTime.Now && i.NgayThang >= DateTime.Now.AddDays(-30))
                    {
                        HoaDonView db = new HoaDonView();
                        db.ID_HoaDon = i.IdChiTiet;
                        db.May = i.IdMay;
                        db.NgayXuatHD = i.NgayThang;
                        db.Tong_Tien = Convert.ToString(i.TongTien);
                        list.Add(db);
                    }
                }
            }
            if (m == 4)
            {
                foreach (HoaDonChiTiet i in BllHoaDon.Instance.GetListHDCTByID(""))
                {
                    if (i.NgayThang <= DateTime.Now && i.NgayThang >= DateTime.Now.AddDays(-7))
                    {
                        HoaDonView db = new HoaDonView();
                        db.ID_HoaDon = i.IdChiTiet;
                        db.May = i.IdMay;
                        db.NgayXuatHD = i.NgayThang;
                        db.Tong_Tien = Convert.ToString(i.TongTien);
                        list.Add(db);
                    }
                }
            }
            if (m == 5)
            {
                foreach (HoaDonChiTiet i in BllHoaDon.Instance.GetListHDCTByID(""))
                {
                        HoaDonView db = new HoaDonView();
                        db.ID_HoaDon = i.IdChiTiet;
                        db.May = i.IdMay;
                        db.NgayXuatHD = i.NgayThang;
                        db.Tong_Tien = Convert.ToString(i.TongTien);
                        list.Add(db);                   
                }
            }
            return list;
        }
        public List<DashboardView>SortData(List<DashboardView> a)
        {            
            a.Sort((x, y) => DateTime.Compare(x.Ngay, y.Ngay));
            return a;
        }

    }         
}
