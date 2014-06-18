using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My2AccountsInAGlance.Model
{
    public class Order
    {
        public int Id { get; set; }
        public decimal NumberOfShares { get; set; }
        public decimal Price { get; set; }
        public int OrderTypeId { get; set; }
        public int SecurityId { get; set; }
        public int BrokerageAccountId { get; set; }

        //Navigation
        public virtual BrokerageAccount BrokerageAccount { get; set; }
        public virtual Security Security { get; set; }
        public virtual OrderType OrderType { get; set; }
    }
}
