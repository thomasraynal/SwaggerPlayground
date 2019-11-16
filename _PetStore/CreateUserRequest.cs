
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class CreateUserRequest
    {
        public User Body {get; set; }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(CreateUserRequest).GetHashCode();
                hashCode = (hashCode * 397) ^ Body.GetHashCode();
                return hashCode;
            }
        }


    }
}


