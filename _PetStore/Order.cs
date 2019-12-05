
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public class Order
    {
public long Id {get; set; }
public long PetId {get; set; }
public int Quantity {get; set; }
public         string ShipDate {get; set; }
public         string Status {get; set; }
public bool Complete {get; set; }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(Order).GetHashCode();
                hashCode = (hashCode * 397) ^ Id.GetHashCode();
                hashCode = (hashCode * 397) ^ PetId.GetHashCode();
                hashCode = (hashCode * 397) ^ Quantity.GetHashCode();
                hashCode = (hashCode * 397) ^ ShipDate.GetHashCode();
                hashCode = (hashCode * 397) ^ Status.GetHashCode();
                hashCode = (hashCode * 397) ^ Complete.GetHashCode();
                return hashCode;
            }
        }
    }
}

