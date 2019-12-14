
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.PetStore
{
    public partial class Tag
    {
      public long Id {get; set; }
      public string Name {get; set; }

//      public override bool Equals(object obj)
//        {
//            return obj is Tag && obj.GetHashCode() == GetHashCode();
//        }

//      public override int GetHashCode()
//       {
//           unchecked
//            {
//                var hashCode = nameof(Tag).GetHashCode();
//                if (default != Id) hashCode = (hashCode * 397) ^ Id.GetHashCode();
//                if (default != Name) hashCode = (hashCode * 397) ^ Name.GetHashCode();
//                return hashCode;
//            }
//        }
    }
}

