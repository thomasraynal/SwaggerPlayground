
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class PlaceOrderRequest
    {
        public Order Body {get; set; }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(PlaceOrderRequest).GetHashCode();
                hashCode = (hashCode * 397) ^ Body.GetHashCode();
                return hashCode;
            }
        }


    }
}


