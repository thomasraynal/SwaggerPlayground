
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;

namespace RessourceServiceApp.RessourceServiceGateway
{
    public partial class ResourceItems
    {
      public IEnumerable< object > Data {get; set; }
      public DateTime Timestamp {get; set; }

//      public override bool Equals(object obj)
//        {
//            return obj is ResourceItems && obj.GetHashCode() == GetHashCode();
//        }

//      public override int GetHashCode()
//       {
//           unchecked
//            {
//                var hashCode = nameof(ResourceItems).GetHashCode();
//                if (default != Data) hashCode = (hashCode * 397) ^ Data.GetHashCode();
//                if (default != Timestamp) hashCode = (hashCode * 397) ^ Timestamp.GetHashCode();
//                return hashCode;
//            }
//        }
    }

    public abstract class ResourceItemsValidatorBase : AbstractValidator<ResourceItems>
    {
    public ResourceItemsValidatorBase()
    {
    }
    }

    }




