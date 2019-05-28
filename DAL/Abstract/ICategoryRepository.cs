using System;
using System.Collections.Generic;
using System.Text;
using BOL.Models;

namespace DAL.Abstract
{
    public interface ICategoryRepository
    {
        void Insert(Category category);
        IEnumerable<Category> GetAll();
        Category GetById(int id);
        void Delete(int id);
        void Update(Category category);
    }
}
