
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class GetPetByIdRequest
    {
      public long PetId {get; set; }

      public override bool Equals(object obj)
        {
            return obj is GetPetByIdRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(GetPetByIdRequest).GetHashCode();
                hashCode = (hashCode * 397) ^ PetId.GetHashCode();
                return hashCode;
            }
        }


    }
}


