using System;
using System.Collections.Generic;
using System.Text;
using BOL;

namespace BLL.Db
{
    public class AllDb
    {
        public OrderDb OrderDb { get; set; }

        public OrderStatusDb OrderStatusDb { get; set; }

        public RoleDb RoleDb { get; set; }

        public MatchDb MatchDb { get; set; }

        public UserDb UserDb { get; set; }

        public CategoryDb CategoryDb { get; set; }

        public BasketDb BasketDb { get; set; }

        public AllDb(BookmakersContext context)
        {
            OrderDb = new OrderDb(context);
            OrderStatusDb = new OrderStatusDb(context);
            RoleDb = new RoleDb(context);
            MatchDb = new MatchDb(context);
            UserDb = new UserDb(context);
            CategoryDb = new CategoryDb(context);
            BasketDb = new BasketDb(context);
        }
    }
}