using Shop.IDal;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Shop.IBll
{
    public interface IBaseService<T> where T : class, new()
    {
        IDBSession CurrentDBSession { get; }

        IBaseDal<T> CurrentDal { get; set; }

        bool Delete(T model);

        T Insert(T model);

        IQueryable<T> Select(Expression<Func<T, bool>> whereLambda);

        IQueryable<T> SelectPage<s>(int pageIndex, int pageSize, out int totalCount, Expression<Func<T, bool>> whereLambda, Expression<Func<T, s>> orderbyLambda, bool isAsc);

        bool Update(T model);
    }
}
