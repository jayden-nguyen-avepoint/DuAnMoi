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
    public class BllKhachHang
    {
        CyberManagerEntities db = new CyberManagerEntities();
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
        public List<TaiKhoan> GetListTKByIDTK(string IDTK)
        {
            List<TaiKhoan> data = new List<TaiKhoan>();
            if (IDTK == "")
            {
                data = db.TaiKhoans.ToList();
            }
            else
            {
                data = db.TaiKhoans.Where(p => p.IdTK == IDTK).Select(p => p).ToList();
            }
            return data;
        }
        public List<TaiKhoanView> GetView(string id, string keyWord)
        {
            return db.TaiKhoans.Where(p => p.IdTK.Contains(id) && (p.IdTK.Contains(keyWord)||p.TenKH.Contains(keyWord)|| p.LienHe.Contains(keyWord))).Select(p => new TaiKhoanView { ID_TaiKhoan = p.IdTK,TenKhachHang = p.TenKH,SoDu = p.Sodu,LienHe = p.LienHe}).ToList();
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
        public void AddorUpdate(TaiKhoan s)
        {
            try
            {
                if (s != null)
                {
                    if (!CheckAddUpdate(s.IdTK))
                    {
                        db.TaiKhoans.Add(s);
                        db.SaveChanges();
                    }
                    else if (CheckAddUpdate(s.IdTK))
                    {
                        TaiKhoan upd = db.TaiKhoans.Find(s.IdTK);
                        upd.TenDN = s.TenDN;
                        upd.IdTK = s.IdTK;
                        upd.MatKhau = s.MatKhau;
                        upd.LienHe = s.LienHe;
                        upd.Sodu = s.Sodu;
                        upd.TenKH = s.TenKH;
                        db.SaveChanges();
                    }
                    else MessageBox.Show("Vui lòng nhập lại hoặc sửa chữa", "Thông báo !", MessageBoxButton.OK);
                }
                else MessageBox.Show("Vui lòng nhập lại hoặc sửa chữa", "Thông báo !", MessageBoxButton.OK);
            }catch
            {
                 MessageBox.Show("Không thể thêm khách hàng này, vui lòng nhập lại", "Thông báo !", MessageBoxButton.OK);
            }
        }  
        public List<TaiKhoanView> Sort(int index)
        {
            if (index == 0)
            {
                return db.TaiKhoans.Select(p => new TaiKhoanView { ID_TaiKhoan= p.IdTK, TenKhachHang= p.TenKH, SoDu= p.Sodu, LienHe= p.LienHe }).ToList();
            }

             else  if (index == 1)
            {
                return (db.TaiKhoans.Select(p => new TaiKhoanView { ID_TaiKhoan= p.IdTK, TenKhachHang=p.TenKH, SoDu= p.Sodu, LienHe=p.LienHe }).OrderBy(p => p.ID_TaiKhoan)).ToList();
            }
            else  if(index == 2)
            {
                return (db.TaiKhoans.Select(p => new TaiKhoanView { ID_TaiKhoan= p.IdTK, TenKhachHang= p.TenKH, SoDu= p.Sodu, LienHe=p.LienHe }).OrderBy(p => p.TenKhachHang)).ToList();
            }
            else return (db.TaiKhoans.Select(p => new TaiKhoanView { ID_TaiKhoan = p.IdTK, TenKhachHang = p.TenKH, SoDu = p.Sodu, LienHe = p.LienHe }).OrderBy(p => p.SoDu)).ToList();

        }
        public void DeleteKH(string IDTK)
        {
                    try
                    {
                        TaiKhoan s = db.TaiKhoans.Find(IDTK);
                        db.TaiKhoans.Remove(s);
                        db.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa khách hàng này", "Thông báo !", MessageBoxButton.OK);
                    }      
        }
        
    }
}
