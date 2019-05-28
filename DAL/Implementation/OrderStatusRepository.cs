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
    public class OrderStatusRepository : BaseRepository, IOrderStatusRepository
    {
        public OrderStatusRepository(BookmakersContext context) : base(context)
        { }
        public void Insert(OrderStatus orderStatus)
        {
            db.Entry(orderStatus).State = EntityState.Added;
            db.SaveChanges();
        }

        public IEnumerable<OrderStatus> GetAll()
        {
            return db.OrderStatuses
                .Include(orders => orders.Orders)
                .ToList();
        }

        public OrderStatus GetById(int id)
        {
            return db.OrderStatuses.FirstOrDefault(x => x.OrderStatusId == id);
        }

        public void Delete(int id)
        {
            OrderStatus orderStatus = GetById(id);
            db.Entry(orderStatus).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public void Update(OrderStatus orderStatus)
        {
            db.Entry(orderStatus).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
