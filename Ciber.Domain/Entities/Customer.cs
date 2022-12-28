using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciber.Domain.Entities
{
    public class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string CustomerAddress { get; set; }
        public ICollection<Order> Orders { get; private set; }
    }
}
