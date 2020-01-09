
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

    }

    public abstract class ComplexObjectCValidatorBase : AbstractValidator<ComplexObjectC>
    {
        public ComplexObjectCValidatorBase()
        {
        }
    }

}

