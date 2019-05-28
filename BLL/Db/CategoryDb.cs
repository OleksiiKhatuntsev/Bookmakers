using System;
using System.Collections.Generic;
using System.Text;
using BOL;
using BOL.Models;
using DAL.Abstract;
using DAL.Implementation;

namespace BLL.Db
{
    public class CategoryDb
    {
        private readonly ICategoryRepository db;

        public CategoryDb(BookmakersContext context)
        {
            db = new CategoryRepository(context);
        }

        public void Insert(Category category)
        {
            db.Insert(category);
        }

        public Category GetById(int id)
        {
            return db.GetById(id);
        }

        public IEnumerable<Category> GetAll()
        {
            return db.GetAll();
        }

        public void Delete(int id)
        {
            db.Delete(id);
        }

        public void Update(Category category)
        {
            db.Update(category);
        }
    }
}
