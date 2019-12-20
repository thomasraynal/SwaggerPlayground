
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

//      public override bool Equals(object obj)
//        {
//            return obj is Offers_update && obj.GetHashCode() == GetHashCode();
//        }

//      public override int GetHashCode()
//       {
//           unchecked
//            {
//                var hashCode = nameof(Offers_update).GetHashCode();
//                if (default != Shop_id) hashCode = (hashCode * 397) ^ Shop_id.GetHashCode();
//                if (default != Partner_id) hashCode = (hashCode * 397) ^ Partner_id.GetHashCode();
//                if (default != Token) hashCode = (hashCode * 397) ^ Token.GetHashCode();
//                if (default != Offer) hashCode = (hashCode * 397) ^ Offer.GetHashCode();
//                return hashCode;
//            }
//        }
    }

    public abstract class Offers_updateValidatorBase : AbstractValidator<Offers_update>
    {
    public Offers_updateValidatorBase()
    {
    }
    }

    }



