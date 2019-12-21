
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace ComplexApp.Complex
{


    public partial class ComplexObjectC
    {
      public Pack_type Pack_type {get; set; }
      public Team Team {get; set; }
      public IEnumerable<(string, DateTime )> Something {get; set; }

//      public override bool Equals(object obj)
//        {
//            return obj is ComplexObjectC && obj.GetHashCode() == GetHashCode();
//        }

//      public override int GetHashCode()
//       {
//           unchecked
//            {
//                var hashCode = nameof(ComplexObjectC).GetHashCode();
//                if (default != Pack_type) hashCode = (hashCode * 397) ^ Pack_type.GetHashCode();
//                if (default != Team) hashCode = (hashCode * 397) ^ Team.GetHashCode();
//                if (default != Something) hashCode = (hashCode * 397) ^ Something.GetHashCode();
//                return hashCode;
//            }
//        }
    }

    public abstract class ComplexObjectCValidatorBase : AbstractValidator<ComplexObjectC>
    {
        public ComplexObjectCValidatorBase()
        {
        }
    }

}

