using System;
using System.Collections.Generic;
using System.Text;
using BOL;
using BOL.Models;
using DAL.Abstract;
using DAL.Implementation;

namespace BLL.Db
{
    public class BasketDb
    {
        private readonly IBasketRepository db;

        public BasketDb(BookmakersContext context)
        {
            db = new BasketRepository(context);
        }

        public void Insert(Basket basket)
        {
            db.Insert(basket);
        }

        public Basket GetById(int id)
        {
            return db.GetById(id);
        }

        public IEnumerable<Basket> GetAll()
        {
            return db.GetAll();
        }

        public void Delete(int id)
        {
            db.Delete(id);
        }

        public void Update(Basket basket)
        {
            db.Update(basket);
        }
    }
}
