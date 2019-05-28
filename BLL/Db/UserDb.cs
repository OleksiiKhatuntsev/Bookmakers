using System;
using System.Collections.Generic;
using System.Text;
using BOL;
using BOL.Models;
using DAL.Abstract;
using DAL.Implementation;

namespace BLL.Db
{
    public class UserDb
    {
        private readonly IUserRepository db;

        public UserDb(BookmakersContext context)
        {
            db = new UserRepository(context);
        }

        public void Insert(User user)
        {
            db.Insert(user);
        }

        public User GetById(string email)
        {
            return db.GetById(email);
        }

        public IEnumerable<User> GetAll()
        {
            return db.GetAll();
        }

        public void Delete(string email)
        {
            db.Delete(email);
        }

        public void Update(User user)
        {
            db.Update(user);
        }
    }
}