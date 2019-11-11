
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.Resources
{
    public class StoreItemRequest
    {


                public  Body {get; set;}



      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof( StoreItemRequest).GetHashCode();

                  hashCode = (hashCode * 397) ^ Body.GetHashCode();

                return hashCode;
            }
        }


    }
}


