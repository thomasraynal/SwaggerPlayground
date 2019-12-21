
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace FnacApp.Fnac
{


    public partial class Auth_response
    {
      public string Status {get; set; }
      public string Token {get; set; }
      public string Validity {get; set; }
      public string Version {get; set; }

//      public override bool Equals(object obj)
//        {
//            return obj is Auth_response && obj.GetHashCode() == GetHashCode();
//        }

//      public override int GetHashCode()
//       {
//           unchecked
//            {
//                var hashCode = nameof(Auth_response).GetHashCode();
//                if (default != Status) hashCode = (hashCode * 397) ^ Status.GetHashCode();
//                if (default != Token) hashCode = (hashCode * 397) ^ Token.GetHashCode();
//                if (default != Validity) hashCode = (hashCode * 397) ^ Validity.GetHashCode();
//                if (default != Version) hashCode = (hashCode * 397) ^ Version.GetHashCode();
//                return hashCode;
//            }
//        }
    }

    public abstract class Auth_responseValidatorBase : AbstractValidator<Auth_response>
    {
        public Auth_responseValidatorBase()
        {
        }
    }

}

