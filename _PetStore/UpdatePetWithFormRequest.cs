
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using SwaggerPlayground.Common;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class UpdatePetWithFormRequest
    {
      public string PetId {get; set; }
      public string Name {get; set; }
      public string Status {get; set; }

      public override bool Equals(object obj)
        {
            return obj is UpdatePetWithFormRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(UpdatePetWithFormRequest).GetHashCode();
                if(default != PetId) hashCode = (hashCode * 397) ^ PetId.GetHashCode();
                if(default != Name) hashCode = (hashCode * 397) ^ Name.GetHashCode();
                if(default != Status) hashCode = (hashCode * 397) ^ Status.GetHashCode();
                return hashCode;
            }
        }


    }




}


