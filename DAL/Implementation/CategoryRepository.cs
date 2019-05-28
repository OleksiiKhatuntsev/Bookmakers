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
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(BookmakersContext context) : base(context)
        { }
        public void Insert(Category category)
        {
            db.Entry(category).State = EntityState.Added;
            db.SaveChanges();
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories
                .Include(matches => matches.Matches)
                .ToList();
        }

        public Category GetById(int id)
        {
            return db.Categories.FirstOrDefault(x => x.CategoryId == id);
        }

        public void Delete(int id)
        {
            Category category = GetById(id);
            db.Entry(category).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public void Update(Category category)
        {
            db.Entry(category).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
