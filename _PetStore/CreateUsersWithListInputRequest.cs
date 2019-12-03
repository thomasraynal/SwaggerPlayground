
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class CreateUsersWithListInputRequest
    {
public IEnumerable<User> Body {get; set; }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(CreateUsersWithListInputRequest).GetHashCode();
                hashCode = (hashCode * 397) ^ Body.GetHashCode();
                return hashCode;
            }
        }


    }
}

