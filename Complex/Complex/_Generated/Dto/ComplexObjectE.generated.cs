
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace ComplexApp.Complex
{


    public partial class ComplexObjectE
    {
      public Pack_type Pack_type {get; set; }
      public Team Team {get; set; }
      public ( long propA , ( long propC , IEnumerable<(string, int )> propD ) propB ) Something {get; set; }

//      public override bool Equals(object obj)
//        {
//            return obj is ComplexObjectE && obj.GetHashCode() == GetHashCode();
//        }

//      public override int GetHashCode()
//       {
//           unchecked
//            {
//                var hashCode = nameof(ComplexObjectE).GetHashCode();
//                if (default != Pack_type) hashCode = (hashCode * 397) ^ Pack_type.GetHashCode();
//                if (default != Team) hashCode = (hashCode * 397) ^ Team.GetHashCode();
//                if (default != Something) hashCode = (hashCode * 397) ^ Something.GetHashCode();
//                return hashCode;
//            }
//        }
    }

    public abstract class ComplexObjectEValidatorBase : AbstractValidator<ComplexObjectE>
    {
        public ComplexObjectEValidatorBase()
        {
        }
    }

}


