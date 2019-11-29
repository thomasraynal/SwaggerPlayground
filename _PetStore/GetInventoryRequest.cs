
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class GetInventoryRequest
    {

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(GetInventoryRequest).GetHashCode();
                return hashCode;
            }
        }


    }
}


