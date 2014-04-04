using System.Text;

namespace Mojito.API
{
    using Nancy;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters =>
            {
                var json = Encoding.UTF8.GetBytes("hello");

                return new Response
                {
                    ContentType = "application/json",
                    Contents = s => s.Write(json, 0, json.Length)
                };
            };
        }
    }
}