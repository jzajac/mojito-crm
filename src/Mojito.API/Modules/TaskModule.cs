using System.Text;

namespace Mojito.API
{
    using Nancy;

    public class TaskModule : NancyModule
    {
        public TaskModule() : base("/task")
        {
            Get["/"] = parameters =>
            {

                var taskService = new BusinessLogic.Services.TaskService();

                return Negotiate
                    .WithStatusCode(HttpStatusCode.OK)
                    .WithContentType("application/json")
                    .WithModel(taskService.FindAll().ToArray());
            };
        }
    }
}