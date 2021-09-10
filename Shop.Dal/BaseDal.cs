using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Dal
{
    public abstract class BaseDal<T> where T : class, new()
    {
        readonly DbContext Db = DBContextFactory.CreateDbcontext();

    }
}
