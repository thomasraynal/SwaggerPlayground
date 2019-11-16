
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class LogoutUserRequest
    {

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(LogoutUserRequest).GetHashCode();
                return hashCode;
            }
        }


    }
}


