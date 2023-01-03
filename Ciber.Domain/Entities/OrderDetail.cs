
using Ciber.Domain.Common;

namespace Ciber.Domain.Entities
{
    public class OrderDetail : BaseEntity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
          
    }
}