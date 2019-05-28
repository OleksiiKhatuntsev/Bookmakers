using System;
using System.Collections.Generic;
using System.Text;
using BOL.Models;

namespace DAL.Abstract
{
    public interface IOrderStatusRepository
    {
        void Insert(OrderStatus orderStatus);
        IEnumerable<OrderStatus> GetAll();
        OrderStatus GetById(int id);
        void Delete(int id);
        void Update(OrderStatus orderStatus);
    }
}
