using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mojito.Dal.Models;

namespace Mojito.BusinessLogic.Services
{
    public interface IContactService : IBaseService<Contact>
    {
        List<Contact> FindByCompany(string companyName);
    }
}
