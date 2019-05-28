using System;
using System.Collections.Generic;
using System.Text;
using BOL.Models;

namespace DAL.Abstract
{
    public interface IUserRepository
    {
        void Insert(User user);
        IEnumerable<User> GetAll();
        User GetById(string email);
        void Delete(string email);
        void Update(User user);
    }
}
