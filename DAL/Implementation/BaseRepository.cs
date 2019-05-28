using System;
using System.Collections.Generic;
using System.Text;
using BOL;

namespace DAL.Implementation
{
    public class BaseRepository
    {
        protected BookmakersContext db;

        public BaseRepository(BookmakersContext context)
        {
            db = context;
        }
    }
}
