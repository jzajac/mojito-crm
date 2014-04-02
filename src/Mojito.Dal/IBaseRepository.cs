using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mojito.Dal
{
    public interface IRepository<T> where T : IBaseEntity
    {
        T FindById(int id);

        List<T> FindAll(); 

        void Save(T entity);

        void Delete(int id);
    }
}
