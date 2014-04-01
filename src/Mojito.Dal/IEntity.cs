using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace Mojito.Dal
{
    public interface IEntity
    {
        int Id { get; set; }
    }
}
