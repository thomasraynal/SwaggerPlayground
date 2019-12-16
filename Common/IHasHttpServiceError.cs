using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SwaggerPlayground.Common
{
    public interface IHasHttpServiceError
    {
        public HttpStatusCode HttpStatusCode { get;  }
    }
}
