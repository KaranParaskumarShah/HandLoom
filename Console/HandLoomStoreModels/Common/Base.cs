using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandLoomStoreModels.Common
{
  public class Base<T,V>
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
        public V OperationId { get; set; }
        public string OperationName { get; set; }

    }
}
