using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwaggerPlayground.Services
{
    public class StoreResourceDescriptor : DescriptorBase
    {
        public JArray Data { get; set; }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = ResourceId.GetHashCode();
                hashCode = (hashCode * 397) ^ Date.GetHashCode();

                return hashCode;
            }
        }

        public override int GetCacheKey()
        {
            return GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is StoreResourceDescriptor && this.GetHashCode() == (obj as StoreResourceDescriptor).GetHashCode();
        }

        public String ResourceId
        {
            get
            {
                return String.IsNullOrEmpty(Resource) ? string.Empty : Resource.ToLower();
            }
        }
    }
}
