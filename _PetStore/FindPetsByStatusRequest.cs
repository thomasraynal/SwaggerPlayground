
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class FindPetsByStatusRequest
    {
      public IEnumerable< string > Status {get; set; }

      public override bool Equals(object obj)
        {
            return obj is FindPetsByStatusRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(FindPetsByStatusRequest).GetHashCode();
                hashCode = (hashCode * 397) ^ Status.GetHashCode();
                return hashCode;
            }
        }


    }
}


