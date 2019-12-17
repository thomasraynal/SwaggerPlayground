
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy;
using SwaggerPlayground.Common;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class CreateUserRequest
    {
      public User Body {get; set; }

      public override bool Equals(object obj)
        {
            return obj is CreateUserRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(CreateUserRequest).GetHashCode();
                if(default != Body) hashCode = (hashCode * 397) ^ Body.GetHashCode();
                return hashCode;
            }
        }


    }




}


