using HandLoomStoreModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandLoomStoreModels
{
   public class ItemTypeModel:Base<DateTime,int>
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int ItemPrice { get; set; }
        public int CategoryId { get; set; }

        public int ItemQuantity { get; set; }

    }
}
