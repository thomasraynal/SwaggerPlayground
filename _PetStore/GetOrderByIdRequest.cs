
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class GetOrderByIdRequest
    {
public long OrderId {get; set; }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(GetOrderByIdRequest).GetHashCode();
                hashCode = (hashCode * 397) ^ OrderId.GetHashCode();
                return hashCode;
            }
        }


    }
}


