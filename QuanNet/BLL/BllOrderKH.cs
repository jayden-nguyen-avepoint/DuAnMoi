using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanNet.DTO;

namespace QuanNet.BLL
{
    class BllOrderKH
    {
        DoAnQLCyber db = new DoAnQLCyber();
        private static BllOrderKH _Instance;
        public static BllOrderKH Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BllOrderKH();
                };
                return _Instance;
            }
            private set { }
        }
        private BllOrderKH()
        {

        }

        public void addOrder1(ListTPham list)
        {
            db.ListTPhams.Add(list);
            db.SaveChanges();
        }
        public string GetIDTP(string tenmon)
        {
            return db.TPhams.Where(p => p.TenTP == tenmon).First().IdTP;
        }
        public string Get(string idmay)
        {
                string id="";
                foreach (HoaDonChiTiet i in db.HoaDonChiTiets.ToList())
                {
                    if ( i.IdMay==idmay)
                    {
                        id=i.IdChiTiet;
                    }
                }
                return id;
        }
        public List<ListTPham> GetListTPByIDTP(string IDTP)
        {
            List<ListTPham> data = new List<ListTPham>();
            if (IDTP == "")
            {
                data = db.ListTPhams.ToList();
            }
            else
            {
                data = db.ListTPhams.Where(p => p.IdTP == IDTP.ToString()).Select(p => p).ToList();
            }
            return data;
        }
        public List<ListTPham> GetListTPByIDCT(string IDCT)
        {
            List<ListTPham> data = new List<ListTPham>();
            if (IDCT == "")
            {
                data = db.ListTPhams.ToList();
            }
            else
            {
                data = db.ListTPhams.Where(p => p.IdChiTiet == IDCT.ToString()).Select(p => p).ToList();
            }
            return data;
        }
        public List<OrderKHView> GetListTPViewByIDCT(string IDCT)
        {
            List<OrderKHView> data = new List<OrderKHView>();
            foreach (ListTPham i in GetListTPByIDCT(IDCT))
            {
                string tenmon = "";
                foreach (TPham j in db.TPhams.ToList())
                {
                    if (i.IdTP == j.IdTP)
                    {
                        tenmon = j.TenTP;
                    }
                }
                data.Add(new OrderKHView
                {
                    Mon = tenmon,
                    SL = i.SoluongTP,
                    Tong = i.ThanhTien,
                });
            }
            return data;

        }
        public List<CbbIDKH> GetCBB()
        {

            List<CbbIDKH> list = new List<CbbIDKH>();
            foreach (HoaDonChiTiet i in db.HoaDonChiTiets)
            {
                list.Add(new CbbIDKH
                {
                    Value = i.IdChiTiet,
                    Text = i.IdChiTiet
                });
            }
            return list;
        }
    }
}
