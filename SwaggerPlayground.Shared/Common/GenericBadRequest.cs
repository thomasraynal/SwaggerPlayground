using Nancy;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwaggerPlayground.Common
{
    public class GenericBadRequest : Exception, IHasHttpServiceError
    {
        public GenericBadRequest()
            : base() { }

        public GenericBadRequest(string message)
            : base(message) { }

        public GenericBadRequest(string message, Exception innerException)
            : base(message, innerException) { }

        public HttpStatusCode HttpStatusCode => (HttpStatusCode)400;

        public string Details => Message;
    }
}
