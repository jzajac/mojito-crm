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
    public class ContactRepository : IRepository<Contact>
    {
        private OrmLiteConnectionFactory conn = Factories.DbFactory.GetClient();

        /// <summary>
        /// Finds Contact entity by Id
        /// </summary>
        /// <param name="id">Entity id</param>
        /// <returns>Contact</returns>
        public Contact FindById(int id)
        {
            using (IDbConnection db = conn.OpenDbConnection())
            {
                return db.Select<Contact>(x => x.Id == id).SingleOrDefault();
            }
        }

        /// <summary>
        /// Finds all Contacts
        /// </summary>
        /// <returns>List of Contacts</returns>
        public List<Contact> FindAll()
        {
            using (IDbConnection db = conn.OpenDbConnection())
            {
                return db.Select<Contact>();
            }
        }

        /// <summary>
        /// Saves Contact entity in database
        /// </summary>
        /// <param name="entity">Contact</param>
        public void Save(Contact entity)
        {
            using (IDbConnection db = conn.OpenDbConnection())
            {
                db.Save(entity);
            }
        }

        /// <summary>
        /// Deletes Contact entity by id
        /// </summary>
        /// <param name="id">Id of Contact entity</param>
        public void Delete(int id)
        {
            using (IDbConnection db = conn.OpenDbConnection())
            {
                db.Delete<Contact>(x => x.Id == id);
            }
        }

        /// <summary>
        /// Creates table
        /// </summary>
        public void CreateTable()
        {
            using (IDbConnection db = conn.OpenDbConnection())
            {
                db.CreateTable<Contact>();
            }
        }
    }
}
