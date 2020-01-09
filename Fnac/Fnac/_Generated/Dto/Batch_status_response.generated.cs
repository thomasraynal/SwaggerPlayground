
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace FnacApp.Fnac
{


    public partial class Batch_status_response
    {
      public string Status {get; set; }
      public string Batch_id {get; set; }
      public IEnumerable<Offer> Offer {get; set; }
      public Error Error {get; set; }

    }

    public abstract class Batch_status_responseValidatorBase : AbstractValidator<Batch_status_response>
    {
        public Batch_status_responseValidatorBase()
        {
        }
    }

}

