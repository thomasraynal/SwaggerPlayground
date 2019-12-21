
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace ComplexApp.Complex
{


    public partial class ComplexObjectA
    {
      public IEnumerable<(string, int )> PropA {get; set; }

//      public override bool Equals(object obj)
//        {
//            return obj is ComplexObjectA && obj.GetHashCode() == GetHashCode();
//        }

//      public override int GetHashCode()
//       {
//           unchecked
//            {
//                var hashCode = nameof(ComplexObjectA).GetHashCode();
//                if (default != PropA) hashCode = (hashCode * 397) ^ PropA.GetHashCode();
//                return hashCode;
//            }
//        }
    }

    public abstract class ComplexObjectAValidatorBase : AbstractValidator<ComplexObjectA>
    {
        public ComplexObjectAValidatorBase()
        {
        }
    }

}

