using BOL;
using BOL.Models;
using DAL.Abstract;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DAL.Implementation
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(BookmakersContext context) : base(context)
        { }
        public void Insert(User user)
        {
            db.Entry(user).State = EntityState.Added;
            db.SaveChanges();
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users
                .Include(role => role.Role)
                .Include(order => order.Orders)
                .ToList();
        }

        public User GetById(string email)
        {
            return db.Users.FirstOrDefault(x => x.UserEmail == email);
        }

        public void Delete(string email)
        {
            User user = GetById(email);
            db.Entry(user).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public void Update(User user)
        {
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
