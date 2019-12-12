
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class UpdatePetWithFormRequest
    {
      public string PetId {get; set; }
      public string Name {get; set; }
      public string Status {get; set; }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(UpdatePetWithFormRequest).GetHashCode();
                hashCode = (hashCode * 397) ^ PetId.GetHashCode();
                hashCode = (hashCode * 397) ^ Name.GetHashCode();
                hashCode = (hashCode * 397) ^ Status.GetHashCode();
                return hashCode;
            }
        }


    }
}


