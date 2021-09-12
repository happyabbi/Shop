using Microsoft.EntityFrameworkCore;
using System;

namespace Shop.IDal
{
    public interface IDBSession
    {
        DbContext Db { get; }

        bool SaveChanges();


        IStudentDal StudentDal { get; set; }
    }
}
