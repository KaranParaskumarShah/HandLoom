using HandLoomStoreModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandLoomStoreModels
{
  public class BillModel:Base<DateTime,int>
    {
        public int BillId { get; set; }
        public int ClientId{get;set; }
        public int ItemId {get;set; }
        public int  PurchasingItemQuantity{get;set; }
        public int  PaymentId{get;set; }
        public int  TotalBill{get;set; }

        



      
    }
}
