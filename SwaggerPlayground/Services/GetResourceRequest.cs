using System;
using System.Collections.Generic;
using System.Text;

namespace SwaggerPlayground.Services
{
    public class GetResourceRequest : DescriptorBase
    {
        public override int GetCacheKey()
        {
            return GetHashCode();
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Resource.GetHashCode();
                hashCode = (hashCode * 397) ^ Id.GetHashCode();
                hashCode = (hashCode * 397) ^ Date.GetHashCode();
                return hashCode;
            }
        }

    }
}
