using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Dal
{
    public abstract class BaseDal<T> where T : class, new()
    {
        readonly DbContext Db = DBContextFactory.CreateDbcontext();

        public bool Delete(T model)
        {
            Db.Entry<T>(model).State = EntityState.Deleted;
            return true;
        }

        public T Insert(T model)
        {
            Db.Set<T>().Add(model);
            return model;
        }

        public IQueryable<T> Select(Expression<Func<T, bool>> whereLambda)
        {
            return Db.Set<T>().Where<T>(whereLambda);
        }

        public IQueryable<T> SelectPage<s>(int pageIndex, int pageSize, out int totalCount, Expression<Func<T, bool>> whereLambda, Expression<Func<T, s>> orderbyLambda, bool isAsc)
        {
            var temp = Db.Set<T>().Where<T>(whereLambda);
            totalCount = temp.Count();
            if (isAsc)
            {
                temp = temp.OrderBy<T, s>(orderbyLambda).Skip<T>((pageIndex - 1) * pageSize).Take<T>(pageSize);
            }
            else
            {
                temp = temp.OrderByDescending<T, s>(orderbyLambda).Skip<T>((pageIndex - 1) * pageSize).Take<T>(pageSize);
            }
            return temp;
        }

        public bool Update(T model)
        {
            Db.Entry<T>(model).State = EntityState.Modified;
            return true;
        }
    }
}
