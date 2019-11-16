
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class FindPetsByStatusRequest
    {
        public IEnumerable< string> Status {get; set; }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(FindPetsByStatusRequest).GetHashCode();
                hashCode = (hashCode * 397) ^ Status.GetHashCode();
                return hashCode;
            }
        }


    }
}


