using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mojito.API
{
    using Nancy;

    public class ContactModule : NancyModule
    {
        public ContactModule()
            : base("/contact")
        {
            Get["/"] = parameters =>
            {

                var contactService = new BusinessLogic.Services.ContactService();

                return Negotiate
                    .WithStatusCode(HttpStatusCode.OK)
                    .WithContentType("application/json")
                    .WithModel(contactService.FindAll().ToArray());
            };
        }
    }
}