using QuanNet.DTO;
using QuanNet.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanNet.BLL
{
    public class BllQLy
    {
        DoAnEntity db = new DoAnEntity();
        private static BllQLy _Instance;
        public static BllQLy Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BllQLy();
                };
                return _Instance;
            }
            private set { }
        }
        private BllQLy()
        {

        }
        public List<CBBitemSort> GetCBB()
        {

            List<CBBitemSort> list = new List<CBBitemSort>();
            foreach (KhachHang i in db.KhachHangs)
            {
                list.Add(new CBBitemSort
                {
                    Value = i.IdKH,
                    Text = i.TenKH
                });
            }
            return list;
        }
        public TaiKhoan GetTKByIDTK(string IDTK)
        {
            foreach (TaiKhoan i in db.TaiKhoans)
            {
                if (i.IdTK == IDTK) return i;
            }
            return null;
        }
        public List<TaiKhoanView> GetTKViewByIDKH(int IDKH)
        {
            List<TaiKhoanView> data = new List<TaiKhoanView>();
            foreach (TaiKhoan i in GetTKByIDKH(IDKH))
            {
                string TenKH = "";
                string lienHe = "";
                foreach (KhachHang j in db.KhachHangs.ToList())
                {
                    if (j.IdKH == i.IdKH)
                    {
                        TenKH = j.TenKH;
                        lienHe= j.LienHe;
                        break;
                    }
                }
                data.Add(new TaiKhoanView
                {   
                     ID_TaiKhoan =i.IdTK,
                     TenKhachHang=TenKH, 
                     SoDu=i.Sodu,
                     LienHe=lienHe,
                });
            }
            return data;

        }
        public List<TaiKhoan> GetTKByIDKH(int IDKH)
        {
            List<TaiKhoan> data = new List<TaiKhoan>();
            if (IDKH == 0)
            {
                data = db.TaiKhoans.ToList();
            }
            else
            {
                data = db.TaiKhoans.Where(p => p.IdKH == IDKH).Select(p => p).ToList();
            }
            return data;
        }
        public bool CheckAddUpdate(string IDTK)
        {
            foreach (TaiKhoan i in db.TaiKhoans)
            {
                if (i.IdTK == IDTK) return true;
            }
            return false;
        }
        public void GUI()
        {

        }
        public void Execute(TaiKhoan s)
        {
            if (!CheckAddUpdate(s.IdTK))
            {
                db.TaiKhoans.Add(s);
                db.SaveChanges();
                
            }
            else
            {
                TaiKhoan upd = db.TaiKhoans.Find(s.IdTK);
                upd.TenDN = s.TenDN;
                upd.MatKhau = s.MatKhau;
                upd.Sodu = s.Sodu;
                upd.IdKH = s.IdKH;
                db.SaveChanges();
            }
        }
        public void DeleteKH(string IDTK)
        {
            TaiKhoan s = db.TaiKhoans.Find(IDTK);
            db.TaiKhoans.Remove(s);
            db.SaveChanges();
        }
        //public List<TaiKhoanView> SearchTK(string text)
        //{
        //    var result = from p in db.TaiKhoanView
        //                 where p.IdTK.Contains(text)
        //                 select p;
        //    return result.ToList();
        //}
    }
}
