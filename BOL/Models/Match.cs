using System;
using System.Collections.Generic;
using System.Text;

namespace BOL.Models
{
    public class Match
    {
        public int MatchId { get; set; }

        public string MatchName { get; set; }

        public DateTime DateOfOccur { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public double CoefficientOfWin { get; set; }

        public double CoefficientOfLose { get; set; }

        public string Teams { get; set; }

        public int Score { get; set; }

        public int Flag { get; set; }

        public ICollection<Basket> Baskets { get; set; }
    }
}
