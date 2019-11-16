
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class GetUserByNameRequest
    {
        public string Username {get; set; }

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


