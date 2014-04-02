using System.Collections.Generic;

namespace Mojito.BusinessLogic
{
    public interface IBaseService<T>
    {
        T FindById(int id);

        List<T> FindAll();

        void Save(T entity);

        void Delete(int id);
    }
}