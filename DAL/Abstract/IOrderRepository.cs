using System;
using System.Collections.Generic;
using System.Text;
using BOL.Models;

namespace DAL.Abstract
{
    public interface IOrderRepository
    {
        void Insert(Order order);
        IEnumerable<Order> GetAll();
        Order GetById(int id);
        void Delete(int id);
        void Update(Order order);
    }
}
