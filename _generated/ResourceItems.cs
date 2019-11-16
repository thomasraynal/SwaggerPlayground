
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerPlayground.Modules.Resources
{
    public class ResourceItems
    {
        public IEnumerable< object> Data {get; set; }
        public DateTime Timestamp {get; set; }

      public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(ResourceItems).GetHashCode();
                hashCode = (hashCode * 397) ^ Data.GetHashCode();
                hashCode = (hashCode * 397) ^ Timestamp.GetHashCode();
                return hashCode;
            }
        }
    }
}


