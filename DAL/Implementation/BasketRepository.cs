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
    public class BasketRepository : BaseRepository, IBasketRepository
    {
        public BasketRepository(BookmakersContext context) : base(context)
        { }
        public void Insert(Basket basket)
        {
            db.Entry(basket).State = EntityState.Added;
            db.SaveChanges();
        }

        public IEnumerable<Basket> GetAll()
        {
            return db.Baskets
                .Include(match => match.Match)
                .Include(order => order.Order)
                .ToList();
        }

        public Basket GetById(int id)
        {
            return db.Baskets.FirstOrDefault(x => x.BasketId == id);
        }

        public void Delete(int id)
        {
            Basket basket = GetById(id);
            db.Entry(basket).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public void Update(Basket basket)
        {
            db.Entry(basket).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
