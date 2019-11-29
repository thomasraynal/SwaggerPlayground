
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class UpdateUserRequest
    {
public string Username {get; set; }
public User Body {get; set; }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(UpdateUserRequest).GetHashCode();
                hashCode = (hashCode * 397) ^ Username.GetHashCode();
                hashCode = (hashCode * 397) ^ Body.GetHashCode();
                return hashCode;
            }
        }


    }
}


