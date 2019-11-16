
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class Pet
    {
        public Name {get; set; }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(Pet).GetHashCode();
                hashCode = (hashCode * 397) ^ Name.GetHashCode();
                return hashCode;
            }
        }
    }
}

