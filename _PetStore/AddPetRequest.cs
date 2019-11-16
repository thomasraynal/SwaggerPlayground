
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class AddPetRequest
    {
        public Pet Body {get; set; }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(AddPetRequest).GetHashCode();
                hashCode = (hashCode * 397) ^ Body.GetHashCode();
                return hashCode;
            }
        }


    }
}


