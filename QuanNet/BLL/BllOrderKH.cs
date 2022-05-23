using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
            //db.ListTPhams.Add(list);
            //db.SaveChanges();
            try
            {
                db.ListTPhams.Add(list);
                db.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting  
                        // the current instance as InnerException  
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }
        public string GetIDTP(string tenmon)
        {
            return db.TPhams.Where(p => p.TenTP == tenmon).First().IdTP;
        }
        public List<ListTPham> GetListTPByID()
        {
            List<ListTPham> data = new List<ListTPham>();            
            data = db.ListTPhams.ToList();               
            return data;
        }
    
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
                        Mon=tenmon,
                        SL = i.SoluongTP,
                        Tong = i.ThanhTien,
                });
               
                
            }
            return data;

        }
        //public string GetIdChitiet(string idmay)
        //{
        //    return;
        //}





    }
}
