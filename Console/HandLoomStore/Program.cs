using HLS.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandLoomStoreConsole
{
  public  class Program
    {
        public static void Main(string[] args)
        {
            ModelDataInsert objInset = new ModelDataInsert();
            objInset.InsertStoreProceClientInfo();
            objInset.InsertStoreProGender();
            objInset.InsertStoreProPayment();
            objInset.InsertStoreProOperation();
            objInset.InsertStoreProItemType();
            objInset.InsertStoreProCategory();
            objInset.InsertStoreProBill();


            Console.ReadKey();
        }
    }
}
