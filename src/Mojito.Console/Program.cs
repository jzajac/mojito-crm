using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mojito.Dal.Models;
using Mojito.Dal.Repository;
using ServiceStack.OrmLite;

namespace Mojito.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            Options opts = new Options();

            // Parse arguments and set values of Options object 
            CommandLine.Parser.Default.ParseArguments(args, opts);

            if (opts.SetupDatabase || !opts.SetupDatabase)
            {
                OrmLiteConnectionFactory conn = Dal.Factories.DbFactory.GetClient();

                using (IDbConnection db = conn.OpenDbConnection())
                {
                    db.CreateTables(true, typeof(Contact));
                }
            }
        }
    }
}
