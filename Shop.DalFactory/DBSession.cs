using System;
using Microsoft.EntityFrameworkCore;
using Shop.Dal;
using Shop.IDal;

namespace Shop.DalFactory
{
    public class DBSession : IDBSession
    {
        public DbContext Db
        {
            get
            {
                return DBContextFactory.CreateDbcontext();
            }
        }

        public bool SaveChanges()
        {
            return Db.SaveChanges() > 0;
        }
    }
}
