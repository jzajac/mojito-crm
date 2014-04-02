using System.Collections.Generic;
using Mojito.Dal.Models;
using Mojito.Dal.Repository;

namespace Mojito.BusinessLogic.Services
{
    public class TaskService : ITaskService
    {
        TaskRepository repository = new TaskRepository();

        public Task FindById(int id)
        {
            return repository.FindById(id);
        }

        public List<Task> FindAll()
        {
            return repository.FindAll();
        }

        public void Save(Task entity)
        {
            repository.Save(entity);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}