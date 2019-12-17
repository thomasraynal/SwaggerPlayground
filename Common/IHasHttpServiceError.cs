using Nancy;
using System;

namespace SwaggerPlayground.Common
{
    public interface IHasHttpServiceError
    {
        public HttpStatusCode HttpStatusCode { get;  }
        public string Details { get; }
    }
}
