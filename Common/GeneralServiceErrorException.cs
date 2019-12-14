using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SwaggerPlayground.Common
{
    public class GeneralServiceErrorException : Exception, IHasHttpServiceError
    {
        public GeneralServiceErrorException()
            : base() { }

        public GeneralServiceErrorException(string message)
            : base(message) { }

        public GeneralServiceErrorException(string message, Exception innerException)
            : base(message, innerException) { }

        public HttpServiceError HttpServiceError => new HttpServiceError(HttpStatusCode.InternalServerError, "Somthing wrong happens");
    }
}
