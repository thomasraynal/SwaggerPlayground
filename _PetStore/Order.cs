
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class Order
    {
        public Name {get; set; }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(Order).GetHashCode();
                hashCode = (hashCode * 397) ^ Name.GetHashCode();
                return hashCode;
            }
        }
    }
}

