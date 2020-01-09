
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace FnacApp.Fnac
{


    public partial class Auth_response
    {
      public string Status {get; set; }
      public string Token {get; set; }
      public string Validity {get; set; }
      public string Version {get; set; }

    }

    public abstract class Auth_responseValidatorBase : AbstractValidator<Auth_response>
    {
        public Auth_responseValidatorBase()
        {
        }
    }

}

