using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BOL.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [ForeignKey("User")]
        public string UserEmail { get; set; }

        public User User { get; set; }

        public decimal Sum { get; set; }

        public int Prize { get; set; }

        public int Scores { get; set; }

        public int OrderStatusId { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public ICollection<Basket> Baskets { get; set; }
    }
}
