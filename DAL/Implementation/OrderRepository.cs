using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BOL;
using BOL.Models;
using DAL.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DAL.Implementation
{
    public class OrderRepository : BaseRepository, IOrderRepository
    {
        public OrderRepository(BookmakersContext context) : base(context)
        { }
        public void Insert(Order order)
        {
            db.Entry(order).State = EntityState.Added;
            db.SaveChanges();
        }

        public IEnumerable<Order> GetAll()
        {
            return db.Orders
                .Include(user => user.User)
                .Include(orderStatus => orderStatus.OrderStatus)
                .ToList();
        }

        public Order GetById(int id)
        {
            return db.Orders.FirstOrDefault(x => x.OrderId == id);
        }

        public void Delete(int id)
        {
            Order order = GetById(id);
            db.Entry(order).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public void Update(Order order)
        {
            db.Entry(order).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
