
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace FnacApp.Fnac
{


    public partial class Offers_update
    {
      public string Shop_id {get; set; }
      public string Partner_id {get; set; }
      public string Token {get; set; }
      public string Offer {get; set; }

    }

    public abstract class Offers_updateValidatorBase : AbstractValidator<Offers_update>
    {
        public Offers_updateValidatorBase()
        {
        }
    }

}

