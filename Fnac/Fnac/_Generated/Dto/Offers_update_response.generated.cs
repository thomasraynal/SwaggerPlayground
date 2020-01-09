
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace FnacApp.Fnac
{


    public partial class Offers_update_response
    {
      public string Status {get; set; }
      public string Batch_id {get; set; }
      public Error Error {get; set; }

    }

    public abstract class Offers_update_responseValidatorBase : AbstractValidator<Offers_update_response>
    {
        public Offers_update_responseValidatorBase()
        {
        }
    }

}

