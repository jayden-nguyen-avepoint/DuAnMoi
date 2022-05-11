using QuanNet.DTO;
using QuanNet.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanNet.BLL
{
    public class BllQLy
    {
        DoAnQLNet db = new DoAnQLNet();
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
        public TaiKhoan GetIDTKCuoi()
        {
            return db.TaiKhoans.OrderByDescending(shipper => shipper.IdTK).FirstOrDefault();
        }
        public TaiKhoan GetTKByIDTK(string IDTK)
        {
            return db.TaiKhoans.Find(IDTK);
            //return ve 1 record duy nhat
        }
        public List<TaiKhoanView> GetTKViewByIDKH(string IDKH)
        {
            List<TaiKhoanView> data = new List<TaiKhoanView>();
            foreach (TaiKhoan i in GetTKByIDTKS(IDKH))
            {
                data.Add(new TaiKhoanView
                {
                    ID_TaiKhoan = i.IdTK,
                    TenKhachHang = i.TenKH,
                    SoDu = i.Sodu,
                    LienHe = i.LienHe,
                });
            }
            return data;

        }
        public List<TaiKhoan> GetTKByIDTKS(string IDTK)
        {
            List<TaiKhoan> data = new List<TaiKhoan>();
            if (IDTK == "")
            {
                data = db.TaiKhoans.ToList();
            }
            else
            {
                data = db.TaiKhoans.Where(p => p.IdTK == IDTK.ToString()).Select(p => p).ToList();
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
            //true-update.....false-add
        }
        public void Add(TaiKhoan s)
        {
            if (s != null)
            {
                if (!CheckAddUpdate(s.IdTK))
                {
                    db.TaiKhoans.Add(s);
                    db.SaveChanges();
                }
                else MessageBox.Show("Trùng ID, vui lòng nhập lại hoặc sửa chữa", "Thông báo !", MessageBoxButton.OK);
            }
        }  
        public void Edit(TaiKhoan s)
        {
            if (CheckAddUpdate(s.IdTK))
            {
                TaiKhoan upd = db.TaiKhoans.Find(s.IdTK);
                upd.TenDN = s.TenDN;
                upd.IdTK = s.IdTK;
                upd.MatKhau = s.MatKhau;
                upd.LienHe = s.LienHe;
                upd.Sodu = s.Sodu;
                upd.TenKH = s.TenKH;
                db.SaveChanges();
            }else
            MessageBox.Show("Ko trùng ID, vui lòng nhập lại hoặc thêm mới", "Thông báo !", MessageBoxButton.OK);
        }
        public void DeleteKH(string IDTK)
        {
            TaiKhoan s = db.TaiKhoans.Find(IDTK);
            db.TaiKhoans.Remove(s);
            db.SaveChanges();
        }
        public dynamic SearchKH(string keyWord)
        {
            return db.TaiKhoans.Where(p => p.IdTK.Contains(keyWord) || p.LienHe.Contains(keyWord) || p.TenKH.Contains(keyWord)).Select(p => new {ID_TaiKhoan= p.IdTK , TenKhachHang=p.TenKH, p.Sodu, p.LienHe }).ToList();
        }
        //===========================================================
        //=================Máy Tính==================================
        public May GetMayByIDMay(string IDMay)
        {
            return db.Mays.Find(IDMay);
            //return ve 1 record duy nhat
        }
    }
}
