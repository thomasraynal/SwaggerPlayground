
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace FnacApp.Fnac
{


    public partial class Auth
    {
      public string Partner_id {get; set; }
      public string Shop_id {get; set; }
      public string Key {get; set; }

    }

    public abstract class AuthValidatorBase : AbstractValidator<Auth>
    {
        public AuthValidatorBase()
        {
        }
    }

}

