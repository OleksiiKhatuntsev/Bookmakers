using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BOL;
using BOL.Models;
using DAL.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DAL.Implementation
{
    public class MatchRepository : BaseRepository, IMatchRepository
    {
        public MatchRepository(BookmakersContext context) : base(context)
        { }
        public void Insert(Match match)
        {
            db.Entry(match).State = EntityState.Added;
            db.SaveChanges();
        }

        public IEnumerable<Match> GetAll()
        {
            return db.Matches
                .Include(category => category.Category)
                .Include(baskets => baskets.Baskets)
                .ToList();
        }

        public Match GetById(int id)
        {
            return db.Matches.FirstOrDefault(x => x.MatchId == id);
        }

        public void Delete(int id)
        {
            Match match = GetById(id);
            db.Entry(match).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public void Update(Match match)
        {
            db.Entry(match).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
