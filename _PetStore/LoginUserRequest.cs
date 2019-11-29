
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class LoginUserRequest
    {
public string Username {get; set; }
public string Password {get; set; }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(LoginUserRequest).GetHashCode();
                hashCode = (hashCode * 397) ^ Username.GetHashCode();
                hashCode = (hashCode * 397) ^ Password.GetHashCode();
                return hashCode;
            }
        }


    }
}


