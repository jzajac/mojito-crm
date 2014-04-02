using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace Mojito.Dal.Models
{
    public class Contact : IBaseEntity
    {
        [AutoIncrement]
        public int Id { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string Company { get; set; }

    }
}
