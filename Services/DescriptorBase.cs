using System;
using System.Collections.Generic;
using System.Text;

namespace SwaggerPlayground.Services
{
    public abstract class DescriptorBase
    {
        public String Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Timestamp { get; set; }
        public string Resource { get; set; }

        public abstract int GetCacheKey();

    }
}
