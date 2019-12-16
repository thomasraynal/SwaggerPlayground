
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using SwaggerPlayground.Common;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class LogoutUserRequest
    {

      public override bool Equals(object obj)
        {
            return obj is LogoutUserRequest && obj.GetHashCode() == GetHashCode();
        }

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


