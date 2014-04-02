using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mojito.Dal.Models;
using ServiceStack.OrmLite;

namespace Mojito.Dal.Repository
{
    public class TaskRepository : IRepository<Mojito.Dal.Models.Task>
    {
        private OrmLiteConnectionFactory conn = Factories.DbFactory.GetClient();

        /// <summary>
        /// Finds Contact entity by Id
        /// </summary>
        /// <param name="id">Entity id</param>
        /// <returns>Contact</returns>
        public Models.Task FindById(int id)
        {
            using (IDbConnection db = conn.OpenDbConnection())
            {
                return db.Select<Models.Task>(x => x.Id == id).SingleOrDefault();
            }
        }

        /// <summary>
        /// Finds all Tasks
        /// </summary>
        /// <returns>List of Contacts</returns>
        public List<Models.Task> FindAll()
        {
            using (IDbConnection db = conn.OpenDbConnection())
            {
                return db.Select<Models.Task>();
            }
        }

        /// <summary>
        /// Saves Task entity in database
        /// </summary>
        /// <param name="entity">Contact</param>
        public void Save(Models.Task entity)
        {
            using (IDbConnection db = conn.OpenDbConnection())
            {
                db.Save(entity);
            }
        }

        /// <summary>
        /// Deletes Task entity by id
        /// </summary>
        /// <param name="id">Id of Contact entity</param>
        public void Delete(int id)
        {
            using (IDbConnection db = conn.OpenDbConnection())
            {
                db.Delete<Models.Task>(x => x.Id == id);
            }
        }
    }
}
