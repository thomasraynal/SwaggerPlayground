
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class User
    {
        public Name {get; set; }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(User).GetHashCode();
                hashCode = (hashCode * 397) ^ Name.GetHashCode();
                return hashCode;
            }
        }
    }
}

