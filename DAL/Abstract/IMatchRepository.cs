using System;
using System.Collections.Generic;
using System.Text;
using BOL.Models;

namespace DAL.Abstract
{
    public interface IMatchRepository
    {
        void Insert(Match match);
        IEnumerable<Match> GetAll();
        Match GetById(int id);
        void Delete(int id);
        void Update(Match match);
    }
}
