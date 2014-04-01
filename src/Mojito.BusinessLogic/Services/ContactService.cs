using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mojito.Dal.Models;
using Mojito.Dal.Repository;

namespace Mojito.BusinessLogic.Services
{
    public class ContactService : IContactService
    {
        ContactRepository repository = new ContactRepository();

        public Contact FindById(int id)
        {
            return repository.FindById(id);
        }

        public List<Contact> FindAll()
        {
            return repository.FindAll();
        }

        public List<Contact> FindByCompany(string companyName)
        {
            throw new NotImplementedException();
        }

        public void Save(Contact entity)
        {
            repository.Save(entity);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
