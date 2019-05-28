using System;
using System.Collections.Generic;
using System.Text;
using BOL;
using BOL.Models;
using DAL.Abstract;
using DAL.Implementation;

namespace BLL.Db
{
    public class OrderDb
    {
        private readonly IOrderRepository db;

        public OrderDb(BookmakersContext context)
        {
            db = new OrderRepository(context);
        }

        public void Insert(Order order)
        {
            db.Insert(order);
        }

        public Order GetById(int id)
        {
            return db.GetById(id);
        }

        public IEnumerable<Order> GetAll()
        {
            return db.GetAll();
        }

        public void Delete(int id)
        {
            db.Delete(id);
        }

        public void Update(Order order)
        {
            db.Update(order);
        }
    }
}
