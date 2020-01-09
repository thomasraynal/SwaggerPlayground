
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace FnacApp.Fnac
{


    public partial class Batch_status
    {
      public string Shop_id {get; set; }
      public string Partner_id {get; set; }
      public string Token {get; set; }
      public string Batch_id {get; set; }

    }

    public abstract class Batch_statusValidatorBase : AbstractValidator<Batch_status>
    {
        public Batch_statusValidatorBase()
        {
        }
    }

}

