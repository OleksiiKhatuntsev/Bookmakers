using System;
using System.Collections.Generic;
using System.Text;

namespace BOL.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public ICollection<Match> Matches { get; set; }
    }
}
