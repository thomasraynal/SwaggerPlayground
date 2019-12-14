
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class Order
    {
      public long Id {get; set; }
      public long PetId {get; set; }
      public int Quantity {get; set; }
      public string ShipDate {get; set; }
      public Status Status {get; set; }
      public bool Complete {get; set; }

//      public override bool Equals(object obj)
//        {
//            return obj is Order && obj.GetHashCode() == GetHashCode();
//        }

//      public override int GetHashCode()
//       {
//           unchecked
//            {
//                var hashCode = nameof(Order).GetHashCode();
//                if (default != Id) hashCode = (hashCode * 397) ^ Id.GetHashCode();
//                if (default != PetId) hashCode = (hashCode * 397) ^ PetId.GetHashCode();
//                if (default != Quantity) hashCode = (hashCode * 397) ^ Quantity.GetHashCode();
//                if (default != ShipDate) hashCode = (hashCode * 397) ^ ShipDate.GetHashCode();
//                if (default != Status) hashCode = (hashCode * 397) ^ Status.GetHashCode();
//                if (default != Complete) hashCode = (hashCode * 397) ^ Complete.GetHashCode();
//                return hashCode;
//            }
//        }
    }
}

