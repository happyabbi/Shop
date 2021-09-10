using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DalFactory
{
    //负责创建数据会话实例IDBSession，必须保证线程内唯一。
    public class DBSessionFactory
    {
        public static IDal.IDBSession CreateDBSession()
        {
            IDal.IDBSession dbSession = (IDal.IDBSession)CallContext.GetData("dbSession");
            if (dbSession == null)
            {
                dbSession = new DBSession();
                CallContext.SetData("dbSession", dbSession);
            }
            return dbSession;
        }
    }
}
