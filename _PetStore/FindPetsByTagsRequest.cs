
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class FindPetsByTagsRequest
    {
      public IEnumerable< string > Tags {get; set; }

      public override bool Equals(object obj)
        {
            return obj is FindPetsByTagsRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(FindPetsByTagsRequest).GetHashCode();
                hashCode = (hashCode * 397) ^ Tags.GetHashCode();
                return hashCode;
            }
        }


    }
}


