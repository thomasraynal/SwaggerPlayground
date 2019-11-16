
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class DeleteOrderRequest
    {
        public long OrderId {get; set; }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(DeleteOrderRequest).GetHashCode();
                hashCode = (hashCode * 397) ^ OrderId.GetHashCode();
                return hashCode;
            }
        }


    }
}


