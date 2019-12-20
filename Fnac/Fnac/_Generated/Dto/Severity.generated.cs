
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace FnacApp.Fnac
{
    public partial class Severity
    {

//      public override bool Equals(object obj)
//        {
//            return obj is Severity && obj.GetHashCode() == GetHashCode();
//        }

//      public override int GetHashCode()
//       {
//           unchecked
//            {
//                var hashCode = nameof(Severity).GetHashCode();
//                return hashCode;
//            }
//        }
    }

    public abstract class SeverityValidatorBase : AbstractValidator<Severity>
    {
    public SeverityValidatorBase()
    {
    }
    }

    }




