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
        public int LastId()
        {
            int ma = 0;

            if (db.ListTPhams.FirstOrDefault() != null)
            {
                return Convert.ToInt32(db.ListTPhams.OrderByDescending(p => p.IdOrderList).FirstOrDefault().IdOrderList.Substring(5));
            }
            else
            {
                return (ma);
            }
        }
        public List<ListTPham> GetListTPByID()
        {
            List<ListTPham> data = new List<ListTPham>();            
            data = db.ListTPhams.ToList();               
            return data;
        }
        //public List<TPham> GetTPham()
        //{
        //    return db.TPhams.Find()
        //}    
        public List<OrderKH> GetListTPViewByID(string IDKH, string keyWord)
        {
            List<OrderKH> data = new List<OrderKH>();
            foreach (ListTPham i in GetListTPByID())
            {
                string tenmon = "";
                foreach (TPham j in db.TPhams.ToList())
                {
                    if(i.IdTP==j.IdTP)
                    {
                        tenmon = j.TenTP;
                    }    
                }
                if (i.IdOrderList.Contains(keyWord))
                    data.Add(new OrderKH
                    {
                        //ID_TaiKhoan = i.IdTK,
                        //TenKhachHang = i.TenKH,
                        //SoDu = i.Sodu,
                        //LienHe = i.LienHe,
                        //IdOrderList = i.IdOrderList,
                        Mon=tenmon,
                        SL = i.SoluongTP,
                        Tong = i.ThanhTien,
                });
               
                
            }
            return data;

        }

    }
}
