
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class GetUserByNameRequest
    {
      public string Username {get; set; }

      public override bool Equals(object obj)
        {
            return obj is GetUserByNameRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(GetUserByNameRequest).GetHashCode();
                hashCode = (hashCode * 397) ^ Username.GetHashCode();
                return hashCode;
            }
        }


    }
}


