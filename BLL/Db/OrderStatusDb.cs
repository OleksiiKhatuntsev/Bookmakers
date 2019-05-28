using System;
using System.Collections.Generic;
using System.Text;
using BOL;
using BOL.Models;
using DAL.Abstract;
using DAL.Implementation;

namespace BLL.Db
{
    public class OrderStatusDb
    {
        private readonly IOrderStatusRepository db;

        public OrderStatusDb(BookmakersContext context)
        {
            db = new OrderStatusRepository(context);
        }

        public void Insert(OrderStatus orderStatus)
        {
            db.Insert(orderStatus);
        }

        public OrderStatus GetById(int id)
        {
            return db.GetById(id);
        }

        public IEnumerable<OrderStatus> GetAll()
        {
            return db.GetAll();
        }

        public void Delete(int id)
        {
            db.Delete(id);
        }

        public void Update(OrderStatus orderStatus)
        {
            db.Update(orderStatus);
        }
    }
}
