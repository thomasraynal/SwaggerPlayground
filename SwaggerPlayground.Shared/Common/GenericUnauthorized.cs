using Nancy;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwaggerPlayground.Common
{
    public class GenericUnauthorized : Exception, IHasHttpServiceError
    {
        public GenericUnauthorized()
            : base() { }

        public GenericUnauthorized(string message)
            : base(message) { }

        public GenericUnauthorized(string message, Exception innerException)
            : base(message, innerException) { }

        public HttpStatusCode HttpStatusCode => (HttpStatusCode)401;

        public string Details => Message;
    }
}
