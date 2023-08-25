using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandLoomStoreModels.Common
{
  public class Base<T>
    {
        public T CreatedOn
        {
            get;set;
        }
        public T ModifiedOn
        {
            get;
            set;
        }
    }
}
