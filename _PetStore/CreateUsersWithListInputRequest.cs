
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using SwaggerPlayground.Common;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class CreateUsersWithListInputRequest
    {
      public IEnumerable<User> Body {get; set; }

      public override bool Equals(object obj)
        {
            return obj is CreateUsersWithListInputRequest && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(CreateUsersWithListInputRequest).GetHashCode();
                if(default != Body) hashCode = (hashCode * 397) ^ Body.GetHashCode();
                return hashCode;
            }
        }


    }




}


