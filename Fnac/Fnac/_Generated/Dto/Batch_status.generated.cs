
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

//      public override bool Equals(object obj)
//        {
//            return obj is Batch_status && obj.GetHashCode() == GetHashCode();
//        }

//      public override int GetHashCode()
//       {
//           unchecked
//            {
//                var hashCode = nameof(Batch_status).GetHashCode();
//                if (default != Shop_id) hashCode = (hashCode * 397) ^ Shop_id.GetHashCode();
//                if (default != Partner_id) hashCode = (hashCode * 397) ^ Partner_id.GetHashCode();
//                if (default != Token) hashCode = (hashCode * 397) ^ Token.GetHashCode();
//                if (default != Batch_id) hashCode = (hashCode * 397) ^ Batch_id.GetHashCode();
//                return hashCode;
//            }
//        }
    }

    public abstract class Batch_statusValidatorBase : AbstractValidator<Batch_status>
    {
        public Batch_statusValidatorBase()
        {
        }
    }

}

