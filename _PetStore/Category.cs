
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class Category
    {
        public Name {get; set; }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(Category).GetHashCode();
                hashCode = (hashCode * 397) ^ Name.GetHashCode();
                return hashCode;
            }
        }
    }
}

