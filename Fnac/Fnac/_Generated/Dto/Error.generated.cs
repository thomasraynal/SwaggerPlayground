
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

    }

    public abstract class ErrorValidatorBase : AbstractValidator<Error>
    {
        public ErrorValidatorBase()
        {
        }
    }

}

