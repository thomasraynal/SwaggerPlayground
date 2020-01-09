
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace FnacApp.Fnac
{


    public partial class Offer
    {
      public string Status {get; set; }
      public string Product_fnac_id {get; set; }
      public string Offer_fnac_id {get; set; }
      public string Offer_seller_id {get; set; }
      public Error Error {get; set; }

    }

    public abstract class OfferValidatorBase : AbstractValidator<Offer>
    {
        public OfferValidatorBase()
        {
        }
    }

}

