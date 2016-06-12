using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        SPEAKContext dbContext;

        public SPEAKContext Init()
        {
            return dbContext ?? (dbContext = new SPEAKContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
