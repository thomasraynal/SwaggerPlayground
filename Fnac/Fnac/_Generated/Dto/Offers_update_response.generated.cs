
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

//      public override bool Equals(object obj)
//        {
//            return obj is Offers_update_response && obj.GetHashCode() == GetHashCode();
//        }

//      public override int GetHashCode()
//       {
//           unchecked
//            {
//                var hashCode = nameof(Offers_update_response).GetHashCode();
//                if (default != Status) hashCode = (hashCode * 397) ^ Status.GetHashCode();
//                if (default != Batch_id) hashCode = (hashCode * 397) ^ Batch_id.GetHashCode();
//                if (default != Error) hashCode = (hashCode * 397) ^ Error.GetHashCode();
//                return hashCode;
//            }
//        }
    }

    public abstract class Offers_update_responseValidatorBase : AbstractValidator<Offers_update_response>
    {
    public Offers_update_responseValidatorBase()
    {
    }
    }

    }



