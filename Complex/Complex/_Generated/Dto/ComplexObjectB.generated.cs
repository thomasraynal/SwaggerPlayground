
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace ComplexApp.Complex
{


    public partial class ComplexObjectB
    {
      public long PropA {get; set; }
      public IEnumerable<(string, int )> PropB {get; set; }

//      public override bool Equals(object obj)
//        {
//            return obj is ComplexObjectB && obj.GetHashCode() == GetHashCode();
//        }

//      public override int GetHashCode()
//       {
//           unchecked
//            {
//                var hashCode = nameof(ComplexObjectB).GetHashCode();
//                if (default != PropA) hashCode = (hashCode * 397) ^ PropA.GetHashCode();
//                if (default != PropB) hashCode = (hashCode * 397) ^ PropB.GetHashCode();
//                return hashCode;
//            }
//        }
    }

    public abstract class ComplexObjectBValidatorBase : AbstractValidator<ComplexObjectB>
    {
        public ComplexObjectBValidatorBase()
        {
        }
    }

}

