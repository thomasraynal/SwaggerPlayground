
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class Category
    {
      public long Id {get; set; }
      public string Name {get; set; }

      public override bool Equals(object obj)
        {
            return obj is Category && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
       {
            unchecked
            {
                var hashCode = nameof(Category).GetHashCode();
                hashCode = (hashCode * 397) ^ Id.GetHashCode();
                hashCode = (hashCode * 397) ^ Name.GetHashCode();
                return hashCode;
            }
        }
    }
}

