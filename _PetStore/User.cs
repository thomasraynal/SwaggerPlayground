
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class User
    {
      public long Id {get; set; }
      public string Username {get; set; }
      public string FirstName {get; set; }
      public string LastName {get; set; }
      public string Email {get; set; }
      public string Password {get; set; }
      public string Phone {get; set; }
      public int UserStatus {get; set; }

      public override bool Equals(object obj)
        {
            return obj is User && obj.GetHashCode() == GetHashCode();
        }

      public override int GetHashCode()
       {
            unchecked
            {
                var hashCode = nameof(User).GetHashCode();
                hashCode = (hashCode * 397) ^ Id.GetHashCode();
                hashCode = (hashCode * 397) ^ Username.GetHashCode();
                hashCode = (hashCode * 397) ^ FirstName.GetHashCode();
                hashCode = (hashCode * 397) ^ LastName.GetHashCode();
                hashCode = (hashCode * 397) ^ Email.GetHashCode();
                hashCode = (hashCode * 397) ^ Password.GetHashCode();
                hashCode = (hashCode * 397) ^ Phone.GetHashCode();
                hashCode = (hashCode * 397) ^ UserStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}

