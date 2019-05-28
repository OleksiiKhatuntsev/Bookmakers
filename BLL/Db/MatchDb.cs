using System;
using System.Collections.Generic;
using System.Text;
using BOL;
using BOL.Models;
using DAL.Abstract;
using DAL.Implementation;

namespace BLL.Db
{
    public class MatchDb
    {
        private readonly IMatchRepository db;

        public MatchDb(BookmakersContext context)
        {
            db = new MatchRepository(context);
        }

        public void Insert(Match match)
        {
            db.Insert(match);
        }

        public Match GetById(int id)
        {
            return db.GetById(id);
        }

        public IEnumerable<Match> GetAll()
        {
            return db.GetAll();
        }

        public void Delete(int id)
        {
            db.Delete(id);
        }

        public void Update(Match match)
        {
            db.Update(match);
        }
    }
}
