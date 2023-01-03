using Ciber.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciber.Domain.Entities
{
    public class Order:BaseEntity
    {
         public Order() {
            OrderDetails = new HashSet<OrderDetail>();
        }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int OrderAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; private set; }
    }
}
