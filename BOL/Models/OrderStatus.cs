using System;
using System.Collections.Generic;
using System.Text;

namespace BOL.Models
{
    public class OrderStatus
    {
        public int OrderStatusId { get; set; }

        public string OrderStatusName { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
