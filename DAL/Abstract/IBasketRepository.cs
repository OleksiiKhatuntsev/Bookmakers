using System;
using System.Collections.Generic;
using System.Text;
using BOL.Models;

namespace DAL.Abstract
{
    public interface IBasketRepository
    {
        void Insert(Basket basket);
        IEnumerable<Basket> GetAll();
        Basket GetById(int id);
        void Delete(int id);
        void Update(Basket basket);
    }
}
