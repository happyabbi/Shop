using Microsoft.EntityFrameworkCore;
using Shop.Model;
using System.Collections.Concurrent;
using System.Threading;

namespace Shop.Dal
{
    //负责创建EF数据操作上下文实例，必须保证线程内唯一。
    public class DBContextFactory
    {
        public static DbContext CreateDbcontext()
        {
            DbContext dbContext = (DbContext)CallContext.GetData("dbContext");
            if (dbContext == null)
            {
                dbContext = new ShopEntities();
                CallContext.SetData("dbContext", dbContext);
            }
            return dbContext;
        }
    }
    public static class CallContext
    {
        static ConcurrentDictionary<string, AsyncLocal<object>> state = new ConcurrentDictionary<string, AsyncLocal<object>>();
        public static void SetData(string name, object data) =>
            state.GetOrAdd(name, _ => new AsyncLocal<object>()).Value = data;

        public static object GetData(string name) =>
            state.TryGetValue(name, out AsyncLocal<object> data) ? data.Value : null;
    }
}
