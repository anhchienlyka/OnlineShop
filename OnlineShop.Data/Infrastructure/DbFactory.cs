using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Infrastructure
{
   public class DbFactory :Disposable,IDbFactory
    {

        private OnlineShopDBContext dbContext;

        public OnlineShopDBContext Init()
        {
            return dbContext ?? (dbContext = new OnlineShopDBContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
