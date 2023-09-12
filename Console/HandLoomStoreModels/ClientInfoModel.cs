using HandLoomStoreModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandLoomStoreModels
{
    public class ClientInfoModel:Base<DateTime,int>
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientNumber { get; set; }
        public string ClientEmail { get; set; }
        public string ClientPassword { get; set; }
        public DateTime ClientDOB { get; set; }
      
        public int ClientGenderId { get; set; }
        public int PaymentTypeId { get; set; }
        //public int OperationTypeId { get; set; }

        
        

    }
}
