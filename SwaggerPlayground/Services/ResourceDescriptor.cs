using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwaggerPlayground.Services
{
    [Serializable]
    public class ResourceDescriptor : DescriptorBase
    {
        public ResourceDescriptor()
        {
            Timestamp = DateTime.Now;
        }

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
            return obj is ResourceDescriptor && this.GetHashCode() == (obj as ResourceDescriptor).GetHashCode();
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
