
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using SwaggerPlayground.Common;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class GetInventoryRequest
    {

      public override bool Equals(object obj)
        {
            return obj is GetInventoryRequest && obj.GetHashCode() == GetHashCode();
        }

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


