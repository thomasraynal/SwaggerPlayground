
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

//      public override bool Equals(object obj)
//        {
//            return obj is Offer && obj.GetHashCode() == GetHashCode();
//        }

//      public override int GetHashCode()
//       {
//           unchecked
//            {
//                var hashCode = nameof(Offer).GetHashCode();
//                if (default != Status) hashCode = (hashCode * 397) ^ Status.GetHashCode();
//                if (default != Product_fnac_id) hashCode = (hashCode * 397) ^ Product_fnac_id.GetHashCode();
//                if (default != Offer_fnac_id) hashCode = (hashCode * 397) ^ Offer_fnac_id.GetHashCode();
//                if (default != Offer_seller_id) hashCode = (hashCode * 397) ^ Offer_seller_id.GetHashCode();
//                if (default != Error) hashCode = (hashCode * 397) ^ Error.GetHashCode();
//                return hashCode;
//            }
//        }
    }

    public abstract class OfferValidatorBase : AbstractValidator<Offer>
    {
    public OfferValidatorBase()
    {
    }
    }

    }



