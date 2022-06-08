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
    public class BllKhachHang
    {
        DoAnQLCyber db = new DoAnQLCyber();
        private static BllKhachHang _Instance;
        public static BllKhachHang Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BllKhachHang();
                };
                return _Instance;
            }
            private set { }
        }
        private BllKhachHang()
        {

        }
        public TaiKhoan GetTKByIDTK(string IDTK)
        {
            return db.TaiKhoans.Find(IDTK);
            //return ve 1 record duy nhat
        }
        public List<TaiKhoanView> GetTKViewByIDKH(string IDKH,string keyWord)
        {
            List<TaiKhoanView> data = new List<TaiKhoanView>();
            foreach (TaiKhoan i in GetListTKByIDTK(IDKH))
            {
                if (i.IdTK.Contains(keyWord) || i.LienHe.Contains(keyWord)|| i.TenKH.Contains(keyWord))
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
        public List<TaiKhoan> GetListTKByIDTK(string IDTK)
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
        public string GetIDTKByUSERNAME(string TenDN)
        {
            string ID = "";
            List<TaiKhoan> data = new List<TaiKhoan>();
            data = db.TaiKhoans.Where(p => p.TenDN == TenDN.ToString()).Select(p => p).ToList();
            
            foreach (TaiKhoan t in GetListTKByIDTK(""))
            {
                if (TenDN == t.TenDN)
                {
                    ID = t.IdTK;
                }                
            }
            return ID;
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
        public dynamic Sort(int index)
        {
            if (index == 0)
            {
                return db.TaiKhoans.Select(p => new { p.IdTK, p.TenKH, p.Sodu, p.LienHe }).ToList();
            }

             else  if (index == 1)
            {
                return (db.TaiKhoans.Select(p => new { p.IdTK,p.TenKH,p.Sodu,p.LienHe }).OrderBy(p => p.IdTK)).ToList();
            }
            else 
            {
                return (db.TaiKhoans.Select(p => new { p.IdTK, p.TenKH, p.Sodu, p.LienHe }).OrderBy(p => p.TenKH)).ToList();
            }

        }
        public void DeleteKH(string IDTK)
        {
            TaiKhoan s = db.TaiKhoans.Find(IDTK);
            db.TaiKhoans.Remove(s);
            db.SaveChanges();
        }
        
    }
}
