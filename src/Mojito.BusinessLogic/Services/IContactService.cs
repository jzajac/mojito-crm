using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mojito.Dal.Models;

namespace Mojito.BusinessLogic.Services
{
    public interface IContactService
    {
        Contact FindById(int id);

        List<Contact> FindAll();

        List<Contact> FindByCompany(string companyName);

        void Save(Contact entity);

        void Delete(int id);
    }
}
