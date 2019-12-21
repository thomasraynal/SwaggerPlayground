
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace FnacApp.Fnac
{


    public partial class Error
    {
      public Severity Severity {get; set; }
      public string Code {get; set; }

//      public override bool Equals(object obj)
//        {
//            return obj is Error && obj.GetHashCode() == GetHashCode();
//        }

//      public override int GetHashCode()
//       {
//           unchecked
//            {
//                var hashCode = nameof(Error).GetHashCode();
//                if (default != Severity) hashCode = (hashCode * 397) ^ Severity.GetHashCode();
//                if (default != Code) hashCode = (hashCode * 397) ^ Code.GetHashCode();
//                return hashCode;
//            }
//        }
    }

    public abstract class ErrorValidatorBase : AbstractValidator<Error>
    {
        public ErrorValidatorBase()
        {
        }
    }

}

