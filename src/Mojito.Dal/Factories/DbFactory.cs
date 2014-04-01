using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.OrmLite;

namespace Mojito.Dal.Factories
{
    public static class DbFactory
    {
        public static OrmLiteConnectionFactory GetClient()
        {
            return new OrmLiteConnectionFactory("Data Source=.\\SQLEXPRESS;Initial Catalog=mojito;Integrated Security=True", SqlServerDialect.Provider);
        }
    }
}
