
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class User
    {
      public long Id {get; set; }
      public string Username {get; set; }
      public string FirstName {get; set; }
      public string LastName {get; set; }
      public string Email {get; set; }
      public string Password {get; set; }
      public string Phone {get; set; }
      public int UserStatus {get; set; }

//      public override bool Equals(object obj)
//        {
//            return obj is User && obj.GetHashCode() == GetHashCode();
//        }

//      public override int GetHashCode()
//       {
//           unchecked
//            {
//                var hashCode = nameof(User).GetHashCode();
//                if (default != Id) hashCode = (hashCode * 397) ^ Id.GetHashCode();
//                if (default != Username) hashCode = (hashCode * 397) ^ Username.GetHashCode();
//                if (default != FirstName) hashCode = (hashCode * 397) ^ FirstName.GetHashCode();
//                if (default != LastName) hashCode = (hashCode * 397) ^ LastName.GetHashCode();
//                if (default != Email) hashCode = (hashCode * 397) ^ Email.GetHashCode();
//                if (default != Password) hashCode = (hashCode * 397) ^ Password.GetHashCode();
//                if (default != Phone) hashCode = (hashCode * 397) ^ Phone.GetHashCode();
//                if (default != UserStatus) hashCode = (hashCode * 397) ^ UserStatus.GetHashCode();
//                return hashCode;
//            }
//        }
    }

    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
        }
    }

}



