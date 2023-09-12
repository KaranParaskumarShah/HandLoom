using HandLoomStoreModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandLoomStoreModels
{
   public class CategoryModel:Base<DateTime,int>
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
