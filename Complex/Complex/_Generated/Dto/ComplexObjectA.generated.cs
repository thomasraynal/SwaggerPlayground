
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

    }

    public abstract class ComplexObjectAValidatorBase : AbstractValidator<ComplexObjectA>
    {
        public ComplexObjectAValidatorBase()
        {
        }
    }

}

