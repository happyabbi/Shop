using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shop.IDal
{
    public interface IBaseDal<T> where T : class, new()
    {
        IQueryable<T> Select(Expression<Func<T, bool>> whereLambda);

        IQueryable<T> SelectPage<s>(int pageIndex, int pageSize, out int totalCount, Expression<Func<T, bool>> whereLambda, Expression<Func<T, s>> orderbyLambda, bool isAsc);

        bool Delete(T model);

        bool Update(T model);

        T Insert(T model);
    }
}
