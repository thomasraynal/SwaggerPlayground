
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

    }

    public abstract class ComplexObjectBValidatorBase : AbstractValidator<ComplexObjectB>
    {
        public ComplexObjectBValidatorBase()
        {
        }
    }

}

