
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class DeletePetRequest
    {
      public string Api_key {get; set; }
      public long PetId {get; set; }

      public override bool Equals(object obj)
        {
            return obj is DeletePetRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(DeletePetRequest).GetHashCode();
                hashCode = (hashCode * 397) ^ Api_key.GetHashCode();
                hashCode = (hashCode * 397) ^ PetId.GetHashCode();
                return hashCode;
            }
        }


    }
}


