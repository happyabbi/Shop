using System;
using Microsoft.EntityFrameworkCore;
using Shop.IDal;

namespace Shop.DalFactory
{
    public class DBSession : IDBSession
    {
        public DbContext Db => throw new NotImplementedException();

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
