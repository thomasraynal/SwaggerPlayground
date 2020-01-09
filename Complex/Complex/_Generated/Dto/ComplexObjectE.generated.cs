
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
      public IEnumerable<(string, IEnumerable<(string, ( long propA , ( long propC , IEnumerable<(string, IEnumerable<(string, DateTime )> )> propD ) propB ))> )> Something {get; set; }

    }

    public abstract class ComplexObjectEValidatorBase : AbstractValidator<ComplexObjectE>
    {
        public ComplexObjectEValidatorBase()
        {
        }
    }

}


