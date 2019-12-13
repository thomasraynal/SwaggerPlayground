
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class UpdatePetRequest
    {
      public Pet Body {get; set; }

      public override bool Equals(object obj)
        {
            return obj is UpdatePetRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(UpdatePetRequest).GetHashCode();
                hashCode = (hashCode * 397) ^ Body.GetHashCode();
                return hashCode;
            }
        }


    }
}


