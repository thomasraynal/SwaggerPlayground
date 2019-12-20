
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace FnacApp.Fnac
{
    public partial class Auth
    {
      public string Partner_id {get; set; }
      public string Shop_id {get; set; }
      public string Key {get; set; }

//      public override bool Equals(object obj)
//        {
//            return obj is Auth && obj.GetHashCode() == GetHashCode();
//        }

//      public override int GetHashCode()
//       {
//           unchecked
//            {
//                var hashCode = nameof(Auth).GetHashCode();
//                if (default != Partner_id) hashCode = (hashCode * 397) ^ Partner_id.GetHashCode();
//                if (default != Shop_id) hashCode = (hashCode * 397) ^ Shop_id.GetHashCode();
//                if (default != Key) hashCode = (hashCode * 397) ^ Key.GetHashCode();
//                return hashCode;
//            }
//        }
    }

    public abstract class AuthValidatorBase : AbstractValidator<Auth>
    {
    public AuthValidatorBase()
    {
    }
    }

    }



