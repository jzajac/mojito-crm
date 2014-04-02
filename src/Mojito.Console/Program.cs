using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            if (opts.SetupDatabase)
            {
                OrmLiteConnectionFactory conn = Dal.Factories.DbFactory.GetClient();

                using (IDbConnection db = conn.OpenDbConnection())
                {
                    // List of models to create backing DB tables for 
                    List<Type> models = new List<Type>()
                    {
                        typeof (Mojito.Dal.Models.Contact),
                        typeof (Mojito.Dal.Models.Task)
                    };

                    models.ForEach(model => db.CreateTable(true, model));
                }
            }
        }
    }
}
