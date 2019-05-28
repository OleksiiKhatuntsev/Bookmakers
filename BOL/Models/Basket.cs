using System;
using System.Collections.Generic;
using System.Text;

namespace BOL.Models
{
    public class Basket
    {
        public int BasketId { get; set; }

        public int MatchId { get; set; }

        public Match Match { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}
