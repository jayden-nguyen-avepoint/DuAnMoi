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
    public class BllMayTinh
    {
        CyberManagerEntities db = new CyberManagerEntities();
        private static BllMayTinh _Instance;
        public static BllMayTinh Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BllMayTinh();
                };
                return _Instance;
            }
            private set { }
        }
        private BllMayTinh()
        {

        }
        public List<CbbIDKH> GetCBB()
        {

            List<CbbIDKH> list = new List<CbbIDKH>();
            foreach (May i in db.Mays)
            {
                list.Add(new CbbIDKH
                {
                    Value = i.IdMay,
                    Text = i.IdMay
                });
            }
            return list;
        }
        public May GetMayByIDMay(string IDMay)
        {
            return db.Mays.Find(IDMay);
            //return ve 1 record duy nhat
        }
        public List<May> GetListMayByID(string IDMay)
        {
            List<May> data = new List<May>();
            if (IDMay == "")
            {
                data = db.Mays.ToList();
            }
            else
            {
                data = db.Mays.Where(p => p.IdMay == IDMay.ToString()).Select(p => p).ToList();
            }
            return data;
        }
        public void addTKinMay(string IdMay, string IdKhach,string HoatDong)
        {
            try
            {
                May up = db.Mays.Find(IdMay);
                up.IdTK = IdKhach;
                if (up.IdTK != null)
                {
                    up.TrangThai = true;
                }
                else up.TrangThai = false;
                if (HoatDong != null)
                {
                    up.HoatDong = HoatDong.ToString();
                }
                else up.HoatDong = null;
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống", "Thông báo", MessageBoxButton.OK);
            }
        }
        public string GetIDTKbyMay(string idm)
        {
            string idtk = "";
            foreach (May i in GetListMayByID(""))
            {
                if (idm==i.IdMay)
                {
                    idtk = i.IdTK;                 
                }
            }
            return idtk;
        }
    }
}
