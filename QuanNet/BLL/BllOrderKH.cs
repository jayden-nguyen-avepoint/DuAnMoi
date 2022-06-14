using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanNet.DTO;
using QuanNet.LinQ;

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
        public List<ListTPham> GetTPByIDTP(string IDTP)
        {
            List<ListTPham> data = new List<ListTPham>();
            if (IDTP == "")
            {
                data = db.ListTPhams.ToList();
            }
            else
            {
                data = db.ListTPhams.Where(p => p.IdTP == IDTP).Select(p => p).ToList();
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
                data = db.ListTPhams.Where(p => p.IdChiTiet == IDCT).Select(p => p).ToList();
            }
            return data;
        }
        public List<OrderKHView> GetListTPViewByIDCT(string IDCT)
        {
            List<OrderKHView> data = new List<OrderKHView>();
            foreach (ListTPham i in GetListTPByIDCT(IDCT))
            {
                data.Add(new OrderKHView
                {
                    Mon = i.TPham.TenTP,
                    SL = i.SoluongTP,
                    Tong = i.ThanhTien,
                });
            }
            return data;

        }
        public int TinhTienOrder(string idct)
        {

            int TienOrder = 0;
            foreach (ListTPham i in GetListTPByIDCT(idct))
            {
                TienOrder += i.ThanhTien;
            }
            return TienOrder;
        }
        public string MaListDoAn()
        {
            List<int> l = new List<int>();
            foreach (ListTPham tk in GetListTPByIDCT(""))
            {
                l.Add(Convert.ToInt32(tk.IdOrderList.Remove(0, 5)));
            }
            for (int i = 0; i < l.Count; i++)
            {
                if (!l.Contains(i + 1)) return i + 1 < 10 ? "Order00" + ++i : i + 1 < 100 ? "Order0" + ++i : "Order" + ++i;
            }
            return l.Count + 1 < 10 ? "Order00" + (l.Count + 1) : l.Count + 1 < 100 ? "Order0" + (l.Count + 1) : "Order" + (l.Count + 1);
        }
    }
}
